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
    public partial class Splash : Form
    {
        ControladorBanco ControlBD = new ControladorBanco();
        private string _OldConectStr = "";
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pg_carregando.Value >= 100)
            {
                timer1.Enabled = false;
                TelaDeLogin tl_login = new TelaDeLogin();
                tl_login.Show();
                this.Hide();
            }
            else
            {
                pg_carregando.Value += 10;
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            lb_versão.Text = Program._VersaoPrograma;
            System.Threading.Thread VerificaAtualizacao = new System.Threading.Thread(VerificaAtualizacoes);
            VerificaAtualizacao.Start();
        }

        public void VerificaAtualizacoes()
        {
            try
            {
                _OldConectStr = Program._ConectionStringMySql;
                Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
                ControlBD.Visualizador("Select * from tbl_atualizacoes ORDER BY data_atualizacao DESC;", 0);
                if (ControlBD._dataSet.Tables[0].Rows[0]["versao"].ToString() != Program._VersaoPrograma)
                {
                    if (MessageBox.Show("Existe uma nova versão deste programa para download.Você deseja efetuar o download agora?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\UpdaterMySqlToolCTG.exe");
                        this.Close();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
                Program._ConectionStringMySql = _OldConectStr;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }    
    }
}
