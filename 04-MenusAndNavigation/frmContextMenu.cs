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
    public partial class frmContextMenu : Form
    {
        public frmContextMenu()
        {
            InitializeComponent();
        }

        private void findByAccountNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateClinetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void tsmChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void tsmChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }

        }
    }
}
