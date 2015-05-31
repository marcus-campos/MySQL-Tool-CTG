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
            ProcessStartInfo sInfo = new ProcessStartInfo("www.toolctg.com.br");
            Process.Start(sInfo);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            labelVersion.Text = "Versão: "+Program._VersaoPrograma;
            NotaVersao();
        }

        public void NotaVersao()
        {
            _OldConectStr = Program._ConectionStringMySql;
            Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
            controlarDB.Visualizador("Select Avg(nota) from tbl_feedback where versao = '"+Program._VersaoPrograma+"';", 1, "dg_dadosArmazenados");
            lb_notaVersao.Text = "Nota desta versão: "+ controlarDB._dataSet.Tables[0].Rows[0]["Avg(nota)"].ToString().Substring(0,3);
            Program._ConectionStringMySql = _OldConectStr;
        }
    }
}
