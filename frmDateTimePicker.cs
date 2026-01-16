using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Practice
{
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
            MessageBox.Show(dateTimePicker1.Value.ToLongTimeString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;

        }
    }
}
