using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Collections;
using System.Reflection;


namespace MySql_Tool
{
    public partial class TelaInicial : Form
    {
        MySqlConnection objconexao_bd = new MySqlConnection(Infos.ConectionString);
        DataSet objdataset = new DataSet();

        public string _nomeBD = "";
        public static string _vesao = "2.2.0";
        public static string versao = _vesao + " (Jaguatirica)";
        public string arquivoDados;
        public ArrayList tabelaArray;
        public ArrayList camposArray;
        public static int Tab_tabelasPesq = 0;
        public static string _NOME_TABELA_SELECT = "";
        public int _cancelarDelete = 0;
        public int _cancelarRepeticao = 0;
        /*
        public static DateTime ultimo_salvamento_comandos_criacao_data;
        public static DateTime ultimo_salvamento_comandos_criacao_hora;
        public static DateTime ultimo_salvamento_geral_data;
        public static DateTime ultimo_salvamento_geral_hora;
         */

       
       

       

        public TelaInicial()
        {
            InitializeComponent();          
        }


        public Regex Syntaxes = new Regex("Select|select|Desc|desc|From|from|Show|show|Update|update|Delete|delete|"
                                         +"Use|use|Create|create|Table|table|Drop|drop|Trigger|trigger|Procedure|procedure|"
                                         +"Insert|insert|Into|into|Values|values|Varchar|varchar|Int|int|Integer|integer|Tynint|tynint|"
                                         +"Blob|blob|Text|text|Char|char|IF|if|If|Else|else|Double|double|Database|database|Set|set|Status|status|Where|where|>|<|=|'|'|(|)");




