using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatanseverlerAnaliz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }

        void ShowForm(ref Form form)
        {
            Form f = form;
            Form tempform = null;
            foreach (Form child in this.MdiChildren)
            {
                if (child.Text == f.Text)
                {
                    tempform = child;
                    break;
                }

            }
            if (tempform != null)
            {
                tempform.BringToFront();

            }
            else
            {
                f.MdiParent = this;
                f.Show();
                TabPage tabPage = new TabPage();
                tabPage.Text = f.Text;
            }
        }
        private void MainForm_MdiChildActivate_1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }
        private void btnOyuncuekle_Click(object sender, EventArgs e)
        {
            Form oee = new FrmOyuncuekle();
            ShowForm(ref oee);
        }

        private void btnDevamsizlik_Click(object sender, EventArgs e)
        {
            Form devamsizlik = new FrmDevamsizlik();
            ShowForm(ref devamsizlik);
        }

        private void btnTakim_Click(object sender, EventArgs e)
        {
            Form takim = new FrmTakim();
            ShowForm(ref takim);
        }
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult kapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }
    }
}

