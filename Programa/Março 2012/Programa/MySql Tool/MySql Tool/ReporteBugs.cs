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

namespace MySql_Tool
{
    public partial class ReporteBugs : Form
    {
        public ReporteBugs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_email.Text == "" || cb_assunto.Text == "" || rtb_corpo.Text == "")
                {
                    MessageBox.Show("É necessário preencher todos os campos para concluir.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MailMessage menssagem = new MailMessage("mysqltoolctg@hotmail.com", "mysqltoolctg@hotmail.com", cb_assunto.Text, "De: " + tb_email.Text + "\n\n\n" + rtb_corpo.Text);
                    SmtpClient client = new SmtpClient("SMTP.live.com");
                    client.EnableSsl = true;
                    // Add credentials if the SMTP server requires them.
                    client.Credentials = new NetworkCredential("mysqltoolctg@hotmail.com", "7889dmg%");
                    client.Send(menssagem);
                    MessageBox.Show("Eviado com sucesso!\n\nObrigado por fazer contato conosco, estamos trabalhando o mais rapido possivel para lhe enviar uma resposta.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
