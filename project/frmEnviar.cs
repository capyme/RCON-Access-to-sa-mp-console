using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using Query;
using project.Players;

namespace project
{
    public partial class frmEnviar : Form
    {
        private string ip, pass;
        private int port;

        private sQuery TCPr;
        private RCONQuery TCPs;

        private int Id = -1;
        private string Nome;

        public frmEnviar()
        {
            InitializeComponent();
        }

        public frmEnviar(string ip, int port, string pass, RCONQuery TCPs, sQuery TCPr)
        {
            InitializeComponent();

            this.ip = ip;
            this.pass = pass;
            this.port = port;

            this.TCPr = TCPr;
            this.TCPs = TCPs;
        }

        void jogadores_online()
        {
            dgvPlayer.Rows.Clear();

            TCPr.Send('d');
            int count = TCPr.Recieve();
            string[] info = TCPr.Store(count);

            if (count == 0) return;

            for (int i = 0; i < info.Length; i+=4)
            {
                dgvPlayer.Rows.Add(info[i], info[i+1], info[i+2], info[i+3]);
            }
        }

        private void frmEnviar_Load(object sender, EventArgs e)
        {
            PlayersFlags.TCPr = TCPr;
            PlayersFlags.TCPs = TCPs;

            jogadores_online();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jogadores_online();
        }

        private void btnPessoal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPessoal.Text))
            {
                return;
            }
            PlayersFlags.SendClientMessage(Id, txbPessoal.Text);
        }

        private void alterando_vida(object sender, EventArgs e)
        {
            lblVida.Text = string.Format("Vida: {0}", tbVida.Value * 10);
        }

        private void btnAltVida_Click(object sender, EventArgs e)
        {
            PlayersFlags.SetPlayerHealth(Id, tbVida.Value * 10);
        }

        private void alterando_colete(object sender, EventArgs e)
        {
            lblArmour.Text = string.Format("Colete: {0}", tbArm.Value * 10);
        }

        private void btnAltArm_Click(object sender, EventArgs e)
        {
            PlayersFlags.SetPlayerArmour(Id, tbArm.Value * 10);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Id == int.Parse(dgvPlayer.SelectedCells[0].Value.ToString())) return;

            Id = int.Parse(dgvPlayer.SelectedCells[0].Value.ToString());
            Nome = dgvPlayer.SelectedCells[1].Value.ToString();

            MessageBox.Show(string.Format("Você selecionou: {0}", Nome));

            gbAcoes.Visible = true;
            gbAcoes.Text = "Ações - " + Nome;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            PlayersFlags.CreateVehicle(Id, int.Parse(txbCar.Text));
        }

        private void btnCarD_Click(object sender, EventArgs e)
        {
            PlayersFlags.DestroyVehicle(Id);
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            PlayersFlags.Kick(Id);
        }
    }
}
