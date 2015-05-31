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
    public partial class TrocarSenha : Form
    {
        MySqlToolCTG_IT.ControladorAcces Controlar = new MySqlToolCTG_IT.ControladorAcces();
        Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();

        public TrocarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Controlar.VisualizadoresBooleanos("Select * from tbl_login where senha = '" + Encriptografar.EncriptografarString(tbsenhaAntiga.Text) + "';") == true)
            {
                if (tb_novaSenha.Text == tb_novaSenha2.Text)
                {
                    Controlar.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(Program._LoginUsuario) + "';", 1);
                    int codigo = int.Parse(Controlar._VisualizadorMOD1);
                    Controlar.Modificadores("Update tbl_login set senha = '" + Encriptografar.EncriptografarString(tb_novaSenha.Text) + "' where codigo = " + codigo + ";", true, "Senha alterada com sucesso!", "Atenção!");
                    TelaDeLogin tl_login = new TelaDeLogin();
                    tl_login.Show();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("As novas senhas não coincidem. Por favor corrija as senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
