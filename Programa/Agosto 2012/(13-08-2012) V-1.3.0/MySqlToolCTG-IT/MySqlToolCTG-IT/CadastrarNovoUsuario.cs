using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Encriptografias;

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
            MySqlToolCTG_IT.ControladorAcces Controlar = new MySqlToolCTG_IT.ControladorAcces();
            Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();
            if (Controlar.VisualizadoresBooleanos("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(tb_login.Text) + "';") == true)
            {
                MessageBox.Show("Já existe um usuario com este nome.\nTente outro...", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Controlar.Modificadores("Insert into tbl_login (login,senha,email) values('" + Encriptografar.EncriptografarString(tb_login.Text) + "','" + Encriptografar.EncriptografarString(tb_senha.Text) + "','" + Encriptografar.EncriptografarString(tb_email.Text) + "');", true, "Usuário inserido com sucesso!", "Atenção!");
                this.Close();
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
