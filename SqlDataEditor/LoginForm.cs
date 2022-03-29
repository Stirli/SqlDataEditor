
using SqlDataEditor.Views;

namespace SqlDataEditor
{
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string ServerAdress { get => serverEditor.Text; set => serverEditor.Text = value; }
        public string DatabaseName { get => dbNameBox.Text; set => dbNameBox.Text = value; }
        public string UserName { get => userBox.Text; set => userBox.Text = value; }
        public string Password { get => passwdBox.Text; set => passwdBox.Text = value; }
    }
}
