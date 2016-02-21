using OrderControl.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderControl.Gui
{
    class LoginController
    {
        public delegate void ColsingHandler(object sender, EventArgs e);
        public event ColsingHandler OnClosing;


        public Global Login(string userName, string password)
        {
            Global g = new Global();

            if (g.Login(userName, password))
            {
                return g;
            }
            else
            {
                return null;
            }
        }
    }
}
