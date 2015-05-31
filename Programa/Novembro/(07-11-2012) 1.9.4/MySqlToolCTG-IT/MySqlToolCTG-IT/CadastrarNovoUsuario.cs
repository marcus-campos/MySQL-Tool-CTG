using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Encriptografias;
using System.Text.RegularExpressions;

namespace MySqlToolCTG_IT
{
    public partial class CadastrarNovoUsuario : Form
    {
        public CadastrarNovoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_confirmeSenha.Text == "" || tb_email.Text == "" || tb_login.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente para realizar o cadastro.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string email = tb_email.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            
            if (tb_senha.Text == tb_confirmeSenha.Text)
            {
                if (rg.IsMatch(email))
                {
                    MySqlToolCTG_IT.ControladorAcces Controlar = new MySqlToolCTG_IT.ControladorAcces();
                    Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();
                    if (Controlar.VisualizadoresBooleanos("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(tb_login.Text) + "';") == true)
                    {
                        MessageBox.Show("Já existe um usuario com este nome.\nTente outro...", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Controlar.Modificadores("Insert into tbl_login (login,senha,email,ultimo_acesso) values('" + Encriptografar.EncriptografarString(tb_login.Text) + "','" + Encriptografar.EncriptografarString(tb_senha.Text) + "','" + Encriptografar.EncriptografarString(tb_email.Text) + "',now());", true, "Usuário inserido com sucesso!", "Atenção!");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, informe um email válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
            }
            else
            {
                MessageBox.Show("As senhas nao coincidem, favor preencher corretamente os campos de senha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarNovoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
