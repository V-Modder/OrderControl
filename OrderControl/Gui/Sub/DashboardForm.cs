using OrderControl.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderControl.Gui.Sub
{
    public partial class DashboardForm : ClientForm
    {
        private DashboardViewModel viewModel;

        public DashboardForm(Global global)
        {
            InitializeComponent();
            viewModel = new DashboardViewModel(global);
            lbl_newOrderValue.DataBindings.Add("Text", viewModel, "NewOrderCount");
            lbl_orderValue.DataBindings.Add("Text", viewModel, "Order");
            lbl_articleValue.DataBindings.Add("Text", viewModel, "Article");
            lbl_articleWrongValue.DataBindings.Add("Text", viewModel, "WorngArticle");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            viewModel.LoadData();
        }

        public override void ActionPerformed(object sender, EventArgs e)
        {
            string name;
            if (sender is Control)
            {
                Control btn = (Control)sender;
                name = (String)btn.Tag;
            }
            else if (sender is Component)
            {
                RibbonItem btn = (RibbonItem)sender;
                name = (String)btn.Tag;
            }
            else
            {
                return;
            }
            switch (name)
            {
                case "RefreshButton":
                    viewModel.LoadData();
                    break;
                case "lbl_newOrderValue":

                    break;
                case "lbl_orderValue":
                    break;
                case "lbl_articleValue":
                    break;
                case "lbl_articleWrongValue":
                    break;
            }
        }
    }
}
