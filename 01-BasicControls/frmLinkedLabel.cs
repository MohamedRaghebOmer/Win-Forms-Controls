using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Practice
{
    public partial class frmLinkedLabel : Form
    {
        public frmLinkedLabel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://programmingadvices.com/");
        }

        private void frmLinkedLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
