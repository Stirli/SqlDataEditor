using SqlDataEditor.Extensions;
using SqlDataEditor.Views;
using System.Data;

namespace SqlDataEditor
{
	public partial class MainForm : Form, IMainForm
	{
		public MainForm()
		{
			InitializeComponent();
			tabControl1.TabPages.Clear();
		}

		public event EventHandler<string[]>? TableDataRequest;
		public event EventHandler<string[]> UpdateTablesRequest;
		public event EventHandler<string> TableClosed;

		public void AddTable(DataTable table)
		{
			TabPage page = new(table.TableName);
			page.Name = table.TableName;
			page.ContextMenuStrip = tabContextMenuStrip;
			page.Controls.Add(new DataGridView()
			{
				DataSource = table,
				Dock = DockStyle.Fill,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
			});

			tabControl1.TabPages.Add(page);
		}

		public void SetTablesList(string[] list)
		{
			tabControl1.TabPages.Clear();
			tablesList.DataSource = list;
		}


		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataTable[] arr = tabControl1.TabPages.SelectMany<DataGridView, DataTable>(c => ((DataTable)c.DataSource)).ToArray();
			UpdateTablesRequest?.Invoke(this, tabControl1.TabPages.Select(p=>p.Name).ToArray());
		}

		private void updateTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateTablesRequest?.Invoke(this, new[] { tabControl1.SelectedTab.Name });
		}

		private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string[] arr = tablesList.SelectedItems.Cast<string>().Where(s => !(s is null || tabControl1.TabPages.ContainsKey(s))).ToArray();
			TableDataRequest?.Invoke(this, arr);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TableClosed?.Invoke(this, tabControl1.SelectedTab.Name);
			tabControl1.TabPages.Remove(tabControl1.SelectedTab);
		}
	}
}