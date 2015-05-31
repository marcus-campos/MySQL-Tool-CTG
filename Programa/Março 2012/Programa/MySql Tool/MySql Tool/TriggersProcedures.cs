using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MySql_Tool
{
    public partial class TriggersProcedures : Form
    {
       
        public static int comandoExecutado = 0;
        public string _tiggersProceduresCMD = "";
        MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);

        public Regex Syntaxes = new Regex("Select|select|Desc|desc|From|from|Show|show|Update|update|Delete|delete|"
                                         + "Use|use|Create|create|Table|table|Drop|drop|Trigger|trigger|Procedure|procedure|"
                                         + "Insert|insert|Into|into|Values|values|Varchar|varchar|Int|int|Integer|integer|Tynint|tynint|"
                                         + "Blob|blob|Text|text|Char|char|IF|if|If|Else|else|Double|>|<|=|'|'|(|)|double|Database|database|Set|set|Status|status|Where|where");

        public void CarregarTriggerProcedureComandos(string _stringTriggerProcedure)
        {
            rtb_comandos.Text = _stringTriggerProcedure;
        }
        public TriggersProcedures()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFileD = new SaveFileDialog();
            sFileD.Filter = "Arquivo de Texto (*.txt)|*.txt";
            if (sFileD.ShowDialog() == DialogResult.OK)
            {
                StreamWriter strW = new StreamWriter(sFileD.FileName);
                foreach (string linha in lsb_ultimos_comandos.Items)
                {
                    strW.Write(linha + "\r\n");
                }
                strW.Close();
            }
        }
        public void Executar_Insert_etc(string _SQL)
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
                    string SQL = _SQL;
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, objconexao);
                    Adapter.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Comando Executado com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comandoExecutado = 1;
                }
                catch (MySqlException Mysql_ex)
                {
                    MessageBox.Show("" + Mysql_ex.Message,"Erro!");

                    if (MessageBox.Show("Este comando conteve erros de sintaxe.\n\nDeseja adicionar este comando junto com os comandos de criação?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        comandoExecutado = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel estabelecer uma conexão com o banco de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            objconexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Executar_Insert_etc(rtb_comandos.Text);
                if (comandoExecutado == 1)
                {
                    lsb_ultimos_comandos.Items.Add(rtb_comandos.Text);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Color = Color.Black;
            fontDialog1.ShowApply = true;
            fontDialog1.Apply += new EventHandler(Aplicar_fonte);

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Pegar_Fonte(fontDialog1);
            }
        }
        private void Aplicar_fonte(object o, EventArgs ea)
        {
            Pegar_Fonte((FontDialog)o);
        }
        private void Pegar_Fonte(FontDialog fd)
        {
            this.rtb_comandos.Font = fd.Font;
            this.rtb_comandos.ForeColor = fd.Color;
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PESQUISA_MDI pes_rapd = new PESQUISA_MDI();
            pes_rapd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void triggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "" || lsb_ultimos_comandos.Items.Count > 0)
            {
                if (MessageBox.Show("Caso você deseje continuar esta ação as Querys digitadas ou já digitadas serão perdidas.\n\nDeseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CRIAR_TRIGGER cria_trigger = new CRIAR_TRIGGER();
                    cria_trigger.ShowDialog();
                }
                else
                {

                }
            }
            else
            {
                CRIAR_TRIGGER cria_trigger = new CRIAR_TRIGGER();
                cria_trigger.ShowDialog();
                            
            }
            
           
        }

        private void TriggersProcedures_Load(object sender, EventArgs e)
        {
          
            CarregarTriggerProcedureComandos(_tiggersProceduresCMD);
        }

        private void procedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void criarProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "" || lsb_ultimos_comandos.Items.Count > 0)
            {
                if (MessageBox.Show("Caso você deseje continuar esta ação as Querys digitadas ou já digitadas serão perdidas.\n\nDeseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CRIAR_PROCEDURE criar_proc = new CRIAR_PROCEDURE();
                    criar_proc.Show();
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                this.Close();

                CRIAR_PROCEDURE criar_proc = new CRIAR_PROCEDURE();
                criar_proc.Show();

            }
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
