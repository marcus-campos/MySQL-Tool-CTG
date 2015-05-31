using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MySqlToolCTG_IT
{
    public partial class Creditos : Form
    {
        private string _OldConectStr = "";
        ControladorBanco controlarDB = new ControladorBanco();
        public Creditos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            try
            {
                labelVersion.Text = "" + Program._VersaoPrograma;
                Control.CheckForIllegalCrossThreadCalls = false;
                System.Threading.Thread VerificaNotaVers = new System.Threading.Thread(NotaVersao);
                VerificaNotaVers.Start();
            }
            catch
            {

            }
        }

        public void NotaVersao()
        {
            try
            {
                _OldConectStr = Program._ConectionStringMySql;
                Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
                controlarDB.Visualizador("Select Avg(nota) from tbl_feedback where versao = '" + Program._VersaoPrograma + "';", 1, "dg_dadosArmazenados");
                lb_notaVersao.Text = "" + controlarDB._dataSet.Tables[0].Rows[0]["Avg(nota)"].ToString().Substring(0, 3);
                Program._ConectionStringMySql = _OldConectStr;
            }
            catch
            {
                lb_notaVersao.Text = "Nota da versão: NENHUMA AVALIAÇÂO REGISTRADA.";
            }
        }

        private void lb_notaVersao_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("www.toolctg.com.br");
            Process.Start(sInfo);
            this.Close();
        }

    }
}
