using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySqlToolCTG_IT
{
    public partial class tutorial1 : Form
    {
        public tutorial1()
        {
            InitializeComponent();
        }

        private void nome_Load(object sender, EventArgs e)
        {

        }

        private void btn_proximo1_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("O nome do banco não pode ficar em branco");
            }
            else
            {                
                Tutorial2 tuto2 = new Tutorial2();
                tuto2._nomeBancot2 = tb_nome.Text;
                tuto2.ShowDialog();
                this.Close();
            }
        }
    }
}
