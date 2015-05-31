namespace MySqlToolCTG_IT
{
    partial class CriarBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarBanco));
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_padrao = new System.Windows.Forms.CheckBox();
            this.cb_charset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_padrão2 = new System.Windows.Forms.CheckBox();
            this.cb_collation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(15, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(304, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do banco de dados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-90, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Character Set:";
            // 
            // cb_padrao
            // 
            this.cb_padrao.AutoSize = true;
            this.cb_padrao.Checked = true;
            this.cb_padrao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_padrao.Location = new System.Drawing.Point(93, 51);
            this.cb_padrao.Name = "cb_padrao";
            this.cb_padrao.Size = new System.Drawing.Size(84, 17);
            this.cb_padrao.TabIndex = 11;
            this.cb_padrao.Text = "Usar padrão";
            this.cb_padrao.UseVisualStyleBackColor = true;
            this.cb_padrao.CheckedChanged += new System.EventHandler(this.cb_padrao_CheckedChanged);
            // 
            // cb_charset
            // 
            this.cb_charset.Enabled = false;
            this.cb_charset.FormattingEnabled = true;
            this.cb_charset.Location = new System.Drawing.Point(15, 74);
            this.cb_charset.Name = "cb_charset";
            this.cb_charset.Size = new System.Drawing.Size(304, 21);
            this.cb_charset.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Character Set:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Collation:";
            // 
            // cb_padrão2
            // 
            this.cb_padrão2.AutoSize = true;
            this.cb_padrão2.Checked = true;
            this.cb_padrão2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_padrão2.Enabled = false;
            this.cb_padrão2.Location = new System.Drawing.Point(93, 101);
            this.cb_padrão2.Name = "cb_padrão2";
            this.cb_padrão2.Size = new System.Drawing.Size(84, 17);
            this.cb_padrão2.TabIndex = 17;
            this.cb_padrão2.Text = "Usar padrão";
            this.cb_padrão2.UseVisualStyleBackColor = true;
            this.cb_padrão2.CheckedChanged += new System.EventHandler(this.cb_padrão2_CheckedChanged);
            // 
            // cb_collation
            // 
            this.cb_collation.Enabled = false;
            this.cb_collation.FormattingEnabled = true;
            this.cb_collation.Location = new System.Drawing.Point(15, 124);
            this.cb_collation.Name = "cb_collation";
            this.cb_collation.Size = new System.Drawing.Size(304, 21);
            this.cb_collation.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Criar Banco de Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CriarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_collation);
            this.Controls.Add(this.cb_padrão2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_padrao);
            this.Controls.Add(this.cb_charset);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriarBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_padrao;
        private System.Windows.Forms.ComboBox cb_charset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cb_padrão2;
        private System.Windows.Forms.ComboBox cb_collation;
        private System.Windows.Forms.Button button1;
    }
}