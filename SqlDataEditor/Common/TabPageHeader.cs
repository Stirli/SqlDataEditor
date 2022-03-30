using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataEditor.Common
{
	public partial class TabPageHeader : UserControl
	{
		public TabPageHeader()
		{
			InitializeComponent();
		}

		public override string Text { get => label1.Text; set => label1.Text = value; }
		public override ContextMenuStrip ContextMenuStrip { get => label1.ContextMenuStrip; set => label1.ContextMenuStrip = value; }

		public new event EventHandler Click;
		public event EventHandler CloseButtonClick;

		protected override void OnClick(EventArgs e)
		{
			Click?.Invoke(this, e);
		}		

		protected void OnCloseButtonClick(object sender, EventArgs e)
		{
			CloseButtonClick?.Invoke(sender, e);
		}
		private void label1_Click(object sender, EventArgs e)
		{
			OnClick(e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OnCloseButtonClick(sender, e);
		}
	}
}
