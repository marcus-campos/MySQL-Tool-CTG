using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MySqlToolCTG_IT
{
    public partial class MenuOpcoes : Form
    {
        Opcoes op = new Opcoes();
        OleDbConnection objconexao = new OleDbConnection(Program._ConectionStringAcces);        
        public MenuOpcoes()
        {
            InitializeComponent();
        }

        private void radioButton4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool LE_MJ = false;
            bool LE_ME = false;

            if (rb_listaErro_MJ_S.Checked == true)
            {
                LE_MJ = true;
            }
            else
            {
                LE_MJ = false;
            }
            if (rb_listaErro_ME_S.Checked == true)
            {
                LE_ME = true;
            }
            else
            {
                LE_ME = false;
            }

            ControladorAcces CAcess = new ControladorAcces();
            if (CAcess.VisualizadoresBooleanos("Select * from tbl_janelas where tipo = 1 AND funcao = 1;") == false)
            {
                CAcess.Visualizadores("Select codigo from tbl_login where usuario = '" + Program._LoginUsuario + "';", 1);
                CAcess.Modificadores("Insert into tbl_janelas (tipo,funcao,ativo,id_usuario) values(1,1,"+LE_MJ+","+int.Parse(CAcess._VisualizadorMOD1)+");");
            }
            else
            {
                CAcess.Visualizadores("Select codigo from tbl_login where usuario = '" + Program._LoginUsuario + "';", 1);
                CAcess.Modificadores("Update tbl_janelas set ativo = "+LE_MJ+" where tipo = 1 and funcao = 1 and id_usuario = "+int.Parse(CAcess._VisualizadorMOD1)+";");
            }

            if (CAcess.VisualizadoresBooleanos("Select * from tbl_janelas where tipo = 1 AND funcao = 2;") == false)
            {
                CAcess.Visualizadores("Select codigo from tbl_login where usuario = '" + Program._LoginUsuario + "';", 1);
                CAcess.Modificadores("Insert into tbl_janelas (tipo,funcao,ativo,id_usuario) values(1,2," + LE_ME + "," + int.Parse(CAcess._VisualizadorMOD1) + ");");
            }
            else
            {
                CAcess.Visualizadores("Select codigo from tbl_login where usuario = '" + Program._LoginUsuario + "';", 1);
                CAcess.Modificadores("Update tbl_janelas set ativo = " + LE_ME + " where tipo = 1 and funcao = 2 and id_usuario = " + int.Parse(CAcess._VisualizadorMOD1) + ";");
            }
        }

       
    }
}
