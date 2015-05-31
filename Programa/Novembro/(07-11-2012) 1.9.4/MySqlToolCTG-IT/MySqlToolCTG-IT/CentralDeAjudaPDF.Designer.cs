namespace MySqlToolCTG_IT
{
    partial class CentralDeAjudaPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentralDeAjudaPDF));
            this.leitor_pdf = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.leitor_pdf)).BeginInit();
            this.SuspendLayout();
            // 
            // leitor_pdf
            // 
            this.leitor_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.leitor_pdf.Enabled = true;
            this.leitor_pdf.Location = new System.Drawing.Point(12, 12);
            this.leitor_pdf.Name = "leitor_pdf";
            this.leitor_pdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("leitor_pdf.OcxState")));
            this.leitor_pdf.Size = new System.Drawing.Size(760, 538);
            this.leitor_pdf.TabIndex = 0;
            // 
            // CentralDeAjudaPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.leitor_pdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CentralDeAjudaPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CentralDeAjudaPDF";
            this.Load += new System.EventHandler(this.CentralDeAjudaPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leitor_pdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF leitor_pdf;
    }
}