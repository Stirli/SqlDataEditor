using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataEditor.Views
{
    internal interface ILoginForm
    {
        public string ServerAdress { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DialogResult ShowDialog();
    }
}
