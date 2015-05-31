using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlToolCTG_IT;
using System.Data.OleDb;

namespace VerificaIndentidade
{
    class VERIFICA_USUARIOS
    {
        MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySqlOnline);
        OleDbConnection objconexaoAccess = new OleDbConnection(Program._ConectionStringAcces);

        public bool VerificaSeTemUsuarios(string login, string senha)
        {
            bool rtn = false;
            try
            {
                objconexao.Open();
            }
            catch
            {
               
            }

            if (objconexao.State == ConnectionState.Open)
            {
                string _SQL = "SELECT * FROM tbl_login WHERE login = '" + login + "' AND senha = '" + senha + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(_SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset);

                if (objdataset.Tables[0].Rows.Count > 0)
                {
                    rtn = true;
                }
                else
                {
                    rtn = false;
                }
            }
            objconexao.Close();
            return rtn;
        }

        public bool VerificaUsuariosAccess(string login, string senha)
        {
            bool rtn = false;
            try
            {
                objconexaoAccess.Open();
            }
            catch
            {
               
            }

            if (objconexaoAccess.State == ConnectionState.Open)
            {
                string _SQL = "SELECT * FROM tbl_login WHERE login = '" + login + "' AND senha = '" + senha + "';";
                OleDbDataAdapter objadapter = new OleDbDataAdapter(_SQL, objconexaoAccess);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset);

                if (objdataset.Tables[0].Rows.Count > 0)
                {
                    rtn = true;
                }
                else
                {
                    rtn = false;
                }
            }
             objconexaoAccess.Close();
            return rtn;
        }

        public bool VerificaEstadoConexaoMySql()
        {
            bool rtn = true;
            try
            {
                objconexao.Open();
                rtn = true;
            }
            catch
            {
                rtn = false;
            }
            objconexao.Close();            
            return rtn;
        }

        public bool VerificaEstadoConexaoAccess()
        {
            bool rtn = true;
            try
            {
                objconexaoAccess.Open();
                rtn = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel logar-se no sistema motivo: Nenhuma das conexões estao ativas.\n\n"+ex.Message,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                rtn = false;
            }
            objconexaoAccess.Close();  
            return rtn;
        }
    }
}
