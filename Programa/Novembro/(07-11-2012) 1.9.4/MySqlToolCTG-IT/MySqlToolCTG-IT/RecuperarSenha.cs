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
using System.Security.Principal;

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
                if (x == 0)
                {
                    string senha = new String(letras).Substring(0, 4);
                    _senhaGerada += senha;
                }
                else
                {
                    string senha = new String(letras).Substring(4, 8);
                    _senhaGerada += senha;
                }
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
            System.Threading.Thread EnviarOEmail = new System.Threading.Thread(EnviarEmail);
            EnviarOEmail.Start();
        }

        public void EnviarEmail()
        {
            button1.Enabled = false;            
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
                        Controlar.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(tb_login.Text) + "';", 1);
                        int codigo = int.Parse(Controlar._VisualizadorMOD1);
                        Controlar.Modificadores("Update tbl_login set senha = '" + Encriptografar.EncriptografarString(_senhaGerada) + "' where codigo = " + codigo + ";", true, "Senha redefinida com sucesso!", "Atenção!");
                        lb_enviandoEmail.Text = "Enviando o email aguarde...";
                        MailMessage menssagem = null;
                        WindowsIdentity usu_Windows = WindowsIdentity.GetCurrent();
                        if (cb_ip.Checked == true)
                        {
                            menssagem = new MailMessage("resposta@toolctg.com.br", tb_email.Text, "Sua nova senha!", "Sua nova senha é: " + _senhaGerada + "\nEsta senha foi socilitada pelo ip: " + PegaIp() + "\nNome da maquina: " + Dns.GetHostName() + "\nNome do usuario da maquina: " + usu_Windows.Name);
                        }
                        else
                        {
                            menssagem = new MailMessage("resposta@toolctg.com.br", tb_email.Text, "Sua nova senha!", "Sua nova senha é: " + _senhaGerada + "\nNome da maquina: " + Dns.GetHostName() + "\nNome do usuario da maquina: " + usu_Windows.Name);
                        }

                        SmtpClient client = new SmtpClient("mail.toolctg.com.br");
                        client.EnableSsl = false;
                        // Add credentials if the SMTP server requires them.
                        client.Credentials = new NetworkCredential("resposta@toolctg.com.br", "XrmabE7CwZmM");
                        client.Send(menssagem);
                        lb_enviandoEmail.Text = "";
                        MessageBox.Show("Sua nova senha foi enviada para o email cadastrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email ou login invalidos, por favor tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string PegaIp()
        {
            string ip = "";
            try
            {
                System.Net.WebClient t = new System.Net.WebClient();
                string meuip = t.DownloadString("http://meuip.datahouse.com.br");
                ip = meuip.Substring(meuip.IndexOf("o Meu IP? ") + "o Meu IP? ".Length, meuip.IndexOf("</title>") - meuip.IndexOf("o Meu IP? ") - "o Meu IP? ".Length);
            }
            catch
            {
               return "Não foi possivel detectar o ip externo da maquina.";
            }
            return ip;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecuperarSenha_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
