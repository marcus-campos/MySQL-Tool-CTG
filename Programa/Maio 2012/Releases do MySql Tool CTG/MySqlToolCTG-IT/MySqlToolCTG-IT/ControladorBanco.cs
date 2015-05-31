using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace MySqlToolCTG_IT
{
    class ControladorBanco
    {
        private DataTable dataTable = new DataTable();
        private ArrayList tabelaArray;
        private bool visualizadorErro = false;
        private List<string> visualizadorErroMSG = new List<string>();
        private bool modificadorErro = false;
        private List<string> modificadorErroMSG = new List<string>();
        
        public DataTable _dataTable
        {
            get { return dataTable; }
            set { dataTable = value; }
        }

        public ArrayList _tableaArray
        {
            get { return tabelaArray; }
            set { tabelaArray = value; }
        }

        public bool _visualizadorErro
        {
            get { return visualizadorErro; }
            set { visualizadorErro = value; }
        }

        public List<string> _visualizadorErroMSG
        {
            get { return visualizadorErroMSG; }
            set { visualizadorErroMSG = value; }
        }

        public bool _modificadorErro
        {
            get { return modificadorErro; }
            set { modificadorErro = value; }
        }

        public List<string> _modificadorErroMSG
        {
            get { return modificadorErroMSG; }
            set { modificadorErroMSG = value; }
        }
               

        public void Modificador(string _SQL, bool _enviarMSG = false, string _MSG = "Comando executado com sucesso!")
        {                   
            MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySql);
            try
            {
                objconexao.Open();
            }
            catch(Exception ex)
            {
                _modificadorErroMSG.Clear();
                _modificadorErro = true;
                _modificadorErroMSG.Add(ex.Message);
            }

            try
            {
               if (objconexao.State == ConnectionState.Open)
               {        
                    MySqlCommand CMD = new MySqlCommand(_SQL,objconexao);
                    CMD.ExecuteNonQuery();
                    if (_enviarMSG == true)
                    {
                        MessageBox.Show(_MSG, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    _modificadorErroMSG.Clear();
                    _modificadorErro = false;
                    _modificadorErroMSG.Clear();
               }
               else
               {
                   _modificadorErroMSG.Clear();
                   _modificadorErro = true;
                   _modificadorErroMSG.Add(DateTime.Now + ": " + "A conexão não pode ser estabelecida.");
               }
               objconexao.Close();
            }
            catch(Exception ex)
            {
                _modificadorErroMSG.Clear();
                _modificadorErro = true;
                _modificadorErroMSG.Add(DateTime.Now + ": " + ex.Message);
            }
        }

        public void Visualizador(string _SQL)
        {
            MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySql);
            try
            {
                objconexao.Open();
            }
            catch(Exception ex)
            {
                _visualizadorErroMSG.Clear();
                _visualizadorErro = true;
                _visualizadorErroMSG.Add(DateTime.Now+": "+ex.Message);
            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    _dataTable.Clear();
                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(_dataTable);
                    _visualizadorErroMSG.Clear();
                    _visualizadorErro = false;
                }
                catch (Exception ex)
                {
                    _visualizadorErroMSG.Clear();
                    _visualizadorErro = true;
                    _visualizadorErroMSG.Add(DateTime.Now + ": " + ex.Message);
                }
            }
            else
            {
                _visualizadorErroMSG.Clear();
                _visualizadorErro = true;
                _visualizadorErroMSG.Add(DateTime.Now + ": " + "A conexão não pode ser estabelecida.");
            }
            objconexao.Close();
        }

        public void GetBancoDeDados()
        {
            MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySql);
            try
            {
                //abre a conexão
                try
                {
                    objconexao.Open();
                }
                catch
                {
                    MessageBox.Show("Não foi possível estabelecer a conexão com o banco de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySqlDataAdapter objdatadapter = new MySqlDataAdapter("show databases;", objconexao);
                DataTable objdatable = new DataTable();
                objdatadapter.Fill(objdatable);
                //obtem informações do esquema (nome das tabelas do banco de dados)

                tabelaArray = new ArrayList();
                //preenche o array com  o nome das tabelas
                foreach (DataRow datRow in objdatable.Rows)
                {
                    tabelaArray.Add(datRow[0].ToString());
                }
                objconexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public void GetConexoesOnline()
        {
            MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySql);
            try
            {
                //abre a conexão
                try
                {
                    objconexao.Open();
                }
                catch
                {
                    MessageBox.Show("Não foi possível estabelecer a conexão com o banco de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MySqlDataAdapter objdatadapter = new MySqlDataAdapter("show databases;", objconexao);
                DataTable objdatable = new DataTable();
                objdatadapter.Fill(objdatable);
                //obtem informações do esquema (nome das tabelas do banco de dados)

                tabelaArray = new ArrayList();
                //preenche o array com  o nome das tabelas
                foreach (DataRow datRow in objdatable.Rows)
                {
                    tabelaArray.Add(datRow[0].ToString());
                }
                objconexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CriarBancoOff()
        {
            Modificador("");
        }
    }
}
