namespace MySqlToolCTG_IT
{
    partial class MenuOpcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOpcoes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_janelas = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_listaErro_ME_N = new System.Windows.Forms.RadioButton();
            this.rb_listaErro_ME_S = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_listaErro_MJ_N = new System.Windows.Forms.RadioButton();
            this.rb_listaErro_MJ_S = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tb_janelas.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tb_janelas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_janelas
            // 
            this.tb_janelas.Controls.Add(this.tabControl2);
            this.tb_janelas.Location = new System.Drawing.Point(4, 22);
            this.tb_janelas.Name = "tb_janelas";
            this.tb_janelas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_janelas.Size = new System.Drawing.Size(635, 369);
            this.tb_janelas.TabIndex = 1;
            this.tb_janelas.Text = "Janelas";
            this.tb_janelas.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(623, 357);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(615, 331);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Lista de erros";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = "";
            this.groupBox2.Controls.Add(this.rb_listaErro_ME_N);
            this.groupBox2.Controls.Add(this.rb_listaErro_ME_S);
            this.groupBox2.Location = new System.Drawing.Point(159, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ativar lista de multi erros";
            // 
            // rb_listaErro_ME_N
            // 
            this.rb_listaErro_ME_N.AccessibleDescription = "Quando um erro persistir, a lista reportará todos os passos anteriores ate que o " +
                "erro seja corrigido.";
            this.rb_listaErro_ME_N.AutoSize = true;
            this.rb_listaErro_ME_N.Location = new System.Drawing.Point(49, 53);
            this.rb_listaErro_ME_N.Name = "rb_listaErro_ME_N";
            this.rb_listaErro_ME_N.Size = new System.Drawing.Size(45, 17);
            this.rb_listaErro_ME_N.TabIndex = 1;
            this.rb_listaErro_ME_N.TabStop = true;
            this.rb_listaErro_ME_N.Text = "Não";
            this.rb_listaErro_ME_N.UseVisualStyleBackColor = true;
            // 
            // rb_listaErro_ME_S
            // 
            this.rb_listaErro_ME_S.AccessibleDescription = "Quando um erro persistir, a lista reportará todos os passos anteriores ate que o " +
                "erro seja corrigido.";
            this.rb_listaErro_ME_S.AutoSize = true;
            this.rb_listaErro_ME_S.Location = new System.Drawing.Point(49, 30);
            this.rb_listaErro_ME_S.Name = "rb_listaErro_ME_S";
            this.rb_listaErro_ME_S.Size = new System.Drawing.Size(42, 17);
            this.rb_listaErro_ME_S.TabIndex = 0;
            this.rb_listaErro_ME_S.TabStop = true;
            this.rb_listaErro_ME_S.Text = "Sim";
            this.rb_listaErro_ME_S.UseVisualStyleBackColor = true;
            this.rb_listaErro_ME_S.MouseHover += new System.EventHandler(this.radioButton4_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_listaErro_MJ_N);
            this.groupBox1.Controls.Add(this.rb_listaErro_MJ_S);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar janela";
            // 
            // rb_listaErro_MJ_N
            // 
            this.rb_listaErro_MJ_N.AutoSize = true;
            this.rb_listaErro_MJ_N.Location = new System.Drawing.Point(49, 53);
            this.rb_listaErro_MJ_N.Name = "rb_listaErro_MJ_N";
            this.rb_listaErro_MJ_N.Size = new System.Drawing.Size(45, 17);
            this.rb_listaErro_MJ_N.TabIndex = 1;
            this.rb_listaErro_MJ_N.TabStop = true;
            this.rb_listaErro_MJ_N.Text = "Não";
            this.rb_listaErro_MJ_N.UseVisualStyleBackColor = true;
            // 
            // rb_listaErro_MJ_S
            // 
            this.rb_listaErro_MJ_S.AutoSize = true;
            this.rb_listaErro_MJ_S.Location = new System.Drawing.Point(49, 30);
            this.rb_listaErro_MJ_S.Name = "rb_listaErro_MJ_S";
            this.rb_listaErro_MJ_S.Size = new System.Drawing.Size(42, 17);
            this.rb_listaErro_MJ_S.TabIndex = 0;
            this.rb_listaErro_MJ_S.TabStop = true;
            this.rb_listaErro_MJ_S.Text = "Sim";
            this.rb_listaErro_MJ_S.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(615, 331);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MenuOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 419);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuOpcoes";
            this.tabControl1.ResumeLayout(false);
            this.tb_janelas.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tb_janelas;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_listaErro_ME_N;
        private System.Windows.Forms.RadioButton rb_listaErro_ME_S;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_listaErro_MJ_N;
        private System.Windows.Forms.RadioButton rb_listaErro_MJ_S;
        private System.Windows.Forms.Button button1;
    }
}