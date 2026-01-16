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
    public partial class frmMinueStrip : Form
    {
        public frmMinueStrip()
        {
            InitializeComponent();
        }

        private void findClinetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add new Client is here!");
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Client is here");
        }

        private void updateClinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Client is here");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the login menu!");
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Exist Menu");
        }

        private void findByAccountNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is find by account number in find menu");
        }

        private void findByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is find by name in find menu");
        }
    }
}
