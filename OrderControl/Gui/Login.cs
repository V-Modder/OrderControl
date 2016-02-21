using OrderControl.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderControl.Gui
{
    public partial class Login : Form
    {
        private LoginViewModel viewModel;

        public Login()
        {
            InitializeComponent();
            viewModel = new LoginViewModel(this);
            txt_user.DataBindings.Add("Text", viewModel, "Username");
            txt_password.DataBindings.Add("Text", viewModel, "Password");
            btn_login.Click += (s, e) => { viewModel.Login(s, e); };
        }

        public bool AllEnabled
        {
            get { return txt_password.Enabled & txt_user.Enabled & btn_login.Enabled; }
            set { txt_password.Enabled = txt_user.Enabled = btn_login.Enabled = value; }
        }

        public Global global
        {
            get;
            set;
        }
    }
}
