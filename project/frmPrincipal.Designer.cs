namespace project
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbIpPorta = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceber
            // 
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceber.Location = new System.Drawing.Point(57, 106);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(80, 49);
            this.btnReceber.TabIndex = 0;
            this.btnReceber.Text = "Confirmar";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.Confirmar);
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(143, 106);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 49);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Limpar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.Limpar);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.txbPass);
            this.gb.Controls.Add(this.txbIpPorta);
            this.gb.Controls.Add(this.btnEnviar);
            this.gb.Controls.Add(this.btnReceber);
            this.gb.Location = new System.Drawing.Point(12, 27);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(282, 158);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe a senha(RCON):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o IP e a porta:";
            // 
            // txbPass
            // 
            this.txbPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbPass.Location = new System.Drawing.Point(37, 70);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(206, 20);
            this.txbPass.TabIndex = 3;
            this.txbPass.TabStop = false;
            this.txbPass.Text = "                     SenhaRcon123";
            this.txbPass.Click += new System.EventHandler(this.Senha);
            this.txbPass.TextChanged += new System.EventHandler(this.Digitando_pass);
            // 
            // txbIpPorta
            // 
            this.txbIpPorta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbIpPorta.Location = new System.Drawing.Point(37, 26);
            this.txbIpPorta.Name = "txbIpPorta";
            this.txbIpPorta.Size = new System.Drawing.Size(206, 20);
            this.txbIpPorta.TabIndex = 2;
            this.txbIpPorta.TabStop = false;
            this.txbIpPorta.Text = "                      127.0.0.1:7777";
            this.txbIpPorta.Click += new System.EventHandler(this.IpPorta);
            this.txbIpPorta.TextChanged += new System.EventHandler(this.Digitando_ipPorta);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(306, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.aboutToolStripMenuItem.Text = "Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.HELP);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 197);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA-MP RCON Manager";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HELP);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox txbIpPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}