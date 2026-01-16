using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // You must include this to work
namespace Course_Practice
{
    public partial class frmProgressPar : Form
    {
        public frmProgressPar()
        {
            InitializeComponent();
        }

        private void btnIncreesProgressPar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                    lblProgress.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                    progressBar1.Refresh();
                    lblProgress.Refresh();
                }
                else
                {
                    btnIncreesProgressPar.Enabled = false;
                }
            }
        }

        private void btnRestProgressPar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblProgress.Text = "0%";
        }
    }
}