        public static int comandoExecutado = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] split_for = rtb_comandos.Text.Split(new char[] { '<', '>' });
            string[] split_corpo = rtb_comandos.Text.Split(new char[] { '{', '}' });
            if (rtb_comandos.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    if (rtb_comandos.Text.ToUpper().Substring(0, 6) == "SELECT" || rtb_comandos.Text.ToUpper().Substring(0, 4) == "DESC" || rtb_comandos.Text.ToUpper().Substring(0, 4) == "SHOW")
                    {
                        ExecutarQuery(rtb_comandos.Text);
                        lsb_ultimos_comandos.Items.Add(rtb_comandos.Text);
                        comandoExecutado = 0;
                    }
                    else

                        if (rtb_comandos.Text.ToUpper().Substring(0, 6) == "REPITA")
                    {
                       
                        try
                        {
                            panel_for_cmd.Visible = true;
                            lb_forcmd_de.Visible = true;
                            lb_forcmd_deexecutando.Visible = true;
                            lb_forcmd_ex.Visible = true;
                            lb_forcmd_executando.Visible = true;
                            lb_forcmd_titulo.Visible = true;
                           
                            lb_delinha_executandoComando.Text = split_for[1];

                            for (int x = 0; x < double.Parse(split_for[1]); x++)
                            {
                                if (_cancelarRepeticao == 0)
                                {
                                    if (split_corpo[1].ToUpper().Substring(0, 6) == "SELECT" || split_corpo[1].ToUpper().Substring(0, 4) == "DESC" || split_corpo[1].ToUpper().Substring(0, 4) == "SHOW")
                                    {
                                        ExecutarQuery(split_corpo[1]);
                                        lsb_ultimos_comandos.Items.Add(rtb_comandos.Text);
                                        break;
                                    }
                                    else
                                    {
                                        panel_for_cmd.Refresh();
                                        lb_forcmd_de.Refresh();
                                        lb_forcmd_deexecutando.Refresh();
                                        lb_forcmd_ex.Refresh();
                                        lb_forcmd_executando.Refresh();
                                        lb_forcmd_titulo.Refresh();
                                        lb_forcmd_executando.Text = (x + 1).ToString();

                                        Executar_Insert_etc(split_corpo[1]);                                      
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (comandoExecutado == 1)
                            {
                                lsb_comandos_criacao.Items.Add(rtb_comandos.Text);
                                lsb_ultimos_comandos.Items.Add(rtb_comandos.Text);
                                comandoExecutado = 0;
                            }
                            else
                            {
                                comandoExecutado = 0;
                            }

                            panel_for_cmd.Visible = false;
                            lb_forcmd_de.Visible = false;
                            lb_forcmd_deexecutando.Visible = false;
                            lb_forcmd_ex.Visible = false;
                            lb_forcmd_executando.Visible = false;
                            lb_forcmd_titulo.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            panel_for_cmd.Visible = false;
                            lb_forcmd_de.Visible = false;
                            lb_forcmd_deexecutando.Visible = false;
                            lb_forcmd_ex.Visible = false;
                            lb_forcmd_executando.Visible = false;
                            lb_forcmd_titulo.Visible = false;
                            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Executar_Insert_etc(rtb_comandos.Text);

                        if (comandoExecutado == 1)
                        {
                            lsb_comandos_criacao.Items.Add(rtb_comandos.Text);
                            lsb_ultimos_comandos.Items.Add(rtb_comandos.Text);
                            comandoExecutado = 0;
                        }
                        else
                        {
                            comandoExecutado = 0;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Este comando não e valido tente novamente.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            
           
        }

        public void ExecutarQuery(string _SQL)
        {
            MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    objdataset.Clear();
                    DataTable Datable = new DataTable();
                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdataset);
                    objadapter.Fill(Datable);
                    
                    dg_comandos.DataSource = Datable;
                    dg_comandos.AutoResizeColumns();
                    lb_linhas.Text = dg_comandos.RowCount.ToString();
                    lb_colunas.Text = dg_comandos.ColumnCount.ToString();
                 }
                catch (MySqlException ex)
                {
                    MessageBox.Show("" + ex.Message,"Erro!");
                }
            }
            objconexao.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void ApplyFont(object o, EventArgs ea)
        {
            ChangeFont((FontDialog)o);
        }
        private void ChangeFont(FontDialog fd)
        {
            this.rtb_comandos.Font = fd.Font;
            this.rtb_comandos.ForeColor = fd.Color;
        }
        public int _abaPrincipal = 0;
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            tv_bd.ImageList = img_list;
            tsl_vercao.Text = versao;
            PreencherTreeView();
            lv_tabelas.SmallImageList = img_list;
            lv_tabelas.Clear();
            tabControl_principal.TabPages.Remove(this.tab_cmds);
            tabControl_principal.TabPages.Remove(this.tab_tabelasPesq);
            _abaPrincipal = 1;
            this.KeyPreview = true;
        }


        public void ExecutarQuery_dgDadosArmazenados(string _SQL)
        {
            MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {

                    DataSet objdatasetLocal = new DataSet();

                    objdatasetLocal.Clear();

                    string SQL = _SQL;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdatasetLocal,"Dados");

                    dataGrid_dadosArmazenados.DataSource = objdatasetLocal;
                    dataGrid_dadosArmazenados.DataMember = "Dados";
                    dataGrid_dadosArmazenados.AutoResizeColumns();
                    lb_linhas_cmd.Text = dataGrid_dadosArmazenados.RowCount.ToString();
                    lb_colunas_cmd.Text = dataGrid_dadosArmazenados.ColumnCount.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("" + ex.Message, "Erro!");
                }
            }
            objconexao.Close();
        }


        private void GetBancoDeDados()
        {
            
            try
            {
                //abre a conexão
                try
                {
                    objconexao_bd.Open();
                }
                catch
                {

                }
                MySqlDataAdapter objdatadapter = new MySqlDataAdapter("show databases;", objconexao_bd);
                DataTable objdatable = new DataTable();
                objdatadapter.Fill(objdatable);
                //obtem informações do esquema (nome das tabelas do banco de dados)
               
                tabelaArray = new ArrayList();
                //preenche o array com  o nome das tabelas
                foreach (DataRow datRow in objdatable.Rows)
                {
                    tabelaArray.Add(datRow[0].ToString());
                }
                objconexao_bd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ExecutarQuery_CMDs(string _sql)
        {
            MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    objdataset.Clear();
                    DataTable Datable = new DataTable();
                    string SQL = _sql;
                    MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                    objadapter.Fill(objdataset);
                    objadapter.Fill(Datable);

                    dataGrid_desc.DataSource = Datable;
                    dataGrid_desc.AutoResizeColumns();
                    lb_linhas.Text = dg_comandos.RowCount.ToString();
                    lb_colunas.Text = dg_comandos.ColumnCount.ToString();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("" + ex.Message, "Erro!");
                }
            }
            objconexao.Close();
        }
        public void CarregaTables()
        {
            MySqlConnection objconexao1 = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao1.Open();
            }
            catch
            {

            }
            
                lv_tabelas.Clear();
                string _sql = "show tables;";
                MySqlCommand cmd = new MySqlCommand(_sql, objconexao1);
                MySqlDataAdapter objadapter = new MySqlDataAdapter(_sql, objconexao1);
                MySqlDataReader objdatareader = cmd.ExecuteReader();


                // Preenche o ListView
                while (objdatareader.Read())
                {
                    ListViewItem objListItem = new ListViewItem(objdatareader.GetValue(0).ToString());
                    for (int c = 1; c < objdatareader.FieldCount; c++)
                    {
                        objListItem.SubItems.Add(objdatareader.GetValue(c).ToString());
                    }
                    objListItem.ImageIndex = 2;
                    lv_tabelas.Items.Add(objListItem);
                }
                //fecha o datareader e a conexa
            objdatareader.Close();            
            objconexao1.Close();
        }

