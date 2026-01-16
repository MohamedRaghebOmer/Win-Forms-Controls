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
    public partial class frmMDIContainer : Form
    {
        public frmMDIContainer()
        {
            InitializeComponent();
        }

        ContainerInFrmMDIContainer frm = new ContainerInFrmMDIContainer();
        private void button1_Click(object sender, EventArgs e)
        {
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
