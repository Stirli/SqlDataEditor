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
		public event EventHandler<DataTable[]> TableUpdateRequest;
		public event EventHandler<DataTable> TableClosed;

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
			TableUpdateRequest?.Invoke(this, arr);
		}

		private void updateTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TableUpdateRequest?.Invoke(this, new[]{tabControl1.SelectedTab.Controls.OfType<DataGridView>().First().DataSource as DataTable});
		}

		private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string[] arr = tablesList.SelectedItems.Cast<string>().Where(s => !(s is null || tabControl1.TabPages.ContainsKey(s))).ToArray();
			TableDataRequest?.Invoke(this, arr);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataTable? table = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First().DataSource as DataTable;
			TableClosed?.Invoke(this, table);
			tabControl1.TabPages.Remove(tabControl1.SelectedTab);
		}
	}
}