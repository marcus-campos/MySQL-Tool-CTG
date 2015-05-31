namespace MySql_Tool
{
    partial class PESQUISA_MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PESQUISA_MDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarEmModoDeCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horisontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aranjarIconesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abirToolStripMenuItem,
            this.guiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.guiaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abirToolStripMenuItem
            // 
            this.abirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPesquisaToolStripMenuItem});
            this.abirToolStripMenuItem.Name = "abirToolStripMenuItem";
            this.abirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.abirToolStripMenuItem.Text = "Abir";
            // 
            // novaPesquisaToolStripMenuItem
            // 
            this.novaPesquisaToolStripMenuItem.Name = "novaPesquisaToolStripMenuItem";
            this.novaPesquisaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.novaPesquisaToolStripMenuItem.Text = "Nova pesquisa";
            this.novaPesquisaToolStripMenuItem.Click += new System.EventHandler(this.novaPesquisaToolStripMenuItem_Click);
            // 
            // guiaToolStripMenuItem
            // 
            this.guiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustarEmModoDeCascataToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horisontalToolStripMenuItem,
            this.fecharTodosToolStripMenuItem,
            this.aranjarIconesToolStripMenuItem,
            this.toolStripSeparator1});
            this.guiaToolStripMenuItem.Name = "guiaToolStripMenuItem";
            this.guiaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.guiaToolStripMenuItem.Text = "Guia";
            // 
            // ajustarEmModoDeCascataToolStripMenuItem
            // 
            this.ajustarEmModoDeCascataToolStripMenuItem.Name = "ajustarEmModoDeCascataToolStripMenuItem";
            this.ajustarEmModoDeCascataToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ajustarEmModoDeCascataToolStripMenuItem.Text = "Cascata";
            this.ajustarEmModoDeCascataToolStripMenuItem.Click += new System.EventHandler(this.ajustarEmModoDeCascataToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horisontalToolStripMenuItem
            // 
            this.horisontalToolStripMenuItem.Name = "horisontalToolStripMenuItem";
            this.horisontalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.horisontalToolStripMenuItem.Text = "Horizontal";
            this.horisontalToolStripMenuItem.Click += new System.EventHandler(this.horisontalToolStripMenuItem_Click);
            // 
            // fecharTodosToolStripMenuItem
            // 
            this.fecharTodosToolStripMenuItem.Name = "fecharTodosToolStripMenuItem";
            this.fecharTodosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fecharTodosToolStripMenuItem.Text = "Fechar todos";
            this.fecharTodosToolStripMenuItem.Click += new System.EventHandler(this.fecharTodosToolStripMenuItem_Click);
            // 
            // aranjarIconesToolStripMenuItem
            // 
            this.aranjarIconesToolStripMenuItem.Name = "aranjarIconesToolStripMenuItem";
            this.aranjarIconesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aranjarIconesToolStripMenuItem.Text = "Arranjar Icones";
            this.aranjarIconesToolStripMenuItem.Click += new System.EventHandler(this.aranjarIconesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // PESQUISA_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PESQUISA_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.PESQUISA_MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarEmModoDeCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horisontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aranjarIconesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}