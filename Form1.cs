using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void SaveData()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(frmWaitForm frm = new frmWaitForm(SaveData))
            {
                frm.ShowDialog(this);
            }
        }
    }
}
