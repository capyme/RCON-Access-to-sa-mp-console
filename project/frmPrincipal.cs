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
    public partial class frmPrincipal : Form
    {
        string ip, port, pass;

        public frmPrincipal()
        {
            InitializeComponent();

            txbIpPorta.ForeColor = Color.Gray;
            txbPass.ForeColor = Color.Gray;
        }

        private void Senha(object sender, EventArgs e)
        {
            txbPass.Text = null;
            txbPass.PasswordChar = '*';
            txbPass.ForeColor = Color.Black;
        }

        private void IpPorta(object sender, EventArgs e)
        {
            txbIpPorta.Text = null;
            txbIpPorta.ForeColor = Color.Black;
        }

        private void Limpar(object sender, EventArgs e)
        {
            txbIpPorta.Text = "                      127.0.0.1:7777";
            txbPass.PasswordChar = '\0';
            txbPass.Text = "                     SenhaRcon123";
            txbIpPorta.ForeColor = Color.Gray;
            txbPass.ForeColor = Color.Gray;
        }
        
        private void Digitando_ipPorta(object sender, EventArgs e)
        {
            if (!txbIpPorta.Text.Contains(":")) ip = txbIpPorta.Text;
            else port = txbIpPorta.Text.Substring(txbIpPorta.Text.IndexOf(":") + 1);
        }

        private void Digitando_pass(object sender, EventArgs e)
        {
            pass = txbPass.Text;
        }

        private void HELP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                new about().ShowDialog();
            }
        }

        private void HELP(object sender, EventArgs e)
        {
            new about().ShowDialog();
        }

        private void Confirmar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show("Você precisa informar os dados do servidor.");
                return;
            }

            sQuery TCPr = new sQuery(ip, int.Parse(port));
            TCPr.Send('p');
            int c = TCPr.Recieve();
            string[] i = TCPr.Store(c);

            if (c == 0)
            {
                MessageBox.Show("Servidor desligado.");
                return;
            }

            RCONQuery TCPs = new RCONQuery(ip, int.Parse(port), pass);
            TCPs.Send("echo Connecting...");
            c = TCPs.Recieve();
            i = TCPs.Store(c);

            foreach (string g in i)
            {
                if (!string.IsNullOrEmpty(g) && g.Contains("RCON"))
                {
                    MessageBox.Show(g);
                    return;
                }
            }

            this.Hide();

            new formControl(this, ip, int.Parse(port), pass, TCPs, TCPr).Show();
        }
    }
}
