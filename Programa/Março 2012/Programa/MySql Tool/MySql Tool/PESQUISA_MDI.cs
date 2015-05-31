using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySql_Tool
{
    public partial class PESQUISA_MDI : Form
    {
        public PESQUISA_MDI()
        {
            InitializeComponent();
        }

        private void PESQUISA_MDI_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
          
        }

        private void novaPesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa nova_pesquisa = new Pesquisa();
            nova_pesquisa.MdiParent = this;
            nova_pesquisa.Show();
        }

        private void ajustarEmModoDeCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horisontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void aranjarIconesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form _parentes in MdiChildren)
            {
                _parentes.Close();
            }
        }
    }
}
