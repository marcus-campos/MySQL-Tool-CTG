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
    public partial class InserirNoBanco : Form
    {
        ControladorBanco ControladoresBD = new ControladorBanco();
        private string tabela;

        public string _tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        public InserirNoBanco()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InserirNoBanco_Load(object sender, EventArgs e)
        {
            CarregaTabela();
        }

        public void CarregaTabela()
        {
            try
            {
                TelaPrincipal tl_pri = new TelaPrincipal();
                ControladoresBD.Visualizador("Desc " + Program._UltimaTabelaSelecionada + ";", 0);

                for (int x = 0; x < ControladoresBD._dataSet.Tables[0].Rows.Count; x++)
                {
                    dg_inserir.Columns.Add(ControladoresBD._dataSet.Tables[0].Rows[x]["Field"].ToString(), ControladoresBD._dataSet.Tables[0].Rows[x]["Field"].ToString());
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsereNoBanco();
        }

        public void InsereNoBanco()
        {
            string _SQL = "Insert into "+Program._UltimaTabelaSelecionada+" values(";

            for (int x = 0; x < (dg_inserir.Rows.Count - 1); x++)
            {
                for(int y = 0; y < dg_inserir.Columns.Count; x++)
                {
                    if (y == 0)
                    {
                        _SQL += "'" + dg_inserir.Rows[x].Cells[y].Value.ToString() + "'";
                    }
                    else
                        if(y == (dg_inserir.Columns.Count - 1))
                        {
                            _SQL += ",'" + dg_inserir.Rows[x].Cells[y].Value.ToString() + "');";
                        }
                    else
                    {
                        _SQL += ",'" + dg_inserir.Rows[x].Cells[y].Value.ToString() + "'";
                    }
                }
                MessageBox.Show(_SQL);
                _SQL = "Insert into " + Program._UltimaTabelaSelecionada + " values(";
            }
            
        }
    }
}
