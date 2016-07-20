using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Query;

namespace project
{
    public partial class formControl : Form
    {
        public Form frm;

        private string ip, pass;
        private int port;

        private sQuery TCPr;
        private RCONQuery TCPs;

        public formControl()
        {
            InitializeComponent();
        }

        public formControl(Form frm, string ip, int port, string pass, RCONQuery TCPs, sQuery TCPr)
        {
            this.frm = frm;
            
            InitializeComponent();

            this.ip = ip;
            this.pass = pass;
            this.port = port;

            this.TCPr = TCPr;
            this.TCPs = TCPs;
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnviar enviar = new frmEnviar(ip, port, pass, TCPs, TCPr);
            enviar.MdiParent = this;
            enviar.Show();
        }

        private void formControl_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                
                notifyIcon1.Visible = true;
            }
        }

        private void formControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Close();
        }            

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            { 
                return;
            }

            toolStripMenuItem2_Click(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2_Click(sender, e);
            jogadoresToolStripMenuItem_Click(sender, e); 
        }
    }
}
