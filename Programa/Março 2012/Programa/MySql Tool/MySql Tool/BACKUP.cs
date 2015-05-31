using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections;

namespace MySql_Tool
{
    public partial class BACKUP : Form
    {
        public ArrayList tabelaArray;
        MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
        public BACKUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog _saveOpn = new SaveFileDialog();
            _saveOpn.Filter = "Arquivo SQL (*.sql)|*.sql";
            _saveOpn.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (_saveOpn.ShowDialog(this) == DialogResult.OK)
            {
                tb_caminho.Text = _saveOpn.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BACKUP_Load(object sender, EventArgs e)
        {
            tb_caminho.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            PreencherTreeView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_caminho.Text == "")
                {
                    MessageBox.Show("Selecione o destino onde será salvo o Backup para continuar.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Process.Start(Directory.GetCurrentDirectory().ToString() + "\\mysqldump.exe", "-u root -p -B "+tb_bancoDeDados.Text+" > -r " + tb_caminho.Text + "");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void PreencherTreeView()
        {
            tv_bancoDeDados.Nodes.Clear();
            // define o no raiz para o TreeView.
            tv_bancoDeDados.Nodes.Add("Bancos de dados");
            tv_bancoDeDados.Nodes[0].ImageIndex = 0;
            tv_bancoDeDados.Nodes[0].SelectedImageIndex = 0;


            GetBancoDeDados();


            for (int i = 0; i < tabelaArray.Count; i++)
            {
                tv_bancoDeDados.Nodes[0].Nodes.Add(tabelaArray[i].ToString());
                tv_bancoDeDados.Nodes[0].Nodes[i].ImageIndex = 1;
                tv_bancoDeDados.Nodes[0].Nodes[i].SelectedImageIndex = 1;
            }

        }
        private void GetBancoDeDados()
        {

            try
            {
                //abre a conexão
                try
                {
                    objconexao.Open();
                }
                catch
                {

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

        private void tv_bancoDeDados_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tb_bancoDeDados.Text = tv_bancoDeDados.SelectedNode.Text;
            tb_caminho.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() +@"\"+ tb_bancoDeDados.Text+".sql";
        }
    }
}
