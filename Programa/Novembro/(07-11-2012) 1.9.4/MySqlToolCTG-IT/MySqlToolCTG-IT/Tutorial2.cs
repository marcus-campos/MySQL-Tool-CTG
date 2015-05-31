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
    public partial class Tutorial2 : Form
    {
        private string nomeBancot2;

        public string _nomeBancot2
        {
            get { return nomeBancot2; }
            set { nomeBancot2 = value; }
        }

        public Tutorial2()
        {
            InitializeComponent();
        }

        private void cb_padrao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_padrao.Checked == true)
            {
                cb_charset.Enabled = false;
                cb_collation.Enabled = false;
                cb_padrao2.Enabled = false;
                cb_padrao2.Checked = true;
            }
            else
            {
                cb_charset.Enabled = true;
                //cb_collation.Enabled = true;
                cb_padrao2.Enabled = true;
            }
        }

        private void cb_padrao2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_padrao2.Checked == true)
            {
                cb_collation.Enabled = false;
            }
            else
            {
                cb_collation.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriadorBanco _criarBanco = new CriadorBanco();
            if (cb_padrao.Checked == true)
            {
                _criarBanco._enableCharset = false;
            }
            else
            {
                _criarBanco._charSet = cb_charset.Text;
            }
            if (cb_padrao2.Checked == false)
            {
                _criarBanco._collate = cb_collation.Text;
            }
            else
            {
                _criarBanco._enableColation = false;
            }
            _criarBanco._nomeBanco = _nomeBancot2;
            _criarBanco.SQL();
            this.Close();
        }
    }
}
