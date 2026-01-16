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
    public partial class frmPractice : Form
    {
        public frmPractice()
        {
            InitializeComponent();
        }

        private void ComboBox_Click(object sender, EventArgs e)
        {
            frmCombo_Box frm = new frmCombo_Box();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLinkedLabel frm = new frmLinkedLabel();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDateTimePicker frm = new frmDateTimePicker();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMonthCalandar frm = new frmMonthCalandar();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTimercs frm = new frmTimercs();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNotifyIcon frm = new frmNotifyIcon();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTreeViewcs frm = new frmTreeViewcs();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmProgressPar frm = new frmProgressPar();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmListView frm = new frmListView();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmErrorProvider frm = new frmErrorProvider();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmTrackBar frm = new frmTrackBar();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmNumericUpDown frm = new frmNumericUpDown();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmTabControl frm = new frmTabControl();
            frm.ShowDialog();
        }

        private void frmPractice_Load(object sender, EventArgs e)
        {
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmPanel frm = new frmPanel();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmColorDialog frm = new frmColorDialog();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmFontDialog frm = new frmFontDialog();
            frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmSaveFileDialog frm = new frmSaveFileDialog();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmOpenFileDialog frm = new frmOpenFileDialog();
            frm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmOpenFolerDialog frm = new frmOpenFolerDialog();
            frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmMDIContainer frm = new frmMDIContainer();
            frm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmMinueStrip frm = new frmMinueStrip();
            frm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmContextMenu frm = new frmContextMenu();
            frm.ShowDialog();
        }
    }
}
