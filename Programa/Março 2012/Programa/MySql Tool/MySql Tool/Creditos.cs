using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MySql_Tool
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
            labelVersion.Text = "Versão: "+TelaInicial.versao;
        }

        private void Creditos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://mysqlctg.freeoda.com");
            Process.Start(sInfo);
            this.Close();
        }
    }
}
