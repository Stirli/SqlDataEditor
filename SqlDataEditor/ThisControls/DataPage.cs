using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataEditor.ThisControls
{
	public partial class DataPage : UserControl
	{
		public DataPage()
		{
			InitializeComponent();
		}
		public DataPage(string name)
		{
			InitializeComponent();
			Name = Text = name;
		}
		public DataPage(string name, string text)
		{
			InitializeComponent();
			Name = name;
			Text = text;
		}

		public DataTable? DataSource { get => dataGridView1.DataSource as DataTable; set => dataGridView1.DataSource = value; }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			panel1.Visible = !string.IsNullOrEmpty(textBox1.Text);
		}

		private void dataGridView1_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
		{
		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			textBox1.Text = $"Row {e.RowIndex} Col {e.ColumnIndex}:{e.Exception.Message}";
		}
	}
}
