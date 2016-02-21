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
    public enum OrderSort { All, Exeeded, OpenPosition, Open, Done, Delivered }

    public partial class OrderForm : ClientForm
    {
        private OrderSort ordersort;
        private Global global;
        private OrderViewModel viewModel;

        public OrderForm(Global global) : this(global, OrderSort.All)
        {
            this.global = global;
            viewModel = new OrderViewModel(global);
        }

        public OrderForm(Global global, OrderSort sort)
        {
            InitializeComponent();
            this.ordersort = sort;
            this.global = global;
        }
    }
}
