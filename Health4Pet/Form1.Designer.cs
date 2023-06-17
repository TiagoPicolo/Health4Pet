namespace Health4Pet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_menuStrip = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroDeAnimaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAnimaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProntuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUTENCAOtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ms_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_menuStrip
            // 
            this.ms_menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(219)))), ((int)(((byte)(161)))));
            this.ms_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.cADASTROSToolStripMenuItem,
            this.cONSULTASToolStripMenuItem,
            this.mANUTENCAOtoolStripMenuItem1});
            this.ms_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.ms_menuStrip.Margin = new System.Windows.Forms.Padding(10);
            this.ms_menuStrip.Name = "ms_menuStrip";
            this.ms_menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.ms_menuStrip.TabIndex = 0;
            this.ms_menuStrip.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.lOGINToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.entrarToolStripMenuItem.Text = "Entrar";
            this.entrarToolStripMenuItem.Click += new System.EventHandler(this.entrarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem1});
            this.cADASTROSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.cADASTROSToolStripMenuItem.Text = "AREA DO CLIENTE";
            // 
            // cADASTROSToolStripMenuItem1
            // 
            this.cADASTROSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem1,
            this.gestãoDeClientesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cadastroDeAnimaisToolStripMenuItem,
            this.gestãoDeAnimaisToolStripMenuItem});
            this.cADASTROSToolStripMenuItem1.Name = "cADASTROSToolStripMenuItem1";
            this.cADASTROSToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.cADASTROSToolStripMenuItem1.Text = "CADASTROS";
            // 
            // cadastroDeClientesToolStripMenuItem1
            // 
            this.cadastroDeClientesToolStripMenuItem1.Name = "cadastroDeClientesToolStripMenuItem1";
            this.cadastroDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.cadastroDeClientesToolStripMenuItem1.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem1_Click);
            // 
            // gestãoDeClientesToolStripMenuItem
            // 
            this.gestãoDeClientesToolStripMenuItem.Name = "gestãoDeClientesToolStripMenuItem";
            this.gestãoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestãoDeClientesToolStripMenuItem.Text = "Gestão de Clientes";
            this.gestãoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // cadastroDeAnimaisToolStripMenuItem
            // 
            this.cadastroDeAnimaisToolStripMenuItem.Name = "cadastroDeAnimaisToolStripMenuItem";
            this.cadastroDeAnimaisToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cadastroDeAnimaisToolStripMenuItem.Text = "Cadastro de Animais";
            this.cadastroDeAnimaisToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAnimaisToolStripMenuItem_Click);
            // 
            // gestãoDeAnimaisToolStripMenuItem
            // 
            this.gestãoDeAnimaisToolStripMenuItem.Name = "gestãoDeAnimaisToolStripMenuItem";
            this.gestãoDeAnimaisToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestãoDeAnimaisToolStripMenuItem.Text = "Gestão de Animais";
            this.gestãoDeAnimaisToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeAnimaisToolStripMenuItem_Click);
            // 
            // cONSULTASToolStripMenuItem
            // 
            this.cONSULTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaProntuarioToolStripMenuItem,
            this.prontuarioToolStripMenuItem});
            this.cONSULTASToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            this.cONSULTASToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // consultaProntuarioToolStripMenuItem
            // 
            this.consultaProntuarioToolStripMenuItem.Name = "consultaProntuarioToolStripMenuItem";
            this.consultaProntuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaProntuarioToolStripMenuItem.Text = "Consulta Prontuario";
            this.consultaProntuarioToolStripMenuItem.Click += new System.EventHandler(this.consultaProntuarioToolStripMenuItem_Click);
            // 
            // prontuarioToolStripMenuItem
            // 
            this.prontuarioToolStripMenuItem.Name = "prontuarioToolStripMenuItem";
            this.prontuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prontuarioToolStripMenuItem.Text = "Prontuario ";
            this.prontuarioToolStripMenuItem.Click += new System.EventHandler(this.prontuarioToolStripMenuItem_Click);
            // 
            // mANUTENCAOtoolStripMenuItem1
            // 
            this.mANUTENCAOtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroUsuarioToolStripMenuItem,
            this.gestãoDeUsuariosToolStripMenuItem});
            this.mANUTENCAOtoolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mANUTENCAOtoolStripMenuItem1.Name = "mANUTENCAOtoolStripMenuItem1";
            this.mANUTENCAOtoolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.mANUTENCAOtoolStripMenuItem1.Text = "MANUTENÇÃO";
            // 
            // cadastroUsuarioToolStripMenuItem
            // 
            this.cadastroUsuarioToolStripMenuItem.Name = "cadastroUsuarioToolStripMenuItem";
            this.cadastroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroUsuarioToolStripMenuItem.Text = "Cadastro Usuario";
            this.cadastroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuarioToolStripMenuItem_Click);
            // 
            // gestãoDeUsuariosToolStripMenuItem
            // 
            this.gestãoDeUsuariosToolStripMenuItem.Name = "gestãoDeUsuariosToolStripMenuItem";
            this.gestãoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestãoDeUsuariosToolStripMenuItem.Text = "Gestão de Usuarios";
            this.gestãoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuariosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(219)))), ((int)(((byte)(161)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Health4Pet.Properties.Resources.osso_PNG_copy_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1000, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ms_menuStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ms_menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEALTH4PET";
            this.ms_menuStrip.ResumeLayout(false);
            this.ms_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProntuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mANUTENCAOtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAnimaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAnimaisToolStripMenuItem;
    }
}

