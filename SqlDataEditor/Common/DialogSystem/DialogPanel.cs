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
    public partial class DialogPanel : UserControl
    {
        private Form? _lastParent;

        public DialogPanel()
        {
            InitializeComponent();
        }

        private void DialogPanel_ParentChanged(object sender, EventArgs e)
        {
            if (_lastParent != null)
            {
                RestoreForm(_lastParent);
            }

            if (Parent is Form form)
            {
                InitForm(form);
                ShowChildren(true);
                messageLable.Hide();
                _lastParent = form;
            }
            else
            {
                ShowChildren(false);
                messageLable.Show();
                this.Dock = DockStyle.None;
                _lastParent = null;
            }
        }

        private void ShowChildren(bool state)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = state;
            }
        }

        private void InitForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = SystemColors.ControlLightLight;
            this.BackColor = SystemColors.Control;
            this.Dock = DockStyle.Bottom;

            form.AcceptButton = okButton;
            form.CancelButton = cancelButton;
        }

        private void RestoreForm(Form form)
        {
            form.AcceptButton = null;
            form.CancelButton = null;
            form.MinimizeBox = true;
            form.MaximizeBox = true;
            form.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