        private void PreencherTreeView()
        {
            tv_bd.Nodes.Clear();
            // define o no raiz para o TreeView.
            tv_bd.Nodes.Add("Bancos de dados");
            tv_bd.Nodes[0].ImageIndex = 0;
            tv_bd.Nodes[0].SelectedImageIndex = 0;


            GetBancoDeDados();
            
                       
            for (int i = 0; i < tabelaArray.Count; i++)
            {
                tv_bd.Nodes[0].Nodes.Add(tabelaArray[i].ToString());
                tv_bd.Nodes[0].Nodes[i].ImageIndex = 1;
                tv_bd.Nodes[0].Nodes[i].SelectedImageIndex = 1;
            }
            
        }

        public void Executar_Insert_etc(string _SQL, int _ativamsg = 0)
        {
            MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    string SQL = _SQL;
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, objconexao);
                    Adapter.SelectCommand.ExecuteNonQuery();
                    if (_ativamsg == 0)
                    {
                        MessageBox.Show("Comando Executado com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                    }
                    comandoExecutado = 1;
                }
                catch (MySqlException Mysql_ex)
                {
                    MessageBox.Show("" + Mysql_ex.Message,"Erro!");

                    if (MessageBox.Show("Este comando conteve erros de sintaxe.\n\nDeseja adicionar este comando junto com os comandos de criação?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        comandoExecutado = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel executar este comando", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                objconexao.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possivel fechar a conexão com o banco de dados!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void Executar_Inserts_CMDs(string _SQL, int _ativa = 0)
        {
            MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao.Open();
            }
            catch
            {

            }

            if (objconexao.State == ConnectionState.Open)
            {
                try
                {
                    string SQL = _SQL;
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, objconexao);
                    Adapter.SelectCommand.ExecuteNonQuery();
                    if (_ativa == 0)
                    {
                        MessageBox.Show("Comando Executado com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
                catch (MySqlException Mysql_ex)
                {
                    MessageBox.Show("" + Mysql_ex.Message, "Erro!");
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel executar este comando", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                objconexao.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possivel fechar a conexão com o banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lsb_ultimos_comandos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rtb_comandos.Text != "")
                {
                    if (lsb_ultimos_comandos.SelectedItem.ToString() == rtb_comandos.Text)
                    {

                    }
                    else
                    {
                        if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            rtb_comandos.Text = lsb_ultimos_comandos.SelectedItem.ToString();
                        }
                        else
                        {

                        }
                    }

                }
                else
                {
                    rtb_comandos.Text = lsb_ultimos_comandos.SelectedItem.ToString();
                }
            }
            catch
            {

            }
         }

        private void dg_comandos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dg_comandos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dg_comandos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sFileD = new SaveFileDialog();
                sFileD.Filter = "Arquivo de Texto (*.txt)|*.txt";
                if (sFileD.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter strW = new StreamWriter(sFileD.FileName);
                    foreach (string linha in lsb_ultimos_comandos.Items)
                    {
                        strW.Write(linha + "\r\n");
                    }
                    strW.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel salvar este arquivo!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lsb_ultimos_comandos.SelectedItem = null;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sFileD = new SaveFileDialog();
                sFileD.Filter = "Arquivo de Texto (*.txt)|*.txt";
                if (sFileD.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter strW = new StreamWriter(sFileD.FileName);
                    foreach (string linha in lsb_comandos_criacao.Items)
                    {
                        strW.Write(linha + "\r\n");
                    }
                    strW.Close();

                }         
            }
            catch
            {
                MessageBox.Show("Não foi possivel salvar este arquivo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

       

        }

        private void lsb_comandos_criacao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {
                if (lsb_comandos_criacao.SelectedItem.ToString() == rtb_comandos.Text)
                {

                }
                else
                {
                    if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rtb_comandos.Text = lsb_comandos_criacao.SelectedItem.ToString();
                    }
                    else
                    {

                    }
                }

            }
            else
            {
                rtb_comandos.Text = lsb_comandos_criacao.SelectedItem.ToString();
            }
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creditos ab = new Creditos();
            ab.ShowDialog();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            fontDialog1.Color = Color.Black;
            fontDialog1.ShowApply = true;
            fontDialog1.Apply += new EventHandler(ApplyFont);

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ChangeFont(fontDialog1);
            }
        }

        private void tiriggersProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TriggersProcedures tg_sp = new TriggersProcedures();
            tg_sp.ShowDialog();
        }

        private void showTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarQuery("Show tables;");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsl_data.Text = DateTime.Now.ToLongDateString();
            tsl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void selectFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {
                
                    if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rtb_comandos.Text = "Select * from";
                    }
                    else
                    {

                    }
            }
            else
            {
                rtb_comandos.Text = "Select * from";
            }
        }

