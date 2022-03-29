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
    public partial class Editor : UserControl
    {
        private EditorType _type;

        public Editor()
        {
            InitializeComponent();
        }

        [Description("Text above editor"), Category("Editor parameters")]
        public string Header { get => groupBox.Text; set => groupBox.Text = value; }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("Editor Text"), Category("Editor parameters")]
        public override string Text { get => textBox.Text; set => textBox.Text = value; }


        [Description("Editor Text"), Category("Editor parameters")]
        public EditorType Type
        {
            get => _type; set
            {
                _type = value;
                switch (_type)
                {
                    case EditorType.Text:
                        textBox.UseSystemPasswordChar = false;
                        break;
                    case EditorType.Password:
                        textBox.UseSystemPasswordChar = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public enum EditorType
        {
            Text,
            Password
        }
    }
}
