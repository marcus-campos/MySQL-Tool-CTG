using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MySql_Tool
{
    public partial class PREVIEW : Form
    {
        public string _triggerProcedurePrev = "";
        public Regex Syntaxes = new Regex("Select|select|Desc|desc|From|from|Show|show|Update|update|Delete|delete|"
                                         + "Use|use|Create|create|Table|table|Drop|drop|Trigger|trigger|Procedure|procedure|"
                                         + "Insert|insert|Into|into|Values|values|Varchar|varchar|Int|int|Integer|integer|Tynint|tynint|"
                                         + "Blob|blob|Text|text|Char|char|IF|if|If|Else|else|Double|>|<|=|'|'|(|)|double|Database|database|Set|set|Status|status|Where|where");

        public PREVIEW()
        {
            InitializeComponent();
        }

        private void PREVIEW_Load(object sender, EventArgs e)
        {
            CarregarPreview(_triggerProcedurePrev);
        }

        public void CarregarPreview(string procedure)
        {
            rtb_preview.Text = procedure;
        }

        private void rtb_preview_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int selPos = rtb_preview.SelectionStart;

            foreach (Match keyWordMatch in Syntaxes.Matches(rtb_preview.Text))
            {
                rtb_preview.Select(keyWordMatch.Index, keyWordMatch.Length);
                rtb_preview.SelectionColor = Color.Blue;
                rtb_preview.Select(selPos, 0);
                rtb_preview.SelectionColor = Color.Black;

            }
        }
    }
}
