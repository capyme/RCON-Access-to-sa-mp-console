namespace project
{
    partial class frmEnviar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbVisu = new System.Windows.Forms.GroupBox();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.pId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.gbComu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPessoal = new System.Windows.Forms.Button();
            this.txbPessoal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKick = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCar = new System.Windows.Forms.TextBox();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnCarD = new System.Windows.Forms.Button();
            this.btnAltArm = new System.Windows.Forms.Button();
            this.tbArm = new System.Windows.Forms.TrackBar();
            this.lblArmour = new System.Windows.Forms.Label();
            this.btnAltVida = new System.Windows.Forms.Button();
            this.tbVida = new System.Windows.Forms.TrackBar();
            this.lblVida = new System.Windows.Forms.Label();
            this.gbVisu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.gbAcoes.SuspendLayout();
            this.gbComu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVida)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbVisu
            // 
            this.gbVisu.Controls.Add(this.dgvPlayer);
            this.gbVisu.Location = new System.Drawing.Point(6, 2);
            this.gbVisu.Name = "gbVisu";
            this.gbVisu.Size = new System.Drawing.Size(233, 395);
            this.gbVisu.TabIndex = 1;
            this.gbVisu.TabStop = false;
            this.gbVisu.Text = "Visualizador";
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToAddRows = false;
            this.dgvPlayer.AllowUserToDeleteRows = false;
            this.dgvPlayer.AllowUserToResizeColumns = false;
            this.dgvPlayer.AllowUserToResizeRows = false;
            this.dgvPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlayer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pId,
            this.pName,
            this.pScore,
            this.pPing});
            this.dgvPlayer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dgvPlayer.EnableHeadersVisualStyles = false;
            this.dgvPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPlayer.Location = new System.Drawing.Point(5, 14);
            this.dgvPlayer.MultiSelect = false;
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersVisible = false;
            this.dgvPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayer.Size = new System.Drawing.Size(221, 375);
            this.dgvPlayer.TabIndex = 3;
            this.dgvPlayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pId
            // 
            this.pId.HeaderText = "Id";
            this.pId.Name = "pId";
            this.pId.ReadOnly = true;
            this.pId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pId.Width = 40;
            // 
            // pName
            // 
            this.pName.HeaderText = "Nome";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            // 
            // pScore
            // 
            this.pScore.HeaderText = "Score";
            this.pScore.Name = "pScore";
            this.pScore.ReadOnly = true;
            this.pScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pScore.Width = 40;
            // 
            // pPing
            // 
            this.pPing.HeaderText = "Ping";
            this.pPing.Name = "pPing";
            this.pPing.ReadOnly = true;
            this.pPing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pPing.Width = 40;
            // 
            // gbAcoes
            // 
            this.gbAcoes.Controls.Add(this.gbComu);
            this.gbAcoes.Controls.Add(this.groupBox1);
            this.gbAcoes.Location = new System.Drawing.Point(241, 2);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(289, 395);
            this.gbAcoes.TabIndex = 2;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            this.gbAcoes.Visible = false;
            // 
            // gbComu
            // 
            this.gbComu.Controls.Add(this.label1);
            this.gbComu.Controls.Add(this.btnPessoal);
            this.gbComu.Controls.Add(this.txbPessoal);
            this.gbComu.Location = new System.Drawing.Point(12, 19);
            this.gbComu.Name = "gbComu";
            this.gbComu.Size = new System.Drawing.Size(265, 77);
            this.gbComu.TabIndex = 3;
            this.gbComu.TabStop = false;
            this.gbComu.Text = "Comunicação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem pessoal:";
            // 
            // btnPessoal
            // 
            this.btnPessoal.Location = new System.Drawing.Point(178, 36);
            this.btnPessoal.Name = "btnPessoal";
            this.btnPessoal.Size = new System.Drawing.Size(75, 23);
            this.btnPessoal.TabIndex = 2;
            this.btnPessoal.Text = "Enviar";
            this.btnPessoal.UseVisualStyleBackColor = true;
            this.btnPessoal.Click += new System.EventHandler(this.btnPessoal_Click);
            // 
            // txbPessoal
            // 
            this.txbPessoal.Location = new System.Drawing.Point(11, 38);
            this.txbPessoal.Name = "txbPessoal";
            this.txbPessoal.Size = new System.Drawing.Size(161, 20);
            this.txbPessoal.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAltArm);
            this.groupBox1.Controls.Add(this.tbArm);
            this.groupBox1.Controls.Add(this.lblArmour);
            this.groupBox1.Controls.Add(this.btnAltVida);
            this.groupBox1.Controls.Add(this.tbVida);
            this.groupBox1.Controls.Add(this.lblVida);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interações";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKick);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(7, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 49);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // btnKick
            // 
            this.btnKick.Location = new System.Drawing.Point(46, 16);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(63, 23);
            this.btnKick.TabIndex = 6;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ban";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbCar);
            this.groupBox2.Controls.Add(this.btnCar);
            this.groupBox2.Controls.Add(this.btnCarD);
            this.groupBox2.Location = new System.Drawing.Point(7, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id:";
            // 
            // txbCar
            // 
            this.txbCar.Location = new System.Drawing.Point(32, 18);
            this.txbCar.Name = "txbCar";
            this.txbCar.Size = new System.Drawing.Size(47, 20);
            this.txbCar.TabIndex = 8;
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(85, 16);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(75, 23);
            this.btnCar.TabIndex = 6;
            this.btnCar.Text = "Criar Carro";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnCarD
            // 
            this.btnCarD.Location = new System.Drawing.Point(167, 16);
            this.btnCarD.Name = "btnCarD";
            this.btnCarD.Size = new System.Drawing.Size(75, 23);
            this.btnCarD.TabIndex = 6;
            this.btnCarD.Text = "Destruir";
            this.btnCarD.UseVisualStyleBackColor = true;
            this.btnCarD.Click += new System.EventHandler(this.btnCarD_Click);
            // 
            // btnAltArm
            // 
            this.btnAltArm.Location = new System.Drawing.Point(178, 88);
            this.btnAltArm.Name = "btnAltArm";
            this.btnAltArm.Size = new System.Drawing.Size(75, 23);
            this.btnAltArm.TabIndex = 5;
            this.btnAltArm.Text = "Alterar";
            this.btnAltArm.UseVisualStyleBackColor = true;
            this.btnAltArm.Click += new System.EventHandler(this.btnAltArm_Click);
            // 
            // tbArm
            // 
            this.tbArm.Location = new System.Drawing.Point(11, 86);
            this.tbArm.Name = "tbArm";
            this.tbArm.Size = new System.Drawing.Size(161, 45);
            this.tbArm.TabIndex = 4;
            this.tbArm.TabStop = false;
            this.tbArm.Scroll += new System.EventHandler(this.alterando_colete);
            // 
            // lblArmour
            // 
            this.lblArmour.AutoSize = true;
            this.lblArmour.Location = new System.Drawing.Point(32, 74);
            this.lblArmour.Name = "lblArmour";
            this.lblArmour.Size = new System.Drawing.Size(40, 13);
            this.lblArmour.TabIndex = 3;
            this.lblArmour.Text = "Colete:";
            // 
            // btnAltVida
            // 
            this.btnAltVida.Location = new System.Drawing.Point(178, 37);
            this.btnAltVida.Name = "btnAltVida";
            this.btnAltVida.Size = new System.Drawing.Size(75, 23);
            this.btnAltVida.TabIndex = 2;
            this.btnAltVida.Text = "Alterar";
            this.btnAltVida.UseVisualStyleBackColor = true;
            this.btnAltVida.Click += new System.EventHandler(this.btnAltVida_Click);
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(11, 35);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(161, 45);
            this.tbVida.TabIndex = 1;
            this.tbVida.TabStop = false;
            this.tbVida.Scroll += new System.EventHandler(this.alterando_vida);
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(32, 23);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(31, 13);
            this.lblVida.TabIndex = 0;
            this.lblVida.Text = "Vida:";
            // 
            // frmEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 400);
            this.Controls.Add(this.gbVisu);
            this.Controls.Add(this.gbAcoes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(553, 438);
            this.MinimumSize = new System.Drawing.Size(553, 438);
            this.Name = "frmEnviar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Jogadores Online";
            this.Load += new System.EventHandler(this.frmEnviar_Load);
            this.gbVisu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.gbAcoes.ResumeLayout(false);
            this.gbComu.ResumeLayout(false);
            this.gbComu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbVisu;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.GroupBox gbComu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPessoal;
        private System.Windows.Forms.TextBox txbPessoal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltVida;
        private System.Windows.Forms.TrackBar tbVida;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Button btnAltArm;
        private System.Windows.Forms.Label lblArmour;
        private System.Windows.Forms.TrackBar tbArm;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn pId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPing;
        private System.Windows.Forms.Button btnCarD;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.Button button2;
    }
}

