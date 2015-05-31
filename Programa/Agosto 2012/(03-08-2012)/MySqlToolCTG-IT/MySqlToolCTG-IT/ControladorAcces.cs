using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace MySqlToolCTG_IT
{
    class ControladorAcces
    {
        OleDbConnection objconexao = new OleDbConnection(Program._ConectionStringAcces);
        OleDbCommand CMD;
        OleDbDataReader DTR;
        private DataTable dataTable;
        private DataSet dataSet;
        private string VisualizadorMOD1 = "";

        public DataTable _dataTable
        {
            get { return dataTable; }
            set { dataTable = value; }
        }

        public string _VisualizadorMOD1
        {
            get { return VisualizadorMOD1; }
            set { VisualizadorMOD1 = value; }
        }

        public DataSet _dataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }

        public void Modificadores(string _SQL,bool AtivarMSG = false, string MSG = "", string TituloMsg = "")
        {            
                try
                {
                    objconexao.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel estabelecer conexão com o arquivo de configurações.\n\nMotivo: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (objconexao.State == ConnectionState.Open)
                {
                    CMD = new OleDbCommand(_SQL, objconexao);
                    CMD.ExecuteNonQuery();
                    if (AtivarMSG == true)
                    {
                        MessageBox.Show(MSG, TituloMsg, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {

                }
                objconexao.Close();           
            
        }

        public bool VisualizadoresBooleanos(string _SQL)
        {
            bool rtn = false;
            try
            {
                objconexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer conexão com o arquivo de configurações.\n\nMotivo: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (objconexao.State == ConnectionState.Open)
            {
                CMD = new OleDbCommand(_SQL, objconexao);
                DTR = CMD.ExecuteReader();

                if (DTR.HasRows)
                {
                    rtn = true;
                }
                else
                {
                    rtn = false;
                }
                objconexao.Close();
            }
            else
            {
                objconexao.Close();
            }
            objconexao.Close();
            return rtn;           
        }

        public void Visualizadores(string _SQL, int _ModoOperacional = 0)
        {            
            try
            {
                objconexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer conexão com o arquivo de configurações.\n\nMotivo: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (objconexao.State == ConnectionState.Open)
            {
                if (_ModoOperacional == 0)
                {
                    OleDbDataAdapter objadapter = new OleDbDataAdapter(_SQL, objconexao);
                    _dataTable = new DataTable();
                    _dataSet = new DataSet();
                    objadapter.Fill(_dataTable);
                    objadapter.Fill(_dataSet);
                }
                else
                    if (_ModoOperacional == 1)
                    {
                        
                        OleDbDataAdapter objadapter = new OleDbDataAdapter(_SQL, objconexao);
                        objadapter.Fill(_dataSet = new DataSet("Visualizador"));

                        _VisualizadorMOD1 = _dataSet.Tables[0].Rows[0]["codigo"].ToString();
                    }               
            }
            else
            {
                objconexao.Close();
            }
            objconexao.Close();
            
        }
    }
}
