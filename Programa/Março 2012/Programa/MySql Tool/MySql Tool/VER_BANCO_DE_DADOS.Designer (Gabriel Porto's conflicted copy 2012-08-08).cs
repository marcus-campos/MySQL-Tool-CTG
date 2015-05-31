namespace MySql_Tool
{
    partial class VER_BANCO_DE_DADOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VER_BANCO_DE_DADOS));
            this.dg_banco_de_dados_presentes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pgb_carregando = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_bancos_presentes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_mostra_senha = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_servidor = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_banco_de_dados_presentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_banco_de_dados_presentes
            // 
            this.dg_banco_de_dados_presentes.AllowUserToAddRows = false;
            this.dg_banco_de_dados_presentes.AllowUserToDeleteRows = false;
            this.dg_banco_de_dados_presentes.BackgroundColor = System.Drawing.Color.White;
            this.dg_banco_de_dados_presentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_banco_de_dados_presentes.Location = new System.Drawing.Point(6, 17);
            this.dg_banco_de_dados_presentes.Name = "dg_banco_de_dados_presentes";
            this.dg_banco_de_dados_presentes.ReadOnly = true;
            this.dg_banco_de_dados_presentes.Size = new System.Drawing.Size(217, 335);
            this.dg_banco_de_dados_presentes.TabIndex = 0;
            this.dg_banco_de_dados_presentes.SelectionChanged += new System.EventHandler(this.dg_banco_de_dados_presentes_SelectionChanged);
            this.dg_banco_de_dados_presentes.DoubleClick += new System.EventHandler(this.dg_banco_de_dados_presentes_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pgb_carregando);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banco de dados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pgb_carregando
            // 
            this.pgb_carregando.Location = new System.Drawing.Point(241, 367);
            this.pgb_carregando.Name = "pgb_carregando";
            this.pgb_carregando.Size = new System.Drawing.Size(253, 23);
            this.pgb_carregando.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_carregando.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_bancos_presentes);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dg_banco_de_dados_presentes);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 371);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Banco de dados presentes";
            // 
            // lb_bancos_presentes
            // 
            this.lb_bancos_presentes.AutoSize = true;
            this.lb_bancos_presentes.Location = new System.Drawing.Point(151, 355);
            this.lb_bancos_presentes.Name = "lb_bancos_presentes";
            this.lb_bancos_presentes.Size = new System.Drawing.Size(13, 13);
            this.lb_bancos_presentes.TabIndex = 2;
            this.lb_bancos_presentes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bancos de dados presentes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_mostra_senha);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tb_porta);
            this.groupBox2.Controls.Add(this.tb_usuario);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_servidor);
            this.groupBox2.Controls.Add(this.tb_senha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(241, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 187);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações";
            // 
            // ckb_mostra_senha
            // 
            this.ckb_mostra_senha.AutoSize = true;
            this.ckb_mostra_senha.Location = new System.Drawing.Point(154, 130);
            this.ckb_mostra_senha.Name = "ckb_mostra_senha";
            this.ckb_mostra_senha.Size = new System.Drawing.Size(93, 17);
            this.ckb_mostra_senha.TabIndex = 24;
            this.ckb_mostra_senha.Text = "Mostrar senha";
            this.ckb_mostra_senha.UseVisualStyleBackColor = true;
            this.ckb_mostra_senha.CheckedChanged += new System.EventHandler(this.ckb_mostra_senha_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(76, 52);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(167, 20);
            this.tb_porta.TabIndex = 15;
            this.tb_porta.Text = "3306";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(76, 78);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(167, 20);
            this.tb_usuario.TabIndex = 17;
            this.tb_usuario.Text = "root";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Senha";
            // 
            // tb_servidor
            // 
            this.tb_servidor.Location = new System.Drawing.Point(76, 26);
            this.tb_servidor.Name = "tb_servidor";
            this.tb_servidor.Size = new System.Drawing.Size(167, 20);
            this.tb_servidor.TabIndex = 14;
            this.tb_servidor.Text = "localhost";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(76, 104);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(167, 20);
            this.tb_senha.TabIndex = 19;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Servidor (IP)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Usuário";
            // 
            // VER_BANCO_DE_DADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 420);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 458);
            this.Name = "VER_BANCO_DE_DADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VER_BANCO_DE_DADOS_FormClosing);
            this.Load += new System.EventHandler(this.VER_BANCO_DE_DADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_banco_de_dados_presentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_banco_de_dados_presentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_servidor;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pgb_carregando;
        private System.Windows.Forms.Label lb_bancos_presentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_mostra_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}