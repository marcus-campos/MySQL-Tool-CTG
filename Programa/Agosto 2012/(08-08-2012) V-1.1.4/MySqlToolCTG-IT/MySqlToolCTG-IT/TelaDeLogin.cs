using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MySqlToolCTG_IT
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificaIndentidade.VERIFICA_USUARIOS Verifica = new VerificaIndentidade.VERIFICA_USUARIOS();
            Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();
           /* if (Verifica.VerificaEstadoConexaoMySql() == true)
            {
                if (Verifica.VerificaSeTemUsuarios(Encriptografar.EncriptografarString(tb_login.Text), Encriptografar.EncriptografarString(tb_login.Text)))
                {
                    System.Media.SoundPlayer Som = new System.Media.SoundPlayer(Directory.GetCurrentDirectory() + "//Sons//senhaConfirmada.wav");
                    Som.Play();
                    Program._LoginUsuario = tb_login.Text;
                    TelaPrincipal tl_pri = new TelaPrincipal();
                    tl_pri.Show();
                    this.Hide();
                }
                else
                {
                    System.Media.SoundPlayer Som = new System.Media.SoundPlayer(Directory.GetCurrentDirectory() + "//Sons//senhaErrada.wav");
                    MessageBox.Show("Usuário ou senha inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Som.Play();
                }
            }
            else*/
                if (Verifica.VerificaEstadoConexaoAccess() == true)
                {
                    if (Verifica.VerificaUsuariosAccess(Encriptografar.EncriptografarString(tb_login.Text), Encriptografar.EncriptografarString(tb_senha.Text)))
                    {
                        System.Media.SoundPlayer Som = new System.Media.SoundPlayer(Directory.GetCurrentDirectory() + "//Sons//senhaConfirmada.wav");
                        Som.Play();
                        Program._LoginUsuario = tb_login.Text;
                        TelaPrincipal tl_pri = new TelaPrincipal();
                        tl_pri.Show();
                        this.Hide();
                    }
                    else
                    {
                        System.Media.SoundPlayer Som = new System.Media.SoundPlayer(Directory.GetCurrentDirectory() + "//Sons//senhaErrada.wav");
                        Som.Play();
                        MessageBox.Show("Usuário ou senha inválido!","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
        }

        private void lb_cadastrarNovoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarNovoUsuario cnu = new CadastrarNovoUsuario();
            cnu.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarSenha rec_senha = new RecuperarSenha();
            rec_senha.ShowDialog();
        }
    }
}
