using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlToolCTG_IT;
using Encriptografias;

namespace Encriptografias
{
    class VERIFICA_USUARIOS
    {
        MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySql);
        ENCRIPTOGRAFAR_SENHAS encriptografar = new ENCRIPTOGRAFAR_SENHAS();

        public void VerificaSeTemUsuarios()
        {
            try
            {
                objconexao.Open();
            }
            catch
            {
                return;
            }

            if (objconexao.State == ConnectionState.Open)
            {
                string _SQL = "select * from tbl_usuario;";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(_SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset);

                if (objdataset.Tables[0].Rows.Count > 0)
                {

                }
                else
                {
                    try
                    {
                        string _senha = encriptografar.EncriptografarSenhas("");
                        MySqlCommand CMD = new MySqlCommand("insert into tbl_usuario values('','Administrador','admin','"+_senha+"',1,'livrotec-codigo-de-seguranca');", objconexao);
                        CMD.ExecuteNonQuery();
                    }
                    catch 
                    {
                        
                    }
                }
            }
        }
    }
}
