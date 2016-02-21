using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderControl.Common;
using OrderControl.Gui.Sub;

namespace OrderControl.Gui
{
    public partial class OrderControl : RibbonForm
    {
        Form currentForm;
        Global global;
        

        public OrderControl()
        {
            InitializeComponent();
        }

        public void dummyAppButtonClick(object sender, EventArgs e)
        {
            // Get the system menu of this application
            IntPtr wMenu = WinApi.GetSystemMenu(this.Handle, false);

            // Display the menu
            uint command = WinApi.TrackPopupMenuEx(wMenu, WinApi.TPM_LEFTBUTTON | WinApi.TPM_RETURNCMD,
                 this.PointToScreen(mainRibbon.Bounds.Location).X, this.PointToScreen(mainRibbon.Bounds.Location).Y + mainRibbon.CaptionBarSize, this.Handle, IntPtr.Zero);

            if (command == 0)
                return;

            // Post a message for the menu selection
            WinApi.PostMessage(this.Handle, WinApi.WM_SYSCOMMAND, new UIntPtr(command), IntPtr.Zero);
        }

        public void dummyAppButtonDoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            ClientForm form = (ClientForm)this.MdiChildren[0];
            form.ActionPerformed(sender, e);
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult res = login.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.global = login.global;
                currentForm = new DashboardForm(this.global);
                currentForm.MdiParent = this;
                currentForm.Show();
                currentForm.WindowState = FormWindowState.Minimized;
                currentForm.WindowState = FormWindowState.Maximized;
                currentForm.Validate();
            }
            else if (res == DialogResult.Abort)
            {
                MessageBox.Show("Maximale Anzahl von Loginversuchen erreicht!"); 
                this.Close();
            }            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DashboardForm frm = (DashboardForm)this.MdiChildren[0];
            frm.Refresh();
        }
    }
}
