namespace MySqlToolCTG_IT
{
    partial class FeedBack
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
            this.tk_nota = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_nota = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_comentario = new System.Windows.Forms.RichTextBox();
            this.lb_versao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tk_nota)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tk_nota
            // 
            this.tk_nota.Location = new System.Drawing.Point(6, 127);
            this.tk_nota.Name = "tk_nota";
            this.tk_nota.Size = new System.Drawing.Size(433, 45);
            this.tk_nota.TabIndex = 0;
            this.tk_nota.Value = 10;
            this.tk_nota.Scroll += new System.EventHandler(this.tk_nota_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_nota);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtb_comentario);
            this.groupBox1.Controls.Add(this.lb_versao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tk_nota);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota:";
            // 
            // lb_nota
            // 
            this.lb_nota.AutoSize = true;
            this.lb_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nota.Location = new System.Drawing.Point(247, 93);
            this.lb_nota.Name = "lb_nota";
            this.lb_nota.Size = new System.Drawing.Size(44, 31);
            this.lb_nota.TabIndex = 7;
            this.lb_nota.Text = "10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Lembrar mais tarde";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comentario (opcional)";
            // 
            // rtb_comentario
            // 
            this.rtb_comentario.Location = new System.Drawing.Point(10, 191);
            this.rtb_comentario.Name = "rtb_comentario";
            this.rtb_comentario.Size = new System.Drawing.Size(429, 137);
            this.rtb_comentario.TabIndex = 3;
            this.rtb_comentario.Text = "";
            // 
            // lb_versao
            // 
            this.lb_versao.AutoSize = true;
            this.lb_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_versao.Location = new System.Drawing.Point(343, 16);
            this.lb_versao.Name = "lb_versao";
            this.lb_versao.Size = new System.Drawing.Size(96, 20);
            this.lb_versao.TabIndex = 2;
            this.lb_versao.Text = "1.0.0 (Beta)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual nota você daria para a atual versão:";
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 387);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(485, 425);
            this.Name = "FeedBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedBack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedBack_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeedBack_FormClosed);
            this.Load += new System.EventHandler(this.FeedBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tk_nota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tk_nota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_versao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_nota;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_comentario;
    }
}