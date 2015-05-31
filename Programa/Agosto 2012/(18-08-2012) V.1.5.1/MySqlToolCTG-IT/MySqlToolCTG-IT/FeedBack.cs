using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySqlToolCTG_IT
{
    public partial class FeedBack : Form
    {
        private string _OldConectStr = "";
        ControladorBanco controlarDB = new ControladorBanco();
        Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();

        public FeedBack()
        {
            InitializeComponent();
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {
            lb_versao.Text = Program._VersaoPrograma;
        }

        private void tk_nota_Scroll(object sender, EventArgs e)
        {
            lb_nota.Text = tk_nota.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok, lembrarei você mais tarde!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarFeedBack();
        }

        public void EnviarFeedBack()
        {
            _OldConectStr = Program._ConectionStringMySql;
            Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
            controlarDB.Modificador("Insert into tbl_feedback(nota,usuario,comentario,data_feedback,versao) values('"+tk_nota.Value+"','"+Encriptografar.EncriptografarString(Program._LoginUsuario)+"','"+rtb_comentario.Text+"',sysdate(),'"+Program._VersaoPrograma+"');", true, "FeedBack enviado com sucesso!");            
            Program._ConectionStringMySql = _OldConectStr;
            this.Close();
        }

        private void FeedBack_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FeedBack_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
