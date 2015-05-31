namespace MySqlToolCTG_IT
{
    partial class novaTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novaTabela));
            this.button1 = new System.Windows.Forms.Button();
            this.dg_tabela = new System.Windows.Forms.DataGridView();
            this.Campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVariavel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AutoIncrement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Unsigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeDaTabela = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tabela)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(617, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Criar Tabela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_tabela
            // 
            this.dg_tabela.AllowUserToOrderColumns = true;
            this.dg_tabela.BackgroundColor = System.Drawing.Color.White;
            this.dg_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campo,
            this.tipoVariavel,
            this.tamanho,
            this.NN,
            this.AutoIncrement,
            this.Unsigned,
            this.PrimaryKey});
            this.dg_tabela.Location = new System.Drawing.Point(6, 19);
            this.dg_tabela.Name = "dg_tabela";
            this.dg_tabela.Size = new System.Drawing.Size(702, 411);
            this.dg_tabela.TabIndex = 6;
            this.dg_tabela.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_tabela_RowEnter);
            // 
            // Campo
            // 
            this.Campo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Campo.HeaderText = "Nome do Campo";
            this.Campo.Name = "Campo";
            this.Campo.Width = 102;
            // 
            // tipoVariavel
            // 
            this.tipoVariavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoVariavel.HeaderText = "Tipo de Dados";
            this.tipoVariavel.Items.AddRange(new object[] {
            "BIGINT",
            "BIT",
            "BLOB",
            "BOOL",
            "CHAR",
            "DATE",
            "DATETIME",
            "DECIMAL",
            "DOUBLE",
            "DOUBLEPRECISION",
            "ENUM",
            "FLOAT",
            "GEOMETRY",
            "GEOMETRYCOLLECTION",
            "INT",
            "INTEGER",
            "LINESTRING",
            "LONGBLOB",
            "LONGTEXT",
            "MEDIUMBLOB",
            "MEDIUMINT",
            "MEDIUMTEXT",
            "MULTILINESTRING",
            "MULTIPOINT",
            "MULTIPOLYGON",
            "NUMERIC",
            "POLYGON",
            "REAL",
            "SET",
            "SMALLINT",
            "TEXT",
            "TIME",
            "TIMESTAMP",
            "TINYBOP",
            "TINYINT",
            "TINYTEXT",
            "VARCHAR",
            "YEAR"});
            this.tipoVariavel.Name = "tipoVariavel";
            this.tipoVariavel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoVariavel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipoVariavel.Width = 94;
            // 
            // tamanho
            // 
            this.tamanho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tamanho.HeaderText = "Tamanho do Campo";
            this.tamanho.MaxInputLength = 9;
            this.tamanho.Name = "tamanho";
            this.tamanho.Width = 88;
            // 
            // NN
            // 
            this.NN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NN.HeaderText = "Not Null";
            this.NN.Name = "NN";
            this.NN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NN.Width = 65;
            // 
            // AutoIncrement
            // 
            this.AutoIncrement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AutoIncrement.HeaderText = "Auto Increment";
            this.AutoIncrement.Name = "AutoIncrement";
            this.AutoIncrement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoIncrement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AutoIncrement.Width = 96;
            // 
            // Unsigned
            // 
            this.Unsigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Unsigned.HeaderText = "Unsigned";
            this.Unsigned.Name = "Unsigned";
            this.Unsigned.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unsigned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unsigned.Width = 77;
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrimaryKey.HeaderText = "Primary Key";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.Width = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dg_tabela);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 436);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome da tabela:";
            // 
            // tb_nomeDaTabela
            // 
            this.tb_nomeDaTabela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nomeDaTabela.Location = new System.Drawing.Point(294, 12);
            this.tb_nomeDaTabela.Name = "tb_nomeDaTabela";
            this.tb_nomeDaTabela.Size = new System.Drawing.Size(225, 20);
            this.tb_nomeDaTabela.TabIndex = 0;
            // 
            // novaTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 515);
            this.Controls.Add(this.tb_nomeDaTabela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(755, 553);
            this.Name = "novaTabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Tabela";
            ((System.ComponentModel.ISupportInitialize)(this.dg_tabela)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_tabela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeDaTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipoVariavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AutoIncrement;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Unsigned;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrimaryKey;
    }
}