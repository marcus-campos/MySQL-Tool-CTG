namespace MySql_Tool
{
    partial class CRIAR_TRIGGER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRIAR_TRIGGER));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_parametros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_on = new System.Windows.Forms.TextBox();
            this.rtb_corpo_trigger = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_condicao = new System.Windows.Forms.ComboBox();
            this.cb_quando_ativa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome_trigger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_parametros);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_on);
            this.groupBox1.Controls.Add(this.rtb_corpo_trigger);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_condicao);
            this.groupBox1.Controls.Add(this.cb_quando_ativa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_nome_trigger);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Trigger";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(341, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Criar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(422, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pré visualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(522, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_parametros
            // 
            this.tb_parametros.Location = new System.Drawing.Point(327, 89);
            this.tb_parametros.Name = "tb_parametros";
            this.tb_parametros.Size = new System.Drawing.Size(270, 20);
            this.tb_parametros.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tabela";
            // 
            // tb_on
            // 
            this.tb_on.Location = new System.Drawing.Point(246, 88);
            this.tb_on.Name = "tb_on";
            this.tb_on.Size = new System.Drawing.Size(75, 20);
            this.tb_on.TabIndex = 8;
            this.tb_on.Text = "ON";
            // 
            // rtb_corpo_trigger
            // 
            this.rtb_corpo_trigger.Location = new System.Drawing.Point(9, 128);
            this.rtb_corpo_trigger.Name = "rtb_corpo_trigger";
            this.rtb_corpo_trigger.Size = new System.Drawing.Size(588, 304);
            this.rtb_corpo_trigger.TabIndex = 7;
            this.rtb_corpo_trigger.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ações a serem executadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Condição";
            // 
            // cb_condicao
            // 
            this.cb_condicao.FormattingEnabled = true;
            this.cb_condicao.Items.AddRange(new object[] {
            "Delete",
            "Insert",
            "Update"});
            this.cb_condicao.Location = new System.Drawing.Point(9, 88);
            this.cb_condicao.Name = "cb_condicao";
            this.cb_condicao.Size = new System.Drawing.Size(231, 21);
            this.cb_condicao.TabIndex = 4;
            // 
            // cb_quando_ativa
            // 
            this.cb_quando_ativa.FormattingEnabled = true;
            this.cb_quando_ativa.Items.AddRange(new object[] {
            "After",
            "Before"});
            this.cb_quando_ativa.Location = new System.Drawing.Point(327, 49);
            this.cb_quando_ativa.Name = "cb_quando_ativa";
            this.cb_quando_ativa.Size = new System.Drawing.Size(270, 21);
            this.cb_quando_ativa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quando ativa";
            // 
            // tb_nome_trigger
            // 
            this.tb_nome_trigger.Location = new System.Drawing.Point(9, 49);
            this.tb_nome_trigger.Name = "tb_nome_trigger";
            this.tb_nome_trigger.Size = new System.Drawing.Size(312, 20);
            this.tb_nome_trigger.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Trigger";
            // 
            // CRIAR_TRIGGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(627, 488);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(643, 526);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(643, 526);
            this.Name = "CRIAR_TRIGGER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Trigger";
            this.Load += new System.EventHandler(this.CRIAR_TRIGGER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_parametros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_on;
        private System.Windows.Forms.RichTextBox rtb_corpo_trigger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_condicao;
        private System.Windows.Forms.ComboBox cb_quando_ativa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome_trigger;
        private System.Windows.Forms.Label label1;
    }
}