        private void descToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {

                if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_comandos.Text = "Desc";
                }
                else
                {

                }


            }
            else
            {
                rtb_comandos.Text = "Desc";
            }
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {

                if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_comandos.Text = "Drop table";
                }
                else
                {

                }


            }
            else
            {
                rtb_comandos.Text = "Drop table";
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {

                if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_comandos.Text = "Drop database";
                }
                else
                {

                }


            }
            else
            {
                rtb_comandos.Text = "Drop database";
            }
        }

        private void insertIntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text != "")
            {

                if (MessageBox.Show("Caso você continue esta ação os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtb_comandos.Text = "Insert into";
                }
                else
                {

                }


            }
            else
            {
                rtb_comandos.Text = "Insert into";
            }

        
        
        
        
        
        }

        private void dg_comandos_DoubleClick(object sender, EventArgs e)
        {
            rtb_comandos.Text += dg_comandos.CurrentCell.Value.ToString();
        }

        private void pesquisaRapidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PESQUISA_MDI pesq_rapd = new PESQUISA_MDI();
            pesq_rapd.Show();
        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void escolherOutroBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja selecionar outro banco de dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {

            }
        }

        

        private void TelaInicial_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair do programa?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void showTriggersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarQuery("SHOW TRIGGERS;");
        }

        private void showProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarQuery("SHOW PROCEDURE STATUS;");
        }

        private void TelaInicial_FormClosed(object sender, FormClosedEventArgs ex)
        {
          
        }

        private void REGEX_Tick(object sender, EventArgs e)
        {          


        }

        private void TelaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    TriggersProcedures tg_sp = new TriggersProcedures();
                    tg_sp.ShowDialog();
                    break;
                case Keys.F2:
                     PESQUISA_MDI pesq_rapd = new PESQUISA_MDI();
                     pesq_rapd.Show();
                    break;
                case Keys.F3:
                     tabControl_principal.TabPages.Add(this.tab_cmds);
                     tabControl_principal.SelectTab(tab_cmds);
                     toolStripSeparator5.Visible = true;
                     comandosToolStripMenuItem.Visible = true;
                    break;
                case Keys.F4:
                   BACKUP backup = new BACKUP();
                   backup.ShowDialog();
                    break;
                case Keys.Escape:
                    if (MessageBox.Show("Você deseja selecionar outro banco de dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {

                    }
                    break;                
            }
        }

        private void TelaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rtb_comandos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void REGEX_Tick_1(object sender, EventArgs e)
        {            
                  
        }

        private void tv_bd_AfterExpand(object sender, TreeViewEventArgs e)
        {
            
        }

        private void tv_bd_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tv_bd.SelectedNode.Text == "Bancos de dados")
                {
                    return;
                }
                else
                {
                    _nomeBD = tv_bd.SelectedNode.Text;
                    this.Text = "MySql Tool CTG | Banco de dados selecionado: " + _nomeBD;
                    tv_bd.SelectedNode.SelectedImageIndex = 3;
                    //tv_bd.SelectedNode.SelectedImageKey = 3;
                    Infos inf = new Infos();
                    inf.ConectString(Infos._servidor, Infos._porta, _nomeBD, Infos._usuario, Infos._senha);
                    CarregaTables();
                }
            }
            catch
            {

            }
        
        }
        
        private void lv_tabelas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Tab_tabelasPesq == 0)
                {
                    dataGrid_dadosArmazenados.Rows.Clear();
                    dataGrid_dadosArmazenados.DataSource = null;
                    dataGrid_dadosArmazenados.DataMember = null;
                    tabControl_principal.TabPages.Add(this.tab_tabelasPesq);
                    tabControl_principal.SelectTab(tab_tabelasPesq);
                    _NOME_TABELA_SELECT = lv_tabelas.SelectedItems[0].Text;
                    tab_tabelasPesq.Text = "Tabela: " + _NOME_TABELA_SELECT;
                    ExecutarQuery_dgDadosArmazenados("Select * from " + lv_tabelas.SelectedItems[0].Text);
                    ExecutarQuery_CMDs("Desc " + _NOME_TABELA_SELECT);
                    Tab_tabelasPesq = 1;
                }
                else
                {
                    ExecutarQuery_dgDadosArmazenados("Select * from " + lv_tabelas.SelectedItems[0].Text);
                    tabControl_principal.TabPages.Remove(this.tab_tabelasPesq);
                    tabControl_principal.TabPages.Add(this.tab_tabelasPesq);
                    tabControl_principal.SelectTab(tab_tabelasPesq);
                    _NOME_TABELA_SELECT = lv_tabelas.SelectedItems[0].Text;
                    tab_tabelasPesq.Text = "Tabela: " + _NOME_TABELA_SELECT;
                    ExecutarQuery_CMDs("Desc " + _NOME_TABELA_SELECT);
                }
            }
            catch
            {

            }
        }

        private void tv_bd_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS_BANCOSdeDADOS.Show(MousePosition.X, MousePosition.Y);
            }
        }

      
        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreencherTreeView();
            tv_bd.Nodes[0].Expand();
        }
        

        private void lv_tabelas_DragDrop(object sender, DragEventArgs e)
        {
            //Return if the items are not selected in the ListView control.
            if (lv_tabelas.SelectedItems.Count == 0)
            {
                return;
            }
            //Returns the location of the mouse pointer in the ListView control.
            Point cp = lv_tabelas.PointToClient(new Point(e.X, e.Y));
            //Obtain the item that is located at the specified location of the mouse pointer.
            ListViewItem dragToItem = lv_tabelas.GetItemAt(cp.X, cp.Y);
            if (dragToItem == null)
            {
                return;
            }
            //Obtain the index of the item at the mouse pointer.
            int dragIndex = dragToItem.Index;
            ListViewItem[] sel = new ListViewItem[lv_tabelas.SelectedItems.Count];
            for (int i = 0; i <= lv_tabelas.SelectedItems.Count - 1; i++)
            {
                sel[i] = lv_tabelas.SelectedItems[i];
            }
            for (int i = 0; i < sel.GetLength(0); i++)
            {
                //Obtain the ListViewItem to be dragged to the target location.
                ListViewItem dragItem = sel[i];
                int itemIndex = dragIndex;
                if (itemIndex == dragItem.Index)
                {
                    return;
                }
                if (dragItem.Index < itemIndex)
                    itemIndex++;
                else
                    itemIndex = dragIndex + i;
                //Insert the item at the mouse pointer.
                ListViewItem insertItem = (ListViewItem)dragItem.Clone();
                lv_tabelas.Items.Insert(itemIndex, insertItem);
                //Removes the item from the initial location while 
                //the item is moved to the new location.
                lv_tabelas.Items.Remove(dragItem);
            }
        }

        private void lv_tabelas_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lv_tabelas.DoDragDrop(lv_tabelas.SelectedItems, DragDropEffects.Move);
        }

        private void lv_tabelas_DragEnter(object sender, DragEventArgs e)
        {
            int len = e.Data.GetFormats().Length - 1;
            int i;
            for (i = 0; i <= len; i++)
            {
                if (e.Data.GetFormats()[i].Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection"))
                {
                    //The data from the drag source is moved to the target.	
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void deletarBancoSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv_bd.SelectedNode.Text == "Bancos de dados")
            {
                return;
            }
            if (MessageBox.Show("Você tem certesa que deseja excluir o banco de dados selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ExecutarCMDs("Drop database " + tv_bd.SelectedNode.Text + ";","",1);
                PreencherTreeView();
                tv_bd.Nodes[0].Expand();
            }
            else
            {

            }
        }

        private void lv_tabelas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS_TABELAS.Show(MousePosition.X,MousePosition.Y);
            }
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CarregaTables();
        }

        private void deletarTabelaSelecionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_tabelas.SelectedItems.Count > 1)
            {
                MessageBox.Show("Desculpe mais você so pode deletar 1 item por vez!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
                if (lv_tabelas.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Selecione 1 item para ser deletado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ExecutarCMDs("Drop table " + lv_tabelas.SelectedItems[0].Text + ";","",1);
                }
        }

        private void TelaInicial_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                NOTI_ICON.BalloonTipTitle = "MySQL Tool CTG";
                NOTI_ICON.BalloonTipText = "MySQL Tool CTG foi minimizado.\n1 icone de notificação foi adicionado na barra de tarefas.\nPara abri-lo novamente clique 2x sobre o icone de notificação ou clique sobre esta menssagem.";
                NOTI_ICON.Text = "MySQL Tool CTG | Clique 2x para abrir";
                NOTI_ICON.ShowBalloonTip(7000);
                Hide();
            }
        }

        private void NOTI_ICON_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                NOTI_ICON.BalloonTipTitle = "MySQL Tool CTG";
                NOTI_ICON.BalloonTipText = "MySQL Tool CTG";
                NOTI_ICON.Text = "MySQL Tool CTG";
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair do MySQL Tool CTG?!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void NOTI_ICON_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS_NOTICON.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void creditosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {

            }
        }

        private void CMS_NOTICON_Opening(object sender, CancelEventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var linhas = dataGrid_dadosArmazenados.SelectedRows.Count;
            if (MessageBox.Show("Registros selecionados: "+linhas+"\n\nVocê realmente deseja deletar o(s) registro(s) selecionado(s)?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dataGrid_dadosArmazenados.SelectedRows.Count == 1)
                {
                    string _SQL = "DELETE FROM " + _NOME_TABELA_SELECT + " WHERE";
                    for (int x = 0; x < dataGrid_dadosArmazenados.ColumnCount; x++)
                    {
                        if (x == 0)
                        {
                            _SQL += " " + dataGrid_dadosArmazenados.Columns[x].Name + " = " + "'" + dataGrid_dadosArmazenados.SelectedRows[0].Cells[x].Value.ToString() + "'";
                        }
                        else
                        {
                            _SQL += " AND " + dataGrid_dadosArmazenados.Columns[x].Name + " = " + "'" + dataGrid_dadosArmazenados.SelectedRows[0].Cells[x].Value.ToString() + "'";
                        }
                    }
                    ExecutarCMDs(_SQL, linhas+" registro(s) deletado(s) com sucesso!",1);
                    ExecutarQuery_dgDadosArmazenados("Select * from " + _NOME_TABELA_SELECT);
                }
                else
                {
                    panel_delete.Visible = true;
                    lb_executando_delete1.Visible = true;
                    lb_executando_delete2.Visible = true;
                    lb_deexecutando_delete.Visible = true;
                    lb_executando_delete.Visible = true;
                    label15.Visible = true;
                    //linkLabel1.Visible = true;
                    lb_deexecutando_delete.Text = dataGrid_dadosArmazenados.SelectedRows.Count.ToString();

                    string _SQL = "DELETE FROM " + _NOME_TABELA_SELECT + " WHERE";
                    for (int i = 0; i < dataGrid_dadosArmazenados.SelectedRows.Count; i++)
                    {
                        if (_cancelarDelete == 0)
                        {
                            for (int x = 0; x < dataGrid_dadosArmazenados.ColumnCount; x++)
                            {
                                if (x == 0)
                                {
                                    _SQL += " " + dataGrid_dadosArmazenados.Columns[x].Name + " = " + "'" + dataGrid_dadosArmazenados.SelectedRows[i].Cells[x].Value.ToString() + "'";
                                }
                                else
                                {
                                    _SQL += " AND " + dataGrid_dadosArmazenados.Columns[x].Name + " = " + "'" + dataGrid_dadosArmazenados.SelectedRows[i].Cells[x].Value.ToString() + "'";
                                }
                            }
                            ExecutarCMDs(_SQL, linhas + " registro(s) deletado(s) com sucesso!", 1);
                            _SQL = "DELETE FROM " + _NOME_TABELA_SELECT + " WHERE";

                            lb_executando_delete.Text = (i + 1).ToString();
                            lb_executando_delete.Refresh();
                            lb_executando_delete1.Refresh();
                            lb_executando_delete2.Refresh();
                            lb_executando_delete.Refresh();
                            label15.Refresh();
                            //linkLabel1.Refresh();
                            lb_deexecutando_delete.Refresh();
                        }
                        else
                        {
                            break;                            
                        }

                    }
                    panel_delete.Visible = false;
                    lb_executando_delete1.Visible = false;
                    lb_executando_delete2.Visible = false;
                    lb_deexecutando_delete.Visible = false;
                    lb_executando_delete.Visible = false;
                    //linkLabel1.Visible = false;
                    ExecutarQuery_dgDadosArmazenados("Select * from " + _NOME_TABELA_SELECT);
                    _cancelarDelete = 0;
                }
            }
            else
            {

            }
        }
        
        public void ExecutarCMDs(string _SQL, string _MSG = "", int ativar = 0)
        {
            MySqlConnection objconexao = new MySqlConnection(Infos.ConectionString);
            try
            {
                objconexao.Open();
            }
            catch
            {

            }   
         
                try
                {
                    string SQL = _SQL;
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, objconexao);
                    Adapter.SelectCommand.ExecuteNonQuery();
                    
                    if (ativar == 0)
                    {
                        MessageBox.Show(_MSG, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                    
                }
                catch (MySqlException Mysql_ex)
                {
                    MessageBox.Show("" + Mysql_ex.Message, "Erro!");
                }
            
                            
        }

        private void dataGrid_dadosArmazenados_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS_ITENS.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void atualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExecutarQuery_dgDadosArmazenados("Select * from " + _NOME_TABELA_SELECT);
        }

        
        private void dataGrid_dadosArmazenados_EditModeChanged(object sender, EventArgs e)
        {
        
        }

        private void tv_bd_DoubleClick(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Esta função foi desabilitada e será novamente abilitada em uma proxima versão!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] split_for = rtb_cmds.Text.Split(new char[] { '<', '>' });
            string[] split_corpo = rtb_cmds.Text.Split(new char[] { '{', '}' });
            if (rtb_cmds.Text == "")
            {
                return;
            }
            if (rtb_cmds.Text.ToUpper().Substring(0, 6) == "SELECT" || rtb_cmds.Text.ToUpper().Substring(0, 4) == "DESC" || rtb_cmds.Text.ToUpper().Substring(0, 4) == "SHOW")
            {
                ExecutarQuery_CMDs(rtb_cmds.Text);               
            }
            if (rtb_cmds.Text.ToUpper().Substring(0, 6) == "REPITA")
            {
                int _ativa = 0;
                try
                {                   
                        panel_repita.Visible = true;
                        label7.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        lb_linha_executandoComando.Visible = true;
                        lb_delinha_executandoComando.Visible = true;
                        //linkLabel2.Visible = true;
                        lb_delinha_executandoComando.Text = split_for[1];
                    
                    for (int x = 0; x < double.Parse(split_for[1]); x++)
                    {
                        if (_cancelarRepeticao == 0)
                        {
                            if (split_corpo[1].ToUpper().Substring(0, 6) == "SELECT" || split_corpo[1].ToUpper().Substring(0, 4) == "DESC" || split_corpo[1].ToUpper().Substring(0, 4) == "SHOW")
                            {
                                ExecutarQuery_CMDs(split_corpo[1]);
                                _ativa = 1;
                                break;
                            }
                            else
                            {
                                Executar_Inserts_CMDs(split_corpo[1], 1);
                                lb_linha_executandoComando.Text = (x + 1).ToString();
                                lb_linha_executandoComando.Refresh();

                                label7.Refresh();
                                label9.Refresh();
                                label10.Refresh();
                                lb_linha_executandoComando.Refresh();
                                lb_delinha_executandoComando.Refresh();
                                //linkLabel2.Refresh();
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (_ativa == 0)
                    {
                        MessageBox.Show("Comando executado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        _ativa = 0;
                    }
                    panel_repita.Visible = false;
                    label7.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    lb_linha_executandoComando.Visible = false;
                    lb_delinha_executandoComando.Visible = false;
                    //linkLabel2.Visible = false;
                    ExecutarQuery_dgDadosArmazenados("Select * from " + _NOME_TABELA_SELECT);
                    _cancelarRepeticao = 0;
                }
                catch(Exception ex)
                {                   
                    panel_repita.Visible = false;
                    label7.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    lb_linha_executandoComando.Visible = false;
                    lb_delinha_executandoComando.Visible = false;
                    linkLabel2.Visible = false;
                    MessageBox.Show(ex.Message,"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    _ativa = 1;
                }
            }
            else
            {
                Executar_Inserts_CMDs(rtb_cmds.Text);
                ExecutarQuery_dgDadosArmazenados("Select * from " + _NOME_TABELA_SELECT);                
            }
            lb_linhas_desc.Text = dataGrid_desc.RowCount.ToString();
            lb_linhas_desc.Text = dataGrid_desc.ColumnCount.ToString();
        }
        public int _abreCMD = 0;
        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_abreCMD == 0)
            {
                tabControl_principal.TabPages.Add(this.tab_cmds);
                tabControl_principal.SelectTab(tab_cmds);
                toolStripSeparator5.Visible = true;
                comandosToolStripMenuItem.Visible = true;
                _abreCMD = 1;
            }
            else
            {
                tabControl_principal.SelectTab(tab_cmds);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtb_cmds.Text != "")
            {
                if (MessageBox.Show("Caso você continue, os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    rtb_cmds.Text = "";
                    rtb_cmds.Text = "INSERT INTO " + _NOME_TABELA_SELECT + " VALUES(";
                    tabControl1.SelectTab(tabPage2);
                    rtb_cmds.Focus();
                }
            }
            else
            {
                rtb_cmds.Text = "";
                rtb_cmds.Text = "INSERT INTO " + _NOME_TABELA_SELECT + " VALUES(";
                tabControl1.SelectTab(tabPage2);
                rtb_cmds.Focus();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (rtb_cmds.Text != "")
            {
                if (MessageBox.Show("Caso você continue, os comandos digitados no campo Query serão perdidos.\n\nDeseja continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    rtb_cmds.Text = "";
                    rtb_cmds.Text = "ALTER TABLE " + _NOME_TABELA_SELECT + " SET ";
                    tabControl1.SelectTab(tabPage2);
                    rtb_cmds.Focus();
                }
            }
            else
            {
                rtb_cmds.Text = "";
                rtb_cmds.Text = "ALTER TABLE " + _NOME_TABELA_SELECT + " SET ";
                tabControl1.SelectTab(tabPage2);
                rtb_cmds.Focus();
            }
        }

        private void comandosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rtb_comandos_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    button1_Click(sender, e);
                    break;
            }
           
        }

        private void TelaInicial_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.F)
            {
                if (tabControl_principal.SelectedTab == tab_principal)
                {
                    tabControl_principal.Controls.Remove(tabControl_principal.SelectedTab);
                    _abaPrincipal = 0;
                }
                if (tabControl_principal.SelectedTab == tab_cmds)
                {
                    tabControl_principal.Controls.Remove(tabControl_principal.SelectedTab);
                    _abreCMD = 0;
                }
                else
                {
                    tabControl_principal.Controls.Remove(tabControl_principal.SelectedTab);
                }
            }
            else
                if (e.Control && e.KeyCode == Keys.P)
                {
                    if (_abaPrincipal == 0)
                    {
                        tabControl_principal.Controls.Add(tab_principal);
                        _abaPrincipal = 1;
                    }
                    else
                    {
                        tabControl_principal.SelectTab(tab_principal);
                    }
                }
        }

        private void hotKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t-------HotKeys-------\n\nCONTROL+P - Abre novamente a aba principal.\nCONTROL+ALT+F - Fecha a aba selecionada.\nF1 - Abre a tela de Triggers/Procedures.\nF2 - Abre a tela de pesquisa MDI.\nF3 - Abre a aba do Console.\nF4 - Abre a tela de Backup.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NOTI_ICON_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void showFullProcessListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarQuery("Show Full ProcessList;");
        }

        private void dataGrid_dadosArmazenados_MouseCaptureChanged(object sender, EventArgs e)
        {
            lb_linhas_selecionadas.Text =  dataGrid_dadosArmazenados.SelectedRows.Count.ToString();
        }

        private void dataGrid_dadosArmazenados_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                lb_linhas_selecionadas.Text = dataGrid_dadosArmazenados.SelectedRows.Count.ToString();
            }
        }

        private void tv_bd_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tv_bd.SelectedNode.Text == _nomeBD)
                {
                    tv_bd.SelectedNode.SelectedImageIndex = 3;
                }
                else
                {
                    if (tv_bd.SelectedNode.Text == "Bancos de dados")
                    {
                        return;
                    }
                    else
                    {
                        tv_bd.SelectedNode.SelectedImageIndex = 1;
                    }
                }
            }
            catch
            {

            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //_cancelarDelete = 1;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //_cancelarRepeticao = 1;
        }

        private void panel_repita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reporteBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteBugs contato = new ReporteBugs();
            contato.ShowDialog();
        }
    }
}
