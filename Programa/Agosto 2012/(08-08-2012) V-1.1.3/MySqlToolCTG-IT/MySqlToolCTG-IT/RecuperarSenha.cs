using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Encriptografias;

namespace MySqlToolCTG_IT
{
    public partial class RecuperarSenha : Form
    {
        Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();

        public RecuperarSenha()
        {
            InitializeComponent();
        }

        public string _senhaGerada = "";
        public void GeradorDeSenha()
        {
            string carac = "abcdefhijkmnopqrstuvxwyz123456789";

            char[] letras = carac.ToCharArray();
            Embaralhar(ref letras, 16);
            for (int x = 0; x <= 1; x++)
            {
                string senha = new String(letras).Substring(0, 4);
                _senhaGerada += senha;
            }

        }

        public static void Embaralhar(ref char[] array, int vezes)
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i <= vezes; i++)
            {
                for (int x = 1; x <= array.Length; x++)
                {
                    Trocar(ref array[rand.Next(0, array.Length)],
                      ref array[rand.Next(0, array.Length)]);
                }
            }
        }

        public static void Trocar(ref char arg1, ref char arg2)
        {
            char strTemp = arg1;
            arg1 = arg2;
            arg2 = strTemp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_email.Text == "" || tb_login.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos para concluir.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GeradorDeSenha();
                    MySqlToolCTG_IT.ControladorAcces Controlar = new MySqlToolCTG_IT.ControladorAcces();
                    Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();

                    if (Controlar.VisualizadoresBooleanos("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(tb_login.Text) + "';") == true && Controlar.VisualizadoresBooleanos("Select * from tbl_login where email = '" + Encriptografar.EncriptografarString(tb_email.Text) + "';") == true)
                    {
                        Controlar.Modificadores("Insert into tbl_login (senha) values('" + Encriptografar.EncriptografarString(_senhaGerada) + "');", true, "Usuário inserido com sucesso!", "Atenção!");

                        MailMessage menssagem = new MailMessage("resposta@toolctg.com.br", tb_email.Text, "Sua nova senha!", "Sua nova senha é: " + _senhaGerada);
                        SmtpClient client = new SmtpClient("mail.toolctg.com.br");
                        client.EnableSsl = false;
                        // Add credentials if the SMTP server requires them.
                        client.Credentials = new NetworkCredential("resposta@toolctg.com.br", "XrmabE7CwZmM");
                        client.Send(menssagem);
                        MessageBox.Show("Senha alterada com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha invalido, por favor tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
