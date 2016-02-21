using OrderControl.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderControl.Gui
{
    class LoginViewModel
    {
        private LoginController controller;
        private Login view;

        private string userName;
        private string password;
        private int retryCounter;

        public LoginViewModel(Login view)
        {
            this.view = view;
            controller = new LoginController();
            retryCounter = 0;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public void Login(object sender, EventArgs e)
        {
            Global glob = controller.Login(userName, password);
            if (glob == null)
            {
                retryCounter++;
                if (retryCounter >= 3)
                {
                    view.DialogResult = DialogResult.Abort;
                    view.Close();
                }
            }
            else
            {
                view.global = glob;
                view.DialogResult = DialogResult.OK;
                view.Close();
            }
        }
    }
}
