using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySql_Tool
{
    public partial class CRIAR_PROCEDURE : Form
    {
        public CRIAR_PROCEDURE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _procedure = "";
           
            _procedure = "CREATE PROCEDURE " + tb_nome_procedure.Text + "(" + tb_parametros.Text + ")\n";
            _procedure += "BEGIN\n";
            _procedure += rtb_corpo_procedure.Text + "\n";
            _procedure += "END;";

            PREVIEW prev = new PREVIEW();
            prev._triggerProcedurePrev = _procedure;
            prev.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _procedure = "";
            
            _procedure = "CREATE PROCEDURE " + tb_nome_procedure.Text + "(" + tb_parametros.Text + ")\n";
            _procedure += "BEGIN\n";
            _procedure += rtb_corpo_procedure.Text + "\n";
            _procedure += "END;";

            TriggersProcedures trg_proc = new TriggersProcedures();
            trg_proc._tiggersProceduresCMD = _procedure;

            trg_proc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
