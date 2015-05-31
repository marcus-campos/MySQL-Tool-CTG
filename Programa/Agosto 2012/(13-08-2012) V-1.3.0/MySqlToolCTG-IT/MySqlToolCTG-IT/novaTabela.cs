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
    public partial class novaTabela : Form
    {
        List<string> ValoresNumericos = new List<string>() {"INT","TINYINT","SMALLINT","MEDIUMINT","BIGINT","FLOAT","DOUBLE","DECIMAL"};
        ControladorBanco DBcontrol = new ControladorBanco();
        public novaTabela()
        {
            InitializeComponent();
        }        

        public bool ValidaTiposNumericos()
        {
            bool rtn = false;
            //string MSG_Numericos = "";
            for (int a = 0; a < dg_tabela.Rows.Count - 1; a++)
            {
                for (int w = 0; w < ValoresNumericos.Count; w++)
                {
                    if (dg_tabela.Rows[a].Cells[1].Value.ToString() == ValoresNumericos[w] && dg_tabela.Rows[a].Cells[2].Value.ToString() == "")
                    {
                        if (w == 1)
                        {
                            dg_tabela.Rows[a].Cells[2].Value = "3";
                        }
                        else
                            if (w == 2)
                            {
                                dg_tabela.Rows[a].Cells[2].Value = "5";
                            }
                            else
                                if (w == 3)
                                {
                                    dg_tabela.Rows[a].Cells[2].Value = "8";
                                }
                                else
                                {
                                    dg_tabela.Rows[a].Cells[2].Value = "10";
                                }
                        //MSG_Numericos += "O tamanho do campo " + ValoresNumericos[w].ToString() + " Na linha " + a + " foi alterado para um valor padrão.\n";
                    }
                    else
                    {

                    }
                }
            }           
            return rtn;
        }

        public bool ValidaCampos()
        {
            bool rtn = false;
            for (int y = 0; y < dg_tabela.Rows.Count - 1; y++)
            {
                if (dg_tabela.Rows[y].Cells[0].Value == null)
                {
                    MessageBox.Show("Por favor preencha corretamente o campo \"Nome do campo\" na linha " + (y + 1) + ".", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = true;
                }
                else
                    if (dg_tabela.Rows[y].Cells[1].Value == null)
                    {
                        MessageBox.Show("Por favor preencha corretamente o campo \"Tipo de dados\" na linha " + (y + 1) + ".", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rtn = true;
                    }
                    else
                        if (dg_tabela.Rows[y].Cells[2].Value == null)
                        {
                            MessageBox.Show("Por favor preencha corretamente o campo \"Tamanho do campo\" na linha " + (y + 1) + ".", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rtn = true;
                        }

            }
            return rtn;
        }

        public void CriarTabela(string nomeTabela)
        {
            string _SQL = "";
            _SQL += "CREATE TABLE " + nomeTabela + "(";

            for (int x = 0; x < dg_tabela.Rows.Count - 1; x++)
            {
                try
                {
                    string NN = "";
                    string auto_increment = "";
                    string primary_key = "";
                    string unsigned = "";

                    if (dg_tabela.Rows[x].Cells[3].Value != null)
                    {
                        NN = "NOT NULL";
                    }
                    else
                    {
                        NN = "";
                    }

                    if (dg_tabela.Rows[x].Cells[4].Value != null)
                    {
                        auto_increment = "AUTO_INCREMENT";
                    }
                    else
                    {
                        auto_increment = "";
                    }

                    if (dg_tabela.Rows[x].Cells[5].Value != null)
                    {
                        unsigned = "UNSIGNED";
                    }
                    else
                    {
                        unsigned = "";
                    }

                    if (dg_tabela.Rows[x].Cells[6].Value != null)
                    {
                        primary_key = "PRIMARY KEY";
                    }
                    else
                    {
                        primary_key = "";
                    }
                    if ((x + 1) == dg_tabela.Rows.Count - 1)
                    {
                        _SQL += dg_tabela.Rows[x].Cells[0].Value + " " + dg_tabela.Rows[x].Cells[1].Value + "(" + dg_tabela.Rows[x].Cells[2].Value + ")" + " " + NN + " " + auto_increment + " " + unsigned + " " + primary_key + ");";
                    }
                    else
                    {
                        _SQL += dg_tabela.Rows[x].Cells[0].Value + " " + dg_tabela.Rows[x].Cells[1].Value + "(" + dg_tabela.Rows[x].Cells[2].Value + ")" + " " + NN + " " + auto_increment + " " + unsigned + " " + primary_key + ", ";
                    }
                }
                catch
                {

                }                
            }
            DBcontrol.Modificador(_SQL,true,"Tabela criada com sucesso!");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nomeDaTabela.Text == "")
            {
                MessageBox.Show("Por favor dê um nome à tabela ","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ValidaCampos() == true)
                {
                    return;
                }
                else
                    if (ValidaTiposNumericos() == true)
                    {
                        return;
                    }
                    else
                    {
                        CriarTabela(tb_nomeDaTabela.Text);
                        this.Close();
                    }

            }
        }

        private void dg_tabela_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_tabela.RowCount == 1)
            {
                dg_tabela.Rows[0].Cells[6].Value = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

    }
}
