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
    public partial class CriarBanco : Form
    {
        public CriarBanco()
        {
            InitializeComponent();
        }

        private void cb_padrao_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_padrao.Checked == true)
            {
                cb_padrão2.Checked = true;
                cb_padrão2.Enabled = false;
                cb_charset.Enabled = false;
            }
            else
            {
                cb_charset.Enabled = true;
                cb_padrão2.Enabled = true;
            }
        }

        private void cb_padrão2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_padrão2.Checked == true)
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
            if (cb_padrão2.Checked == false)
            {
                _criarBanco._collate = cb_collation.Text;
            }
            else
            {
                _criarBanco._enableColation = false;
            }
            _criarBanco._nomeBanco = tb_nome.Text;
            _criarBanco.SQL();
            this.Close();
        }
    }
}
