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
    public partial class frmOpenFileDialog : Form
    {
        public frmOpenFileDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowHelp = false;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Save my-file.txt";
            openFileDialog1.DefaultExt = "txt"; // default extintion

            //                        user will see....|real.|user will see..|real    
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(String file in openFileDialog1.FileNames)
                {
                    MessageBox.Show(file);
                }
            }
        }
    }
}
