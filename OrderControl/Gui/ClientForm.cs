﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderControl.Gui
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Needs to be overwritten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void ActionPerformed(object sender, EventArgs e)
        {
        }
    }
}
