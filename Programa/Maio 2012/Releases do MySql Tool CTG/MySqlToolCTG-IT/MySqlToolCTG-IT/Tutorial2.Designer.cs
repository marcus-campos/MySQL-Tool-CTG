namespace MySqlToolCTG_IT
{
    partial class Tutorial2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_charset = new System.Windows.Forms.ComboBox();
            this.cb_padrao = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_collation = new System.Windows.Forms.ComboBox();
            this.cb_padrao2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "O segundo e ultimopasso, é um pouco mais complicado, mas,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "com nossa ajuda você consiguira terminar o seu banco de dados.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Você agora devera ecolher o \'Character Set\', do seu banco de dados, o \'Character " +
                "set\' define";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "os caracteres que o seu banco irá aceitar, por exemplo, enquanto determinado \'Cha" +
                "racter Set\'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "aceita acentos e pontuações, outros não aceitam.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Se você ainda é leigo no assunto e não intende muito sobre o mesmo, aconselhamos " +
                "que use";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "o \'Character set\' padrão.";
            // 
            // cb_charset
            // 
            this.cb_charset.Enabled = false;
            this.cb_charset.FormattingEnabled = true;
            this.cb_charset.Location = new System.Drawing.Point(104, 144);
            this.cb_charset.Name = "cb_charset";
            this.cb_charset.Size = new System.Drawing.Size(273, 21);
            this.cb_charset.TabIndex = 7;
            // 
            // cb_padrao
            // 
            this.cb_padrao.AutoSize = true;
            this.cb_padrao.Checked = true;
            this.cb_padrao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_padrao.Location = new System.Drawing.Point(383, 146);
            this.cb_padrao.Name = "cb_padrao";
            this.cb_padrao.Size = new System.Drawing.Size(84, 17);
            this.cb_padrao.TabIndex = 8;
            this.cb_padrao.Text = "Usar padrão";
            this.cb_padrao.UseVisualStyleBackColor = true;
            this.cb_padrao.CheckedChanged += new System.EventHandler(this.cb_padrao_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Character Set:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(464, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Agora você devera escolher a \'Collation\' do seu Banco de Dados, a \'Collation\' tra" +
                "balha junto com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(420, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = " o \'Character Set\' para codificar os caracteres do banco de dados. Cada \'Characte" +
                "r Set\'";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(447, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "possui uma ou mais \'Collations\', por isso, se você escolheu \'padrão\' como seu \'Ch" +
                "aracter Set\',";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "aconselhamos que você use o padrão novamente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Collation:";
            // 
            // cb_collation
            // 
            this.cb_collation.Enabled = false;
            this.cb_collation.FormattingEnabled = true;
            this.cb_collation.Location = new System.Drawing.Point(104, 248);
            this.cb_collation.Name = "cb_collation";
            this.cb_collation.Size = new System.Drawing.Size(273, 21);
            this.cb_collation.TabIndex = 16;
            // 
            // cb_padrao2
            // 
            this.cb_padrao2.AutoSize = true;
            this.cb_padrao2.Checked = true;
            this.cb_padrao2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_padrao2.Enabled = false;
            this.cb_padrao2.Location = new System.Drawing.Point(383, 250);
            this.cb_padrao2.Name = "cb_padrao2";
            this.cb_padrao2.Size = new System.Drawing.Size(85, 17);
            this.cb_padrao2.TabIndex = 17;
            this.cb_padrao2.Text = "Usar Padrão";
            this.cb_padrao2.UseVisualStyleBackColor = true;
            this.cb_padrao2.CheckedChanged += new System.EventHandler(this.cb_padrao2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(461, 88);
            this.button1.TabIndex = 18;
            this.button1.Text = "Concluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tutorial2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_padrao2);
            this.Controls.Add(this.cb_collation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_padrao);
            this.Controls.Add(this.cb_charset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tutorial2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charsets e Collation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_charset;
        private System.Windows.Forms.CheckBox cb_padrao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_collation;
        private System.Windows.Forms.CheckBox cb_padrao2;
        private System.Windows.Forms.Button button1;
    }
}