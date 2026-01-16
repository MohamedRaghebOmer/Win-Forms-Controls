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
    public partial class frmCombo_Box : Form
    {
        public frmCombo_Box()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ali");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void frmCombo_Box_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; // first item
        }

        private void btnHomwork_Click(object sender, EventArgs e)
        {
            frmHomwork frm = new frmHomwork();
            frm.ShowDialog();
        }
    }
}
