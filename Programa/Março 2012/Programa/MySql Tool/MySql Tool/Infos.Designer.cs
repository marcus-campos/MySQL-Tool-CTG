namespace MySql_Tool
{
    partial class Infos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cb_incicarBD = new System.Windows.Forms.CheckBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_mostra_senha = new System.Windows.Forms.CheckBox();
            this.pgb_teste_conexao = new System.Windows.Forms.ProgressBar();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_servidor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_vercao_tela_pri = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_total_downloads = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cb_incicarBD);
            this.groupBox1.Controls.Add(this.tb_database);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckb_mostra_senha);
            this.groupBox1.Controls.Add(this.pgb_teste_conexao);
            this.groupBox1.Controls.Add(this.tb_porta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tb_senha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_servidor);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(444, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 23);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // cb_incicarBD
            // 
            this.cb_incicarBD.AutoSize = true;
            this.cb_incicarBD.Location = new System.Drawing.Point(331, 158);
            this.cb_incicarBD.Name = "cb_incicarBD";
            this.cb_incicarBD.Size = new System.Drawing.Size(138, 17);
            this.cb_incicarBD.TabIndex = 20;
            this.cb_incicarBD.Text = "Indicar banco de dados";
            this.cb_incicarBD.UseVisualStyleBackColor = true;
            this.cb_incicarBD.CheckedChanged += new System.EventHandler(this.cb_incicarBD_CheckedChanged);
            // 
            // tb_database
            // 
            this.tb_database.Enabled = false;
            this.tb_database.Location = new System.Drawing.Point(232, 133);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(206, 20);
            this.tb_database.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Banco de dados";
            // 
            // ckb_mostra_senha
            // 
            this.ckb_mostra_senha.AutoSize = true;
            this.ckb_mostra_senha.Location = new System.Drawing.Point(376, 246);
            this.ckb_mostra_senha.Name = "ckb_mostra_senha";
            this.ckb_mostra_senha.Size = new System.Drawing.Size(93, 17);
            this.ckb_mostra_senha.TabIndex = 17;
            this.ckb_mostra_senha.Text = "Mostrar senha";
            this.ckb_mostra_senha.UseVisualStyleBackColor = true;
            this.ckb_mostra_senha.CheckStateChanged += new System.EventHandler(this.ckb_mostra_senha_CheckStateChanged);
            // 
            // pgb_teste_conexao
            // 
            this.pgb_teste_conexao.Location = new System.Drawing.Point(232, 312);
            this.pgb_teste_conexao.Name = "pgb_teste_conexao";
            this.pgb_teste_conexao.Size = new System.Drawing.Size(156, 23);
            this.pgb_teste_conexao.TabIndex = 14;
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(232, 91);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(237, 20);
            this.tb_porta.TabIndex = 1;
            this.tb_porta.Text = "3306";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Porta";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(394, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Avançar ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(232, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Testar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(394, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(313, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(232, 220);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(237, 20);
            this.tb_senha.TabIndex = 5;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(232, 181);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(237, 20);
            this.tb_usuario.TabIndex = 4;
            this.tb_usuario.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor (IP)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_servidor
            // 
            this.tb_servidor.Location = new System.Drawing.Point(232, 52);
            this.tb_servidor.Name = "tb_servidor";
            this.tb_servidor.Size = new System.Drawing.Size(237, 20);
            this.tb_servidor.TabIndex = 0;
            this.tb_servidor.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Versão:";
            // 
            // lb_vercao_tela_pri
            // 
            this.lb_vercao_tela_pri.AutoSize = true;
            this.lb_vercao_tela_pri.Location = new System.Drawing.Point(58, 356);
            this.lb_vercao_tela_pri.Name = "lb_vercao_tela_pri";
            this.lb_vercao_tela_pri.Size = new System.Drawing.Size(0, 13);
            this.lb_vercao_tela_pri.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total de downloads desta versão:";
            // 
            // lb_total_downloads
            // 
            this.lb_total_downloads.AutoSize = true;
            this.lb_total_downloads.Location = new System.Drawing.Point(401, 356);
            this.lb_total_downloads.Name = "lb_total_downloads";
            this.lb_total_downloads.Size = new System.Drawing.Size(79, 13);
            this.lb_total_downloads.TabIndex = 4;
            this.lb_total_downloads.Text = "Sem resultados";
            // 
            // Infos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(499, 378);
            this.ControlBox = false;
            this.Controls.Add(this.lb_total_downloads);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_vercao_tela_pri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Infos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySql Tool CTG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Infos_FormClosing);
            this.Load += new System.EventHandler(this.Infos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_servidor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_vercao_tela_pri;
        private System.Windows.Forms.ProgressBar pgb_teste_conexao;
        private System.Windows.Forms.CheckBox ckb_mostra_senha;
        private System.Windows.Forms.CheckBox cb_incicarBD;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_total_downloads;
    }
}