using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Diagnostics;


namespace MySql_Tool
{
    public partial class Infos : Form
    {
        public string banco_de_dados = "";
        public int seleciona_banco = 0;
        public static string ConectionString = "";
        public static int  _sugestaoWamp = 0;
        public static string _servidor = "";
        public static string _porta = "";
        public static string _usuario = "";
        public static string _senha = "";
        

        public Infos()
        {
            InitializeComponent();
               
        }

        private void Infos_Load(object sender, EventArgs e)
        {            
            lb_vercao_tela_pri.Text = TelaInicial.versao;            
            ExecutarQuery("Select * from tbl_downloads where versao = '"+TelaInicial._vesao+"';");
        }

        public void ExecutarQuery(string _SQL)
        {
            MySqlConnection objconexao = new MySqlConnection(Program.ConectBD_MUNDI);
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
                    DataSet objdataset = new DataSet();
                    objdataset.Clear();
                    DataTable Datable = new DataTable();
                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdataset);
                    objadapter.Fill(Datable);

                    if (Datable.Rows.Count > 0)
                    {
                        lb_total_downloads.Text = Datable.Rows.Count.ToString();
                    }
                }
                catch
                {
                    //MessageBox.Show("" + ex.Message, "Erro!");
                }
            }
            objconexao.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Infos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

       
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            string Servidor = tb_servidor.Text;
            
                if (tb_servidor.Text == "")
                {
                    Servidor = "localhost";
                }
                else
                    if (tb_usuario.Text == "")
                    {
                        MessageBox.Show("O campo 'Usuário' não foi preenchido corretamente!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                if (cb_incicarBD.Checked == true)
                {
                    ConectString(tb_servidor.Text, tb_porta.Text, tb_database.Text, tb_usuario.Text, tb_senha.Text);
                }
                else
                {
                    ConectString(tb_servidor.Text, tb_porta.Text, "mysql", tb_usuario.Text, tb_senha.Text);
                }
                InfosConection();
                button3.Enabled = true;
        }


        public void ConectString(string Servidor,string porta, string database,string usuario, string senha)
        {
            ConectionString = "Persist Security Info=False;server=" + Servidor + ";Port="+porta+";database="+ database +";uid=" + usuario + ";pwd=" + senha + "";            
            
        }


        private void button3_Click(object sender, EventArgs e)
        {        
            MySqlConnection Conect = new MySqlConnection(ConectionString);
            try
            {
                Conect.Open();
                pgb_teste_conexao.Value = 50;
            }
            catch
            {
                if (_sugestaoWamp == 0)
                {
                    if (MessageBox.Show("Não foi possivel conectar-se ao servidor!\n\nCaso você não tenha instalado um servidor MySQL em seu servidor(local ou online) uma otima opção seria o 'WAMP SERVER' deseja ir ao site para fazer o download?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        ProcessStartInfo sInfo = new ProcessStartInfo("http://sourceforge.net/projects/wampserver/files/WampServer%202/WampServer%202.1/WampServer2.1e-x32.exe/download");
                        Process.Start(sInfo);
                        _sugestaoWamp = 1;
                    }
                    else
                    {
                        _sugestaoWamp = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel criar uma conexão com o banco de dados?", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pgb_teste_conexao.Value = 0;
            }

            if (Conect.State == ConnectionState.Open)
            {
                pgb_teste_conexao.Value += 50;
                MessageBox.Show("Conexão realizada com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button4.Enabled = true;
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            TelaInicial tl_ini = new TelaInicial();
            tl_ini._nomeBD = banco_de_dados;
            tl_ini.Show();
            this.Hide();
        }

        public void InfosConection()
        {
            _servidor = tb_servidor.Text;
            _porta = tb_porta.Text;
            _usuario = tb_usuario.Text;
            _senha = tb_senha.Text;
        }

        private void tb_string_conexao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_database_Enter(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void tb_database_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            VER_BANCO_DE_DADOS ver_db = new VER_BANCO_DE_DADOS();
            ver_db.ShowDialog();           
        }

        private void ckb_mostra_senha_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckb_mostra_senha.Checked == true)
            {
                tb_senha.UseSystemPasswordChar = false;
            }
            else
            {
                tb_senha.UseSystemPasswordChar = true;
            }
        }

        private void cb_incicarBD_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_incicarBD.Checked == true)
            {
                tb_database.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                tb_database.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            VER_BANCO_DE_DADOS ver_bd = new VER_BANCO_DE_DADOS();
            ver_bd.ShowDialog();
        }

        
    }
}
