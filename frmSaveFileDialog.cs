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
    public partial class frmSaveFileDialog : Form
    {
        public frmSaveFileDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowHelp = false;
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save my-file.txt";
            saveFileDialog1.DefaultExt = "txt"; // default extintion
            
            //                        user will see....|real.|user will see..|real    
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            saveFileDialog1.FilterIndex = 2;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File saved");
            }
        }

        private void frmSaveFileDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
