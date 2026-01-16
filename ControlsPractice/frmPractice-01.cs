using Course_Practice.Properties;
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
    public partial class frmHomwork : Form
    {
        public frmHomwork()
        {
            InitializeComponent();
        }

        private void cmbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChoose.Text == "Boy")
            {
                lblHeader.Text = "Boy";
                pbPicture.Image = Resources.Boy;
            }
            else if (cmbChoose.Text == "Girl")
            {
                lblHeader.Text = "Girl";
                pbPicture.Image = Resources.Girl;
            }
            else if (cmbChoose.Text == "Pen")
            {
                lblHeader.Text = "Pen";
                pbPicture.Image = Resources.Pen;
            }
            else
            {
                lblHeader.Text = "Book";
                pbPicture.Image = Resources.Book;
            }
            

        }

        private void frmHomwork_Load(object sender, EventArgs e)
        {
            cmbChoose.SelectedIndex = 0;
        }
    }
}
