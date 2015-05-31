namespace MySql_Tool
{
    partial class Pesquisa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_comandos = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_colunas_cmd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_linhas_cmd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid_dadosArmazenados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_colunas_desc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_linhas_desc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_desc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_limite_registros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid_tabelas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maisFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTriggersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dadosArmazenados)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_desc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tabelas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 523);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.rtb_comandos);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox5.Location = new System.Drawing.Point(315, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 129);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Query";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(358, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_comandos
            // 
            this.rtb_comandos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_comandos.BackColor = System.Drawing.Color.White;
            this.rtb_comandos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_comandos.Location = new System.Drawing.Point(6, 19);
            this.rtb_comandos.Name = "rtb_comandos";
            this.rtb_comandos.Size = new System.Drawing.Size(427, 75);
            this.rtb_comandos.TabIndex = 0;
            this.rtb_comandos.Text = "";
            this.rtb_comandos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_comandos_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lb_colunas_cmd);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_linhas_cmd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dataGrid_dadosArmazenados);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(315, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 137);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lb_colunas_cmd
            // 
            this.lb_colunas_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_colunas_cmd.AutoSize = true;
            this.lb_colunas_cmd.Location = new System.Drawing.Point(393, 118);
            this.lb_colunas_cmd.Name = "lb_colunas_cmd";
            this.lb_colunas_cmd.Size = new System.Drawing.Size(0, 13);
            this.lb_colunas_cmd.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Colunas:";
            // 
            // lb_linhas_cmd
            // 
            this.lb_linhas_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_linhas_cmd.AutoSize = true;
            this.lb_linhas_cmd.Location = new System.Drawing.Point(263, 118);
            this.lb_linhas_cmd.Name = "lb_linhas_cmd";
            this.lb_linhas_cmd.Size = new System.Drawing.Size(0, 13);
            this.lb_linhas_cmd.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Linhas:";
            // 
            // dataGrid_dadosArmazenados
            // 
            this.dataGrid_dadosArmazenados.AllowUserToAddRows = false;
            this.dataGrid_dadosArmazenados.AllowUserToDeleteRows = false;
            this.dataGrid_dadosArmazenados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_dadosArmazenados.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_dadosArmazenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_dadosArmazenados.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_dadosArmazenados.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_dadosArmazenados.Name = "dataGrid_dadosArmazenados";
            this.dataGrid_dadosArmazenados.ReadOnly = true;
            this.dataGrid_dadosArmazenados.Size = new System.Drawing.Size(427, 96);
            this.dataGrid_dadosArmazenados.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.lb_colunas_desc);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lb_linhas_desc);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dataGrid_desc);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox4.Location = new System.Drawing.Point(309, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 220);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desc";
            // 
            // lb_colunas_desc
            // 
            this.lb_colunas_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_colunas_desc.AutoSize = true;
            this.lb_colunas_desc.Location = new System.Drawing.Point(399, 201);
            this.lb_colunas_desc.Name = "lb_colunas_desc";
            this.lb_colunas_desc.Size = new System.Drawing.Size(0, 13);
            this.lb_colunas_desc.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Colunas:";
            // 
            // lb_linhas_desc
            // 
            this.lb_linhas_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_linhas_desc.AutoSize = true;
            this.lb_linhas_desc.Location = new System.Drawing.Point(269, 201);
            this.lb_linhas_desc.Name = "lb_linhas_desc";
            this.lb_linhas_desc.Size = new System.Drawing.Size(0, 13);
            this.lb_linhas_desc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Linhas:";
            // 
            // dataGrid_desc
            // 
            this.dataGrid_desc.AllowUserToAddRows = false;
            this.dataGrid_desc.AllowUserToDeleteRows = false;
            this.dataGrid_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_desc.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_desc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_desc.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_desc.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_desc.Name = "dataGrid_desc";
            this.dataGrid_desc.ReadOnly = true;
            this.dataGrid_desc.Size = new System.Drawing.Size(433, 179);
            this.dataGrid_desc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tb_limite_registros);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGrid_tabelas);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 498);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabelas";
            // 
            // tb_limite_registros
            // 
            this.tb_limite_registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_limite_registros.Location = new System.Drawing.Point(197, 472);
            this.tb_limite_registros.Name = "tb_limite_registros";
            this.tb_limite_registros.Size = new System.Drawing.Size(100, 20);
            this.tb_limite_registros.TabIndex = 2;
            this.tb_limite_registros.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Limite de registros a serem mostrados:";
            // 
            // dataGrid_tabelas
            // 
            this.dataGrid_tabelas.AllowUserToAddRows = false;
            this.dataGrid_tabelas.AllowUserToDeleteRows = false;
            this.dataGrid_tabelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_tabelas.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_tabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_tabelas.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_tabelas.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_tabelas.Name = "dataGrid_tabelas";
            this.dataGrid_tabelas.ReadOnly = true;
            this.dataGrid_tabelas.Size = new System.Drawing.Size(291, 447);
            this.dataGrid_tabelas.TabIndex = 0;
            this.dataGrid_tabelas.DoubleClick += new System.EventHandler(this.dataGrid_tabelas_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maisFunçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // maisFunçõesToolStripMenuItem
            // 
            this.maisFunçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandosToolStripMenuItem});
            this.maisFunçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.maisFunçõesToolStripMenuItem.Name = "maisFunçõesToolStripMenuItem";
            this.maisFunçõesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.maisFunçõesToolStripMenuItem.Text = "&Mais funções";
            // 
            // comandosToolStripMenuItem
            // 
            this.comandosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFromToolStripMenuItem,
            this.descToolStripMenuItem,
            this.showTriggersToolStripMenuItem,
            this.showProceduresToolStripMenuItem});
            this.comandosToolStripMenuItem.Name = "comandosToolStripMenuItem";
            this.comandosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.comandosToolStripMenuItem.Text = "&Mais comandos";
            // 
            // selectFromToolStripMenuItem
            // 
            this.selectFromToolStripMenuItem.Name = "selectFromToolStripMenuItem";
            this.selectFromToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.selectFromToolStripMenuItem.Text = "&Select * from";
            this.selectFromToolStripMenuItem.Click += new System.EventHandler(this.selectFromToolStripMenuItem_Click);
            // 
            // descToolStripMenuItem
            // 
            this.descToolStripMenuItem.Name = "descToolStripMenuItem";
            this.descToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.descToolStripMenuItem.Text = "&Desc";
            this.descToolStripMenuItem.Click += new System.EventHandler(this.descToolStripMenuItem_Click);
            // 
            // showTriggersToolStripMenuItem
            // 
            this.showTriggersToolStripMenuItem.Name = "showTriggersToolStripMenuItem";
            this.showTriggersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showTriggersToolStripMenuItem.Text = "S&how Triggers";
            this.showTriggersToolStripMenuItem.Click += new System.EventHandler(this.showTriggersToolStripMenuItem_Click);
            // 
            // showProceduresToolStripMenuItem
            // 
            this.showProceduresToolStripMenuItem.Name = "showProceduresToolStripMenuItem";
            this.showProceduresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showProceduresToolStripMenuItem.Text = "Sh&ow Procedures";
            this.showProceduresToolStripMenuItem.Click += new System.EventHandler(this.showProceduresToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_rapida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dadosArmazenados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_desc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tabelas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_comandos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGrid_dadosArmazenados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGrid_tabelas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maisFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTriggersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProceduresToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_colunas_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_linhas_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_desc;
        private System.Windows.Forms.Label lb_colunas_cmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_linhas_cmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_limite_registros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;

    }
}