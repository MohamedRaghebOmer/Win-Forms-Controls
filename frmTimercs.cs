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
    public partial class frmTimercs : Form
    {
        public frmTimercs()
        {
            InitializeComponent();
        }

        private int Counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            lblTimer.Text = Counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
