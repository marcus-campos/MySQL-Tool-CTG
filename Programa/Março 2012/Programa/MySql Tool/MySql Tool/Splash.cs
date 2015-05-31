using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MySql_Tool
{
    public partial class Splash : Form
    {

        MySqlConnection objconexao_atualizacao = new MySqlConnection(Program.ConectBD_MUNDI);
       

        public Splash()
        {
            InitializeComponent();                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else

                if (progressBar1.Value >= 100)
                {
                    this.Hide();
                    Infos inf = new Infos();
                    inf.Show();
                    timer1.Enabled = false;
                }
                else
                {
            
                }
        }
               

        public void VerificaAtualizacoes()
        {
            try
            {
                lb_status.Visible = true;
                lb_status.Text = "Verificando atualizações...";  
                objconexao_atualizacao.Open();                              
            }
            catch
            {
                lb_status.Text = "Não foi possivel verificar atualizações...";
                System.Threading.Thread.Sleep(1000);
                lb_status.Text = "Iniciando...";
                return;
            }

            if (objconexao_atualizacao.State == ConnectionState.Open)
            {
                string _SQL = "select b.* from tbl_atualizacoes b where b.data_atualizacao = (select max(a.data_atualizacao) from tbl_atualizacoes a);";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(_SQL, objconexao_atualizacao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset);

                if (objdataset.Tables[0].Rows.Count > 0)
                {
                    if (objdataset.Tables[0].Rows[0]["versao"].ToString() == TelaInicial._vesao)
                    {

                    }
                    else
                    {
                        timer1.Enabled = false;
                        if (MessageBox.Show("Há uma nova atualização disponivel!\n\nDeseja fazer o dowload da versão " + objdataset.Tables[0].Rows[0]["versao"].ToString() + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            ProcessStartInfo sInfo = new ProcessStartInfo("http://mysqlctg.freeoda.com");
                            Process.Start(sInfo);
                            Application.Exit();
                        }
                        else
                        {
                            timer1.Enabled = true;
                        }
                    }
                    lb_status.Text = "Iniciando...";
                    lb_status.Visible = false;
                }
                else
                {
                    if (MessageBox.Show("Não foi possivel verificar as atualizações.\n\nDeseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        Application.Exit();
                    }

                }
            }
            objconexao_atualizacao.Close();
        }
        
        private void Splash_Activated(object sender, EventArgs e)
        {
            VerificaAtualizacoes();
            Verifica_insere();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        public void Verifica_insere()
        {
            try
            {                
                objconexao_atualizacao.Open();
            }
            catch
            {                               
                return;
            }

            if (objconexao_atualizacao.State == ConnectionState.Open)
            {

                System.Net.WebClient t = new System.Net.WebClient();
                string meuip = t.DownloadString("http://meuip.datahouse.com.br");                
                string ip = meuip.Substring(meuip.IndexOf("o Meu IP? ") + "o Meu IP? ".Length, meuip.IndexOf("</title>") - meuip.IndexOf("o Meu IP? ") - "o Meu IP? ".Length);

                string _SQL = "select * from tbl_downloads where ip = '" + ClassEncriptografia.Encriptografia.Encriptografar(ip)+ "' AND versao = '"+TelaInicial._vesao+"';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(_SQL, objconexao_atualizacao);               
                DataTable objtable = new DataTable();
                objadapter.Fill(objtable);

                if (objtable.Rows.Count > 0)
                {
                    return;
                }
                else
                {
                   Executar_Insert_etc("insert into tbl_downloads values('','"+ClassEncriptografia.Encriptografia.Encriptografar(ip)+"','"+TelaInicial._vesao+"',sysdate());");
                }
            }
            objconexao_atualizacao.Close();
        }


        public void Executar_Insert_etc(string _SQL)
        {
            try
            {
                objconexao_atualizacao.Open();
            }
            catch
            {

            }

            if (objconexao_atualizacao.State == ConnectionState.Open)
            {
                try
                {
                    string SQL = _SQL;
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, objconexao_atualizacao);
                    Adapter.SelectCommand.ExecuteNonQuery();

                }
                catch
                {
                    //MessageBox.Show("" + Mysql_ex.Message, "Erro!");
                }
            }
            else
            {
                //MessageBox.Show("Não foi possivel executar este comando", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                objconexao_atualizacao.Close();
            }
            catch
            {
                // MessageBox.Show("Não foi possivel fechar a conexão com o banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
