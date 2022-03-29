using Microsoft.Data.SqlClient;
using SqlDataEditor.Extensions;
using SqlDataEditor.Properties;
using SqlDataEditor.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataEditor.Presentation
{
	internal class MainPresenter:IDisposable
	{
		private IMainForm _main;
		private ILoginForm _loginForm;

		private SqlConnection _connection;
		Dictionary<string, (DataTable Table, SqlDataAdapter Adapter)> _adapeterDic;

		public void Start()
		{
			_loginForm = new LoginForm()
			{
				ServerAdress = Settings.Default.Server,
				DatabaseName = Settings.Default.Database,
				UserName = Settings.Default.User
			};

			_main = new MainForm();
			_main.TableDataRequest += Main_TableDataRequest;
			_main.UpdateTablesRequest += Main_TableUpdateRequest;
			_main.TableClosed += Main_TableClosed;


			if (_loginForm.ShowDialog() == DialogResult.OK)
			{
				_adapeterDic = new();

				string connectionString = $"Server={_loginForm.ServerAdress};Database={_loginForm.DatabaseName};User Id={_loginForm.UserName};Password={_loginForm.Password}; TrustServerCertificate=True;";

				_connection = new(connectionString);

				SaveSettings();

				using SqlDataAdapter adapter = new("SELECT * FROM INFORMATION_SCHEMA.TABLES", _connection);
				using DataSet dataSet = new();
				adapter.Fill(dataSet);

				_main.Text = $"{_connection.DataSource}; {_connection.Database}";
				_main.SetTablesList(dataSet.Tables[0].Rows.SelectOfType<DataRow,string>(r => r.Field<string>("TABLE_NAME")).ToArray());

				Application.Run(_main as Form);
			}
		}

		private void Main_TableClosed(object? sender, string tableName)
		{
			(DataTable Table, SqlDataAdapter Adapter) = _adapeterDic[tableName];
			Table.Dispose();
			Adapter.Dispose();
			_adapeterDic.Remove(tableName);
		}

		private void Main_TableUpdateRequest(object? sender, string[] e)
		{
			foreach (var item in e)
			{
				(DataTable Table, SqlDataAdapter Adapter) = _adapeterDic[item];
				
				SqlCommandBuilder cb = new (Adapter);
				Adapter.Update(Table);
			}
		}

		private void Main_TableDataRequest(object? sender, string[] e)
		{
			foreach (var s in e)
			{
				SqlDataAdapter adapter = new($"SELECT * FROM {s}", _connection);
				DataTable table = new(s);
				adapter.Fill(table);
				_main.AddTable(table);
				_adapeterDic.Add(s, (table, adapter));
			}
		}

		private void SaveSettings()
		{
			Settings.Default.Server = _loginForm.ServerAdress;
			Settings.Default.Database = _loginForm.DatabaseName;
			Settings.Default.User = _loginForm.UserName;
		}

		public void Dispose()
		{
			foreach (var item in _adapeterDic)
			{
				item.Value.Table.Dispose();
				item.Value.Adapter.Dispose();
			}

			_connection.Dispose();
		}
	}
}
