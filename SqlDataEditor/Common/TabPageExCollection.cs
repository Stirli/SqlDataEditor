using SqlDataEditor.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataEditor.Common
{
	public class TabPageExCollection : ObservableCollection<Control>
	{
		public Control this[string key]
		{
			get => this.First(p => p.Name == key);
			set => this.SetItem(this.FindIndex(page => page.Name == key), value);
		}

		public bool ContainsKey(string key)
		{
			return this.Any(p => p.Name == key);
		}
	}
}
