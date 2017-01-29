﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitForm
{
    public partial class frmWaitForm : Form
    {
        public Action Worker { get; set; }
        public frmWaitForm(Action Worker)
        {
            InitializeComponent();
            if (Worker == null)
                throw new ArgumentNullException();
            this.Worker = Worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
