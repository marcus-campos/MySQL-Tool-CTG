using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MySql_Tool
{
    public partial class Pesquisa : Form
    {
        
        MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
        DataSet objdataset = new DataSet();

        public Regex Syntaxes = new Regex("Select|select|Desc|desc|From|from|Show|show|Update|update|Delete|delete|"
                                         + "Use|use|Create|create|Table|table|Drop|drop|Trigger|trigger|Procedure|procedure|"
                                         + "Insert|insert|Into|into|Values|values|Varchar|varchar|Int|int|Integer|integer|Tynint|tynint|"
                                         + "Blob|blob|Text|text|Char|char|IF|if|If|Else|else|Double|>|<|=|'|'|(|)|double|Database|database|Set|set|Status|status|Where|where");

        public Pesquisa()
        {
            InitializeComponent();
        }

        private void Pesquisa_rapida_Load(object sender, EventArgs e)
        {
            ExecutarQuery_dgTables("Show tables;");
        }
        public void ExecutarQuery_dgTables(string _SQL)
        {
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    objdataset.Clear();
                    DataTable Datable = new DataTable();
                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdataset);
                    objadapter.Fill(Datable);

                    dataGrid_tabelas.DataSource = Datable;
                    dataGrid_tabelas.AutoResizeColumns();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("" + ex.Message,"Erro!");
                }
            }
            objconexao.Close();
        }

        private void dataGrid_tabelas_DoubleClick(object sender, EventArgs e)
        {
            int limite = 0;
            try
            {
                limite = int.Parse(tb_limite_registros.Text);
            }
            catch
            {
                MessageBox.Show("O valor inserido no limite de registros é inválido!","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            try
            {
                if (limite == 0)
                {
                    ExecutarQuery_dgDadosArmazenados("Select * from " + dataGrid_tabelas.CurrentCell.Value.ToString() + ";");
                    ExecutarQuery_dgDesc("Desc " + dataGrid_tabelas.CurrentCell.Value.ToString() + ";");
                }
                else
                {
                    ExecutarQuery_dgDadosArmazenados("Select * from " + dataGrid_tabelas.CurrentCell.Value.ToString() + " LIMIT " + limite + ";");
                    ExecutarQuery_dgDesc("Desc " + dataGrid_tabelas.CurrentCell.Value.ToString() + ";");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex,"Erro!");
            }
            
        }

        public void ExecutarQuery_dgDadosArmazenados(string _SQL)
        {
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    objdataset.Clear();
                    DataTable Datable = new DataTable();
                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdataset);
                    objadapter.Fill(Datable);

                    dataGrid_dadosArmazenados.DataSource = Datable;
                    dataGrid_dadosArmazenados.AutoResizeColumns();
                    lb_linhas_cmd.Text = dataGrid_dadosArmazenados.RowCount.ToString();
                    lb_colunas_cmd.Text = dataGrid_dadosArmazenados.ColumnCount.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("" + ex.Message,"Erro!");
                }
            }
            objconexao.Close();
        }

        public void ExecutarQuery_dgDesc(string _SQL)
        {
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    objdataset.Clear();
                    DataTable Datable = new DataTable();
                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdataset);
                    objadapter.Fill(Datable);

                    dataGrid_desc.DataSource = Datable;
                    dataGrid_desc.AutoResizeColumns();
                    lb_linhas_desc.Text = dataGrid_desc.RowCount.ToString();
                    lb_colunas_desc.Text = dataGrid_desc.ColumnCount.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("" + ex.Message,"Erro!");
                }
            }
            objconexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExecutarQuery_dgDadosArmazenados(rtb_comandos.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message,"Erro!");
            }
        }

        private void showTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {

                if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_comandos.Text = "Select * from";
                }
                else
                {

                }


            }
            else
            {
                rtb_comandos.Text = "Select * from";
            }
        }

        private void descToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {

                if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_comandos.Text = "Desc";
                }
                else
                {

                }


            }
            else
            {
                rtb_comandos.Text = "Desc";
            }
        }

        private void showTriggersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarQuery_dgDesc("Show Triggers;");
        }

        private void showProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarQuery_dgDesc("SHOW PROCEDURE STATUS");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void rtb_comandos_KeyDown(object sender, KeyEventArgs e)
        {
            int selPos = rtb_comandos.SelectionStart;

            foreach (Match keyWordMatch in Syntaxes.Matches(rtb_comandos.Text))
            {
                rtb_comandos.Select(keyWordMatch.Index, keyWordMatch.Length);
                rtb_comandos.SelectionColor = Color.Blue;
                rtb_comandos.Select(selPos, 0);
                rtb_comandos.SelectionColor = Color.Black;

            }
        }

        

        
    }
}
