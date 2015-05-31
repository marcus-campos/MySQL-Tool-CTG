namespace MySqlToolCTG_IT
{
    partial class CentralDeAjuda
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
            this.wb_ajuda = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wb_ajuda
            // 
            this.wb_ajuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_ajuda.Location = new System.Drawing.Point(0, 0);
            this.wb_ajuda.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_ajuda.Name = "wb_ajuda";
            this.wb_ajuda.Size = new System.Drawing.Size(784, 562);
            this.wb_ajuda.TabIndex = 1;
            // 
            // CentralDeAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.wb_ajuda);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CentralDeAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de ajuda ao usuario";
            this.Load += new System.EventHandler(this.CentralDeAjuda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_ajuda;
    }
}