using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Encriptografias;

namespace MySqlToolCTG_IT
{
    public partial class CriarNovaConexao : Form
    {
        public CriarNovaConexao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nomeConexao.Text == "" || tb_ip.Text == "" || tb_porta.Text == "" || tb_usuario.Text == "" || tb_nomeBanco.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ControladorAcces CAcess = new ControladorAcces();
                ClasseDeEncriptografia Encriptografar = new ClasseDeEncriptografia();
                CAcess.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(Program._LoginUsuario) + "';", 1);

                if (CAcess.VisualizadoresBooleanos("Select * from tbl_conexoes where nome_conexao = '" + tb_nomeConexao.Text + "' and id_usuario = '" + CAcess._VisualizadorMOD1 + "';") == true)
                {
                    MessageBox.Show("Já existe uma conexão com este nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Program._LoginUsuario == "")
                    {
                        MessageBox.Show("O usuário não foi detectado, por favor tente novamente mais tarde!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        if (cb_banco.Checked == true)
                        {
                            CAcess.Modificadores("Insert into tbl_conexoes (nome_conexao,ip_conexao,usuario,senha,porta,id_usuario,data_atualizacao,nome_banco) values('" + tb_nomeConexao.Text + "','" + tb_ip.Text + "','" + tb_usuario.Text + "','" + tb_senha.Text + "','" + tb_porta.Text + "','" + int.Parse(CAcess._VisualizadorMOD1) + "',date(),'" + tb_nomeBanco.Text + "');", true, "Conexão criada com sucesso!", "Atenção!");
                            this.Close();
                        }
                        else
                        {
                            CAcess.Modificadores("Insert into tbl_conexoes (nome_conexao,ip_conexao,usuario,senha,porta,id_usuario,data_atualizacao,nome_banco) values('" + tb_nomeConexao.Text + "','" + tb_ip.Text + "','" + tb_usuario.Text + "','" + tb_senha.Text + "','" + tb_porta.Text + "','" + int.Parse(CAcess._VisualizadorMOD1) + "',date(),'mysql');", true, "Conexão criada com sucesso!", "Atenção!");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConectString(tb_ip.Text, tb_porta.Text, tb_nomeBanco.Text, tb_usuario.Text, tb_senha.Text);
            MySqlConnection Conect = new MySqlConnection(Program._ConectionStringMySql);
            try
            {
                Conect.Open();
                pgb_teste_conexao.Value = 50;
            }
            catch
            {               
                MessageBox.Show("Não foi possivel estabelecer uma conexão com o servidor.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pgb_teste_conexao.Value = 0;
            }

            if (Conect.State == ConnectionState.Open)
            {
                pgb_teste_conexao.Value += 50;
                MessageBox.Show("Conexão realizada com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ConectString(string Servidor, string porta, string database, string usuario, string senha)
        {
            Program._ConectionStringMySql = "Persist Security Info=False;server=" + Servidor + ";Port=" + porta + ";database=" + database + ";uid=" + usuario + ";pwd=" + senha + "";
        }

        private void cb_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_senha.Checked == true)
            {
                tb_senha.UseSystemPasswordChar = false;
            }
            else
            {
                tb_senha.UseSystemPasswordChar = true;
            }
        }

        private void CriarNovaConexao_Load(object sender, EventArgs e)
        {

        }

        private void cb_banco_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_banco.Checked == true)
            {
                tb_nomeBanco.Enabled = true;
                label6.Enabled = true;
            }
            else
            {
                tb_nomeBanco.Enabled = false;
                label6.Enabled = false;
            }
        }

    }
}
