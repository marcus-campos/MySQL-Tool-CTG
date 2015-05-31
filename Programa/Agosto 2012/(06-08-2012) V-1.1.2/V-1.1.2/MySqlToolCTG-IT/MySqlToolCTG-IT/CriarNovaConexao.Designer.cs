namespace MySqlToolCTG_IT
{
    partial class CriarNovaConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarNovaConexao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_senha = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeConexao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pgb_teste_conexao = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_senha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_senha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_porta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_nomeConexao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações gerais";
            // 
            // cb_senha
            // 
            this.cb_senha.AutoSize = true;
            this.cb_senha.Location = new System.Drawing.Point(220, 177);
            this.cb_senha.Name = "cb_senha";
            this.cb_senha.Size = new System.Drawing.Size(93, 17);
            this.cb_senha.TabIndex = 10;
            this.cb_senha.Text = "Mostrar senha";
            this.cb_senha.UseVisualStyleBackColor = true;
            this.cb_senha.CheckedChanged += new System.EventHandler(this.cb_senha_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha:\r\n";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(164, 151);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(149, 20);
            this.tb_senha.TabIndex = 8;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuario:\r\n";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(9, 151);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(149, 20);
            this.tb_usuario.TabIndex = 6;
            this.tb_usuario.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porta:\r\n";
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(208, 112);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(105, 20);
            this.tb_porta.TabIndex = 4;
            this.tb_porta.Text = "3306";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip ou nome do Host:\r\n";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(9, 112);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(193, 20);
            this.tb_ip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da conexão:\r\n";
            // 
            // tb_nomeConexao
            // 
            this.tb_nomeConexao.Location = new System.Drawing.Point(9, 42);
            this.tb_nomeConexao.Name = "tb_nomeConexao";
            this.tb_nomeConexao.Size = new System.Drawing.Size(304, 20);
            this.tb_nomeConexao.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Criar conexão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Testar conexão";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pgb_teste_conexao
            // 
            this.pgb_teste_conexao.Location = new System.Drawing.Point(110, 232);
            this.pgb_teste_conexao.Name = "pgb_teste_conexao";
            this.pgb_teste_conexao.Size = new System.Drawing.Size(125, 23);
            this.pgb_teste_conexao.TabIndex = 13;
            // 
            // CriarNovaConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 267);
            this.Controls.Add(this.pgb_teste_conexao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 305);
            this.Name = "CriarNovaConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova conexão";
            this.Load += new System.EventHandler(this.CriarNovaConexao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeConexao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pgb_teste_conexao;
    }
}