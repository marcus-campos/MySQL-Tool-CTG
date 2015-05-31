using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Encriptografias;

namespace MySqlToolCTG_IT
{
    public partial class Sincronizador : Form
    {
        private string _OldConectStr = "";
        ControladorBanco ControladoresBD = new ControladorBanco();
        VerificaIndentidade.VERIFICA_USUARIOS Verifica = new VerificaIndentidade.VERIFICA_USUARIOS();
        Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();
        ControladorAcces CAaccess = new ControladorAcces();        
        public Sincronizador()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Verifica.VerificaSeTemUsuarios(tb_loginOnline.Text, tb_senhaOnline.Text))
            {                
                button2.Enabled = true;
                button3.Enabled = true;
                groupBox5.Enabled = false;
                VerificaRegistrosLocal();
                VerificaRegistrosOnline();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void VerificaRegistrosLocal()
        {
            ClasseDeEncriptografia Encriptografar = new ClasseDeEncriptografia();
            CAaccess.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(Program._LoginUsuario) + "';", 1);

            CAaccess.Visualizadores("select * from tbl_conexoes where id_usuario = '" + CAaccess._VisualizadorMOD1 + "';", 0);
            lb_registrosLocal.Text = CAaccess._dataTable.Rows.Count.ToString();

            if (CAaccess._dataTable.Rows.Count > 1)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
            
        }

        public void VerificaRegistrosOnline()
        {
            _OldConectStr = Program._ConectionStringMySql;
            Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
            ControladoresBD.Visualizador("Select * from tbl_conexoes where id_usuario = '" + Program._CodUsuOn + "';", 0);
            lb_registrosOnline.Text = ControladoresBD._dataTable.Rows.Count.ToString();

            if (ControladoresBD._dataTable.Rows.Count > 1)
            {
                button2.Enabled = true;
            }
            else 
            {
                button2.Enabled = false;
            }
            
            Program._ConectionStringMySql = _OldConectStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Sincronizador_Load(object sender, EventArgs e)
        {
            //tb_loginLocal.Text = Program._LoginUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ControladorAcces CAcess = new ControladorAcces();
            ClasseDeEncriptografia Encriptografar = new ClasseDeEncriptografia();
            CAcess.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(Program._LoginUsuario) + "';", 1);

            _OldConectStr = Program._ConectionStringMySql;
            Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
            ControladoresBD.Visualizador("Select * from tbl_conexoes where id_usuario = '" + Program._CodUsuOn + "';", 0);
                       

            for(int x = 0; x < ControladoresBD._dataTable.Rows.Count; x++)
            {
                if (CAcess.VisualizadoresBooleanos("Select * from tbl_conexoes where nome_conexao = '" + ControladoresBD._dataTable.Rows[x]["nome_conexao"] + "' and id_usuario = '" + CAcess._VisualizadorMOD1 + "';") == true)
                {
                    
                }
                else
                    {
                        CAcess.Modificadores("Insert into tbl_conexoes (nome_conexao,ip_conexao,usuario,senha,porta,id_usuario,data_atualizacao,nome_banco) values('" + ControladoresBD._dataTable.Rows[x]["nome_conexao"] + "','" + ControladoresBD._dataTable.Rows[x]["ip_conexao"] + "','" + ControladoresBD._dataTable.Rows[x]["usuario"] + "','" + ControladoresBD._dataTable.Rows[x]["senha"] + "','" + ControladoresBD._dataTable.Rows[x]["porta"] + "','" + int.Parse(CAcess._VisualizadorMOD1) + "','" + ControladoresBD._dataTable.Rows[x]["data_atualizacao"] + "','" + ControladoresBD._dataTable.Rows[x]["nome_banco"] + "');", false, "Conexão criada com sucesso!", "Atenção!");
                    }   
            }

            MessageBox.Show("Os registros foram armazenados no banco local com sucesso!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            VerificaRegistrosLocal();
            VerificaRegistrosOnline();
            Program._ConectionStringMySql = _OldConectStr;
          }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorAcces CAcess = new ControladorAcces();
                ClasseDeEncriptografia Encriptografar = new ClasseDeEncriptografia();
                if (Verifica.VerificaUsuariosAccess(Encriptografar.EncriptografarString(Program._LoginUsuario), Encriptografar.EncriptografarString(Microsoft.VisualBasic.Interaction.InputBox("Confirme a senha do usuario local:", "Atenção!", "", -1, -1))))
                {                   
                    //int CodigoUsuarioLocal = 0;

                    CAcess.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(Program._LoginUsuario) + "';", 1);

                    CAcess.Visualizadores("Select * from tbl_conexoes where id_usuario = '" + CAcess._VisualizadorMOD1 + "';", 0);



                    _OldConectStr = Program._ConectionStringMySql;
                    Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
                    int Registros = CAcess._dataTable.Rows.Count;

                    for (int x = 0; x < Registros; x++)
                    {
                        ControladoresBD.Visualizador("Select nome_conexao,id_usuario from tbl_conexoes where nome_conexao = '" + CAcess._dataTable.Rows[x]["nome_conexao"] + "' and id_usuario = '" + Program._CodUsuOn + "';", 0);
                        if (ControladoresBD._dataTable.Rows.Count > 0)
                        {

                        }
                        else
                        {
                            CAcess.Visualizadores("Select * from tbl_conexoes where id_usuario = '" + CAcess._VisualizadorMOD1 + "';", 0);
                            ControladoresBD.Modificador("Insert into tbl_conexoes (nome_conexao,ip_conexao,usuario,senha,porta,id_usuario,data_atualizacao,nome_banco) values('" + CAcess._dataTable.Rows[x]["nome_conexao"] + "','" + CAcess._dataTable.Rows[x]["ip_conexao"] + "','" + CAcess._dataTable.Rows[x]["usuario"] + "','" + CAcess._dataTable.Rows[x]["senha"] + "','" + CAcess._dataTable.Rows[x]["porta"] + "','" + Program._CodUsuOn + "',sysdate(),'" + CAcess._dataTable.Rows[x]["nome_banco"] + "');");
                        }
                    }

                    MessageBox.Show("Os registros foram armazenados no banco local com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerificaRegistrosLocal();
                    VerificaRegistrosOnline();
                    Program._ConectionStringMySql = _OldConectStr;
                }
                else
                {
                    MessageBox.Show("Senha incorreta!\nTente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
              
            }        
           
        }

        private void button3_ClientSizeChanged(object sender, EventArgs e)
        {

        }
        
        }
    }