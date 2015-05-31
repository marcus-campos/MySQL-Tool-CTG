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
    public partial class VER_BANCO_DE_DADOS : Form
    {
       
        DataSet objdataset = new DataSet();
        DataTable objdataTable = new DataTable();
        
        
        public VER_BANCO_DE_DADOS()
        {
            InitializeComponent();
        }

        private void VER_BANCO_DE_DADOS_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Infos inf = new Infos();
            inf.Show();
            this.Close();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }
       

        private void button3_Click(object sender, EventArgs e)
        {

            string ConectionString = "Persist Security Info=False;server=" + tb_servidor.Text + ";Port=" + tb_porta.Text + ";database=mysql" + ";uid=" + tb_usuario.Text + ";pwd=" + tb_senha.Text + "";
            MySqlConnection objconexao = new MySqlConnection(ConectionString);
            try
            {
                pgb_carregando.Value = 20;
                objconexao.Open();
            }
            catch
            {
                
                if (Infos._sugestaoWamp == 0)
                {
                    if (MessageBox.Show("Não foi possivel conectar-se ao servidor!\n\nCaso você não tenha instalado um servidor MySQL em seu servidor(local ou online) uma otima opção seria o 'WAMP SERVER' deseja ir ao site para fazer o download?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        ProcessStartInfo sInfo = new ProcessStartInfo("http://sourceforge.net/projects/wampserver/files/WampServer%202/WampServer%202.1/WampServer2.1e-x32.exe/download");
                        Process.Start(sInfo);
                        Infos._sugestaoWamp = 1;
                    }
                    else
                    {
                        Infos._sugestaoWamp = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel criar uma conexão com o banco de dados?", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pgb_carregando.Value = 0;
            }
            if (objconexao.State == ConnectionState.Open)
            {
                objdataTable.Clear();           
                MySqlDataAdapter objadapter = new MySqlDataAdapter("show databases;",ConectionString);
                pgb_carregando.Value += 20;
                objadapter.Fill(objdataset);
                pgb_carregando.Value += 20;
                objadapter.Fill(objdataTable);
                pgb_carregando.Value += 20;
                dg_banco_de_dados_presentes.DataSource = objdataTable;
                pgb_carregando.Value += 20;
                dg_banco_de_dados_presentes.AutoResizeColumns();
                lb_bancos_presentes.Text = dg_banco_de_dados_presentes.RowCount.ToString();
                
            }
        }

        private void ckb_mostra_senha_CheckedChanged(object sender, EventArgs e)
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

        private void dg_banco_de_dados_presentes_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dg_banco_de_dados_presentes_DoubleClick(object sender, EventArgs e)
        {
            
             Infos.ConectionString = "Persist Security Info=False;server=" + tb_servidor.Text + ";Port=" + tb_porta.Text + ";database=" + dg_banco_de_dados_presentes.CurrentCell.Value.ToString() + ";uid=" + tb_usuario.Text + ";pwd=" + tb_senha.Text + "";
            
             TelaInicial tl_ini = new TelaInicial();
             tl_ini._nomeBD = dg_banco_de_dados_presentes.CurrentCell.Value.ToString();
             tl_ini.Show();
             this.Close();

        }

        private void VER_BANCO_DE_DADOS_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}