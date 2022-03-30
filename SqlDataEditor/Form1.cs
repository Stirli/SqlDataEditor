using SqlDataEditor.Common;
using SqlDataEditor.Extensions;
using SqlDataEditor.ThisControls;
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
			tabControl1.TabPages.CollectionChanged += (s, e) =>
			{
				if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
				{
					foreach (DataPage item in e.OldItems)
					{
						TableClosed?.Invoke(this, item.Name);
					}
				}
			};
		}

		public event EventHandler<string[]>? TableDataRequest;
		public event EventHandler<string[]> UpdateTablesRequest;
		public event EventHandler<string> TableClosed;

		public void AddTable(DataTable table)
		{
			DataPage page = new()
			{
				Text = table.TableName,
				Name = table.TableName
			};
			page.DataSource = table;
			tabControl1.TabPages.Add(page);
			tabControl1.SelectedTab = page;
		}

		public void SetTablesList(string[] list)
		{
			tabControl1.TabPages.Clear();
			tablesList.DataSource = list;
		}


		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataTable[] arr = tabControl1.TabPages.SelectMany<DataGridView, DataTable>(c => ((DataTable)c.DataSource)).ToArray();
			UpdateTablesRequest?.Invoke(this, tabControl1.TabPages.Select(p => p.Name).ToArray());
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

		private void tabControl1_ControlAdded(object sender, ControlEventArgs e)
		{
			e.Control.ContextMenuStrip = tabContextMenuStrip;
		}
	}
}