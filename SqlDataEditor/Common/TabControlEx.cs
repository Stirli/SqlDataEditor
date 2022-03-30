using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataEditor.Common
{
	public partial class TabControlEx : UserControl
	{
		public TabControlEx()
		{
			InitializeComponent();
			_headersDic = new();
			TabPages = new();
			TabPages.CollectionChanged += TabPages_CollectionChanged;
		}

		private Dictionary<string, (TabPageHeader header, Control page)> _headersDic;
		private Control? _selectedTab;

		private void TabPages_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
					foreach (Control page in e.NewItems)
					{
						TabPageHeader header = new()
						{
							Text = page.Text
						};

						header.Click += (s, e) => SelectedTab = page;
						header.CloseButtonClick += (s, e) =>
						{
							TabPages.Remove(page);
						};
						_headersDic.Add(page.Name, (header, page));
						headerPanel.Controls.Add(header);
					}

					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
					foreach (Control item in e.OldItems)
					{
						headerPanel.Controls.Remove(_headersDic[item.Name].header);
						_headersDic.Remove(item.Name);
						SelectedTab = TabPages.LastOrDefault();
					}

					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
					headerPanel.Controls.Clear();
					break;
			}
		}

		public TabPageExCollection TabPages { get; set; }
		public Control? SelectedTab
		{
			get => _selectedTab; set
			{
				if (_selectedTab == value)
				{
					return;
				}

				contentPanel.Controls.Clear();
				if (value is not null)
				{

					value.BackColor = Color.Blue;
					contentPanel.Controls.Add(value);
					value.Dock = DockStyle.Fill;
					//_headersDic[value.Name].header.BorderStyle =  BorderStyle.FixedSingle;
					_headersDic[value.Name].header.BackColor = SystemColors.Highlight;
					_headersDic[value.Name].header.ForeColor = SystemColors.HighlightText;
				}

				if (_selectedTab is not null && _headersDic.ContainsKey(_selectedTab.Name))
				{
					//_headersDic[_selectedTab.Name].header.BorderStyle = BorderStyle.None;
					_headersDic[_selectedTab.Name].header.BackColor = SystemColors.Control;
					_headersDic[_selectedTab.Name].header.ForeColor = SystemColors.ControlText;
				}

				_selectedTab = value;
			}
		}

	}
}
