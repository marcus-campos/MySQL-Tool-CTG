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
    public partial class CRIAR_TRIGGER : Form
    {
        public CRIAR_TRIGGER()
        {
            InitializeComponent();
        }

        private void CRIAR_TRIGGER_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _trigger = "";
            _trigger = "CREATE TRIGGER " + tb_nome_trigger.Text + " " + cb_quando_ativa.Text + " " + cb_condicao.Text + " " + tb_on.Text + " " + tb_parametros.Text + "\n";
            _trigger += "FOR EACH ROW\n";
            _trigger += "BEGIN\n";
            _trigger += rtb_corpo_trigger.Text + "\n";
            _trigger += "END;\n";
            

            PREVIEW prev = new PREVIEW();
            prev._triggerProcedurePrev = _trigger;
            prev.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _trigger = "";
            _trigger = "CREATE TRIGGER " + tb_nome_trigger.Text + " " + cb_quando_ativa.Text + " " + cb_condicao.Text + " " + tb_on.Text + " " + tb_parametros.Text + "\n";
            _trigger += "FOR EACH ROW\n";
            _trigger += "BEGIN\n";
            _trigger += rtb_corpo_trigger.Text + "\n";
            _trigger += "END;\n";

            TriggersProcedures trg_proc = new TriggersProcedures();
            trg_proc._tiggersProceduresCMD = _trigger;

            trg_proc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
