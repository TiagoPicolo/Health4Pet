namespace Health4Pet
{
    partial class F_gestaoAnimal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeAnimal = new System.Windows.Forms.TextBox();
            this.mtb_dataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_dataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.n_idade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_raca = new System.Windows.Forms.TextBox();
            this.tb_especie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_porte = new System.Windows.Forms.ComboBox();
            this.cb_castrado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_observacoes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_dono = new System.Windows.Forms.ComboBox();
            this.dgv_animais = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_idade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(219)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 29);
            this.panel1.TabIndex = 1;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(426, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(101, 23);
            this.btn_fechar.TabIndex = 49;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(226, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(101, 23);
            this.btn_excluir.TabIndex = 48;
            this.btn_excluir.Text = "Excluir Animal";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(119, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(101, 23);
            this.btn_salvar.TabIndex = 47;
            this.btn_salvar.Text = "Salvar Animal";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(101, 23);
            this.btn_novo.TabIndex = 46;
            this.btn_novo.Text = "Novo Animal";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(219)))), ((int)(((byte)(161)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 39);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(165, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "GESTÃO DE ANIMAIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome Completo";
            // 
            // tb_nomeAnimal
            // 
            this.tb_nomeAnimal.Location = new System.Drawing.Point(107, 58);
            this.tb_nomeAnimal.Name = "tb_nomeAnimal";
            this.tb_nomeAnimal.Size = new System.Drawing.Size(322, 20);
            this.tb_nomeAnimal.TabIndex = 1;
            // 
            // mtb_dataCadastro
            // 
            this.mtb_dataCadastro.Location = new System.Drawing.Point(435, 58);
            this.mtb_dataCadastro.Mask = "00/00/0000";
            this.mtb_dataCadastro.Name = "mtb_dataCadastro";
            this.mtb_dataCadastro.Size = new System.Drawing.Size(92, 20);
            this.mtb_dataCadastro.TabIndex = 2;
            this.mtb_dataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_dataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Data Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Data Nascimento";
            // 
            // mtb_dataNascimento
            // 
            this.mtb_dataNascimento.Location = new System.Drawing.Point(15, 97);
            this.mtb_dataNascimento.Mask = "00/00/0000";
            this.mtb_dataNascimento.Name = "mtb_dataNascimento";
            this.mtb_dataNascimento.Size = new System.Drawing.Size(86, 20);
            this.mtb_dataNascimento.TabIndex = 3;
            this.mtb_dataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_dataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // n_idade
            // 
            this.n_idade.Location = new System.Drawing.Point(107, 98);
            this.n_idade.Name = "n_idade";
            this.n_idade.Size = new System.Drawing.Size(41, 20);
            this.n_idade.TabIndex = 4;
            this.n_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Raça/ Nome Comum";
            // 
            // tb_raca
            // 
            this.tb_raca.Location = new System.Drawing.Point(154, 98);
            this.tb_raca.Name = "tb_raca";
            this.tb_raca.Size = new System.Drawing.Size(275, 20);
            this.tb_raca.TabIndex = 5;
            // 
            // tb_especie
            // 
            this.tb_especie.Location = new System.Drawing.Point(435, 97);
            this.tb_especie.Name = "tb_especie";
            this.tb_especie.Size = new System.Drawing.Size(92, 20);
            this.tb_especie.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(432, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Especie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Porte";
            // 
            // cb_porte
            // 
            this.cb_porte.FormattingEnabled = true;
            this.cb_porte.Items.AddRange(new object[] {
            "Pequeno",
            "Medio",
            "Grande"});
            this.cb_porte.Location = new System.Drawing.Point(15, 136);
            this.cb_porte.Name = "cb_porte";
            this.cb_porte.Size = new System.Drawing.Size(86, 21);
            this.cb_porte.TabIndex = 7;
            // 
            // cb_castrado
            // 
            this.cb_castrado.FormattingEnabled = true;
            this.cb_castrado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_castrado.Location = new System.Drawing.Point(107, 136);
            this.cb_castrado.Name = "cb_castrado";
            this.cb_castrado.Size = new System.Drawing.Size(85, 21);
            this.cb_castrado.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Castrado";
            // 
            // tb_observacoes
            // 
            this.tb_observacoes.Location = new System.Drawing.Point(12, 216);
            this.tb_observacoes.Multiline = true;
            this.tb_observacoes.Name = "tb_observacoes";
            this.tb_observacoes.Size = new System.Drawing.Size(180, 116);
            this.tb_observacoes.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Observações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Sexo";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Macho",
            "Femêa"});
            this.cb_sexo.Location = new System.Drawing.Point(15, 176);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(85, 21);
            this.cb_sexo.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(106, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Dono(a)";
            // 
            // cb_dono
            // 
            this.cb_dono.FormattingEnabled = true;
            this.cb_dono.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_dono.Location = new System.Drawing.Point(107, 176);
            this.cb_dono.Name = "cb_dono";
            this.cb_dono.Size = new System.Drawing.Size(85, 21);
            this.cb_dono.TabIndex = 10;
            // 
            // dgv_animais
            // 
            this.dgv_animais.AllowUserToAddRows = false;
            this.dgv_animais.AllowUserToDeleteRows = false;
            this.dgv_animais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_animais.Location = new System.Drawing.Point(198, 124);
            this.dgv_animais.MultiSelect = false;
            this.dgv_animais.Name = "dgv_animais";
            this.dgv_animais.ReadOnly = true;
            this.dgv_animais.RowHeadersVisible = false;
            this.dgv_animais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_animais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_animais.Size = new System.Drawing.Size(329, 208);
            this.dgv_animais.TabIndex = 53;
            this.dgv_animais.SelectionChanged += new System.EventHandler(this.dgv_animais_SelectionChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "ID Animal";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(15, 58);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(86, 20);
            this.tb_id.TabIndex = 55;
            // 
            // F_gestaoAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(540, 367);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgv_animais);
            this.Controls.Add(this.cb_dono);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_observacoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_castrado);
            this.Controls.Add(this.cb_porte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_especie);
            this.Controls.Add(this.tb_raca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_idade);
            this.Controls.Add(this.mtb_dataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_dataCadastro);
            this.Controls.Add(this.tb_nomeAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_gestaoAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_gestaoAnimal";
            this.Load += new System.EventHandler(this.F_gestaoAnimal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_idade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeAnimal;
        private System.Windows.Forms.MaskedTextBox mtb_dataCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_dataNascimento;
        private System.Windows.Forms.NumericUpDown n_idade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_raca;
        private System.Windows.Forms.TextBox tb_especie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_porte;
        private System.Windows.Forms.ComboBox cb_castrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_observacoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_dono;
        private System.Windows.Forms.DataGridView dgv_animais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_id;
    }
}