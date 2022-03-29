using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataEditor.Views
{
	internal interface IMainForm
	{
		string Text { get; set; }

		void SetTablesList(string[] vs);
		void AddTable(DataTable table);

		public event EventHandler<string[]> TableDataRequest;
		public event EventHandler<string[]> UpdateTablesRequest;
		public event EventHandler<string> TableClosed;

	}
}
