using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using Encriptografias;
using System.IO;

namespace MySqlToolCTG_IT
{
    public partial class TelaPrincipal : Form
    {
        ControladorAcces CAaccess = new ControladorAcces();
        SintaxHili Hili = new SintaxHili();
        MySqlConnection objconexao = new MySqlConnection(Program._ConectionStringMySql);
        ControladorBanco ControladoresBD = new ControladorBanco();
        Opcoes opcoes = new Opcoes();
        private List<string> tabelaArray;
        private List<string> nomeBdsArray;
        private string UltimoConexaoSelecionada = "";

        [DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);


        private int UltimaPosicaoConexao = 0;

        public int _UltimaPosicaoConexao
        {
            get { return UltimaPosicaoConexao; }
            set { UltimaPosicaoConexao = value; }
        }

        public List<string> _tableaArray
        {
            get { return tabelaArray; }
            set { tabelaArray = value; }
        }

        public List<string> _nomeBdsArray
        {
            get { return nomeBdsArray; }
            set { nomeBdsArray = value; }
        }

        public string _UltimoConexaoSelecionada
        {
            get { return UltimoConexaoSelecionada; }
            set { UltimoConexaoSelecionada = value; }
        }

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            PreencherTreeView();
            ModificadorVisualInicial();
        }

        public void RotinaBDAcess()
        {

        }

        public void PreencherTreeView()
        {
            tv_bd.ImageList = img_list;

            tv_bd.Nodes.Clear();

            ClasseDeEncriptografia Encriptografar = new ClasseDeEncriptografia();
            CAaccess.Visualizadores("Select * from tbl_login where login = '" + Encriptografar.EncriptografarString(Program._LoginUsuario) + "';", 1);

            CAaccess.Visualizadores("select * from tbl_conexoes where id_usuario = '" + CAaccess._VisualizadorMOD1 + "';", 0);

            ConverterParaArray();

            for (int x = 0; x < _tableaArray.Count; x++)
            {
                tv_bd.Nodes.Add(CAaccess._dataSet.Tables[0].Rows[x]["nome_conexao"].ToString());
                tv_bd.Nodes[x].ImageIndex = 0;
                tv_bd.Nodes[x].SelectedImageIndex = 0;
            }
        }

        public void ConverterParaArray()
        {

            _tableaArray = new List<string>();
            _nomeBdsArray = new List<string>();

            //preenche o array com  o nome das tabelas
            foreach (DataRow datRow in CAaccess._dataTable.Rows)
            {
                tabelaArray.Add(datRow[0].ToString());
                _nomeBdsArray.Add(datRow[1].ToString());
            }
        }

        public void PreencherTreeViewBancos(int posNode = 0)
        {
            try
            {
                PreencherTreeView();
                ControladorBanco Controladores = new ControladorBanco();
                Controladores.GetBancoDeDados();

                for (int i = 0; i < Controladores._tableaArray.Count; i++)
                {
                    tv_bd.Nodes[posNode].Nodes.Add(Controladores._tableaArray[i].ToString());
                    tv_bd.Nodes[posNode].Nodes[i].ImageIndex = 1;
                    tv_bd.Nodes[posNode].Nodes[i].SelectedImageIndex = 1;
                }
                tv_bd.Nodes[_UltimaPosicaoConexao].Expand();
            }
            catch
            {

            }
        }

        private void novatelaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void TabGrid()
        {
            if (tabc_CMD.TabPages.Contains(tab_grid))
            {
                dg_CMD.DataSource = ControladoresBD._dataTable;
                tabc_CMD.SelectTab(tab_grid);
            }
            else
            {
                dg_CMD.DataSource = ControladoresBD._dataTable;
                tabc_CMD.TabPages.Add(this.tab_grid);
                tabc_CMD.SelectTab(tab_grid);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtb_comandos.Text == "")
            {
                MessageBox.Show("Não foi possível exercutar esse comando.\nInsira um comando válido.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (rtb_comandos.Text.ToUpper().Substring(0, 6) == "SELECT" || rtb_comandos.Text.ToUpper().Substring(0, 4) == "DESC" || rtb_comandos.Text.ToUpper().Substring(0, 4) == "SHOW")
                    {
                        ControladoresBD.Visualizador(rtb_comandos.Text);
                        TabGrid();
                        //lsb_ultimos_comandos.Items.Add(rtb_comandos.Text);     
                        ListaErro();
                    }

                    else
                    {
                        ControladoresBD.Modificador(rtb_comandos.Text, true);
                        ListaErro();
                    }
                }
                catch (Exception ex)
                {
                    lst_CMD_erros.Items.Add(DateTime.Now + ": " + ex.Message, 4);
                }
            }
        }

        public void ListaErro()
        {
            if (opcoes._CMDMostrarListaDeErros == true)
            {
                if (tabc_CMD.TabPages.Contains(tab_CMD_erros))
                {

                }
                else
                {
                    tabc_CMD.TabPages.Add(this.tab_CMD_erros);
                }

                if (opcoes._CMDMostrarListaDeMultiErros == false)
                {
                    lst_CMD_erros.Clear();
                }
                else
                {

                }

                if (ControladoresBD._visualizadorErro == true)
                {
                    if (ControladoresBD._visualizadorErroMSG.Count > 1)
                    {
                        for (int x = 0; x < ControladoresBD._visualizadorErroMSG.Count; x++)
                        {
                            lst_CMD_erros.Items.Add(ControladoresBD._visualizadorErroMSG[x], 4);
                        }
                        tabc_CMD.SelectTab(this.tab_CMD_erros);
                    }
                    else
                    {
                        lst_CMD_erros.Items.Add(ControladoresBD._visualizadorErroMSG[0], 4);
                        tabc_CMD.SelectTab(this.tab_CMD_erros);
                    }
                }
                else
                {

                }
            }
            else
            {
                if (tabc_CMD.TabPages.Contains(tab_CMD_erros))
                {
                    tabc_CMD.TabPages.Remove(this.tab_CMD_erros);
                }
                else
                {

                }
            }

        }



        private void rtb_comandos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                try
                {
                    LockWindowUpdate(rtb_comandos.Handle);

                    int selPos = rtb_comandos.SelectionStart;

                    foreach (Match keyWordMatch in Hili.Syntaxes.Matches(rtb_comandos.Text))
                    {
                        rtb_comandos.Select(keyWordMatch.Index, keyWordMatch.Length);
                        rtb_comandos.SelectionColor = Color.Blue;
                        rtb_comandos.SelectionStart = selPos;
                        rtb_comandos.SelectionColor = Color.Black;
                    }
                }
                finally { LockWindowUpdate(IntPtr.Zero); }
            }

        }

        public void ModificadorVisualInicial()
        {
            tabc_CMD.TabPages.Remove(this.tab_grid);
            tabc_CMD.TabPages.Remove(this.tab_CMD_erros);
            excluirBancoDeDadosToolStripMenuItem.Enabled = false;
            excluirTabelaToolStripMenuItem.Enabled = false;
            tabControl_principal.TabPages.Remove(tab_tabelasPesq);
            tabControl_principal.TabPages.Remove(tab_cmds);
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabc_CMD.SelectedTab == this.tab_grid)
            {
                tabc_CMD.TabPages.Remove(this.tab_grid);
            }
        }

        private void cms_CMD_Opening(object sender, CancelEventArgs e)
        {
            if (tabc_CMD.SelectedTab == this.tab_grid)
            {
                cms_CMD.Items.Add(this.fecharToolStripMenuItem);
                cms_CMD.Show(Cursor.Position.X, Cursor.Position.Y);
            }
            else
            {
                cms_CMD.Items.Remove(this.fecharToolStripMenuItem);
            }
        }

        private void rtb_comandos_KeyPress(object sender, KeyPressEventArgs e)
        {
            lb_total_linhas.Text = rtb_comandos.Lines.Length.ToString();
            lb_total_caracteres.Text = rtb_comandos.Text.Length.ToString();
        }

        private void menuDeOpçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void criarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovaConexao criar_conexao = new CriarNovaConexao();
            criar_conexao.ShowDialog();
            PreencherTreeView();
        }

        private void tv_bd_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tv_bd.SelectedNode.ImageIndex == 0)
                {
                    if (_UltimoConexaoSelecionada == tv_bd.SelectedNode.Text)
                    {
                        return;
                    }
                    else
                    {
                        _UltimoConexaoSelecionada = tv_bd.SelectedNode.Text;
                        _UltimaPosicaoConexao = tv_bd.SelectedNode.Index;

                        ConectionStringBruta();
                        PreencherTreeViewBancos(tv_bd.SelectedNode.Index);
                    }
                }
                else
                    if (tv_bd.SelectedNode.ImageIndex == 1)
                    {
                        ConectionStringBruta(tv_bd.SelectedNode.Text);
                        CarregaTables();
                    }
            }
            catch { }
        }
        public void ConectionStringBruta(string _nomeBD = "mysql")
        {
            string _nomeConexao = _UltimoConexaoSelecionada;
            string _porta = "";
            string _database = "";
            string _usuario = "";
            string _senha = "";
            string _servidor = "";

            CAaccess.Visualizadores("select * from tbl_conexoes where id_usuario = '" + CAaccess._VisualizadorMOD1 + "' and nome_conexao = '" + _nomeConexao + "';", 0);
            _porta = CAaccess._dataSet.Tables[0].Rows[0]["porta"].ToString();
            _database = _nomeBD;
            _usuario = CAaccess._dataSet.Tables[0].Rows[0]["usuario"].ToString();
            _senha = CAaccess._dataSet.Tables[0].Rows[0]["senha"].ToString();
            _servidor = CAaccess._dataSet.Tables[0].Rows[0]["ip_conexao"].ToString();
            ConectString(_servidor, _porta, _database, _usuario, _senha);
        }

        public void ConectString(string Servidor, string porta, string database, string usuario, string senha)
        {
            Program._ConectionStringMySql = "Persist Security Info=False;server=" + Servidor + ";Port=" + porta + ";database=" + database + ";uid=" + usuario + ";pwd=" + senha + "";
        }

        public void CarregaTables()
        {
            lv_tabelas.SmallImageList = img_list;
            MySqlConnection objconexao1 = new MySqlConnection(Program._ConectionStringMySql);
            try
            {
                objconexao1.Open();
            }
            catch
            {

            }
            try
            {
                lv_tabelas.Clear();
                string _sql = "show tables;";
                MySqlCommand cmd = new MySqlCommand(_sql, objconexao1);
                MySqlDataAdapter objadapter = new MySqlDataAdapter(_sql, objconexao1);
                MySqlDataReader objdatareader = cmd.ExecuteReader();

                // Preenche o ListView
                while (objdatareader.Read())
                {
                    ListViewItem objListItem = new ListViewItem(objdatareader.GetValue(0).ToString());
                    for (int x = 1; x < objdatareader.FieldCount; x++)
                    {
                        objListItem.SubItems.Add(objdatareader.GetValue(x).ToString());
                    }

                    objListItem.ImageIndex = 2;
                    lv_tabelas.Items.Add(objListItem);
                }
                //fecha o datareader e a conexa
                objdatareader.Close();
                objconexao1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void excluirConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esta conexão?", "Excluir Conexão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ControladorAcces CAcess = new ControladorAcces();
                CAcess.Modificadores("delete from tbl_conexoes where nome_conexao = '" + tv_bd.SelectedNode.Text + "';");
                PreencherTreeViewBancos();
                lv_tabelas.Clear();
            }
        }

        private void novaTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novaTabela criarTabela = new novaTabela();
            criarTabela.Show();
        }

        private void excluirTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_tabelas.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir esta tabela?", "Excluir Tabela", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ControladorBanco CBanco = new ControladorBanco();
                    CBanco.Modificador("Drop Table " + lv_tabelas.SelectedItems[0].Text);
                    CarregaTables();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tabela antes de excluir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                excluirTabelaToolStripMenuItem.Enabled = false;
            }
        }

        private void novoBancoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CriarBanco novoBanco = new CriarBanco();
            novoBanco.ShowDialog();
            PreencherTreeViewBancos(_UltimaPosicaoConexao);
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreencherTreeViewBancos();
        }


        private void excluirBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este banco de dados?", "Excluir Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ControladorBanco CBanco = new ControladorBanco();
                CBanco.Modificador("drop database " + tv_bd.SelectedNode.Text + ";");
                PreencherTreeViewBancos(_UltimaPosicaoConexao);
            }
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CarregaTables();
        }

        private void tv_bd_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (tv_bd.SelectedNode.ImageIndex == 1)
                {
                    excluirBancoDeDadosToolStripMenuItem.Enabled = true;
                }
                else
                {
                    excluirBancoDeDadosToolStripMenuItem.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void lv_tabelas_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_tabelas.SelectedItems.Count > 0)
                {
                    excluirTabelaToolStripMenuItem.Enabled = true;
                }
                else
                {
                    excluirTabelaToolStripMenuItem.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void abrirCentralDeAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CentralDeAjuda centraldeAjuda = new CentralDeAjuda();
            centraldeAjuda._URL = Directory.GetCurrentDirectory() + "\\AjudaOff\\1_parte.html";
            centraldeAjuda.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lv_tabelas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dataGrid_dadosArmazenados.DataSource = null;
                dataGrid_desc.DataSource = null;

                tabControl_principal.TabPages.Remove(this.tab_tabelasPesq);
                tabControl_principal.TabPages.Add(this.tab_tabelasPesq);
                tabControl_principal.SelectTab(tab_tabelasPesq);

                ControladoresBD.Visualizador("Select * from " + lv_tabelas.SelectedItems[0].Text, 1, "dg_dadosArmazenados");
                tab_tabelasPesq.Text = "Tabela: " + lv_tabelas.SelectedItems[0].Text;
                dataGrid_dadosArmazenados.DataSource = ControladoresBD._dataSet;
                dataGrid_dadosArmazenados.DataMember = "dg_dadosArmazenados";
                lb_linhas_cmd.Text = dataGrid_dadosArmazenados.RowCount.ToString();
                lb_colunas_cmd.Text = dataGrid_dadosArmazenados.ColumnCount.ToString();
                lb_linhas_selecionadas.Text = dataGrid_dadosArmazenados.SelectedRows.Count.ToString();

                ControladoresBD.Visualizador("Desc " + lv_tabelas.SelectedItems[0].Text, 1, "data_dsc");
                dataGrid_desc.DataSource = ControladoresBD._dataSet;
                dataGrid_desc.DataMember = "data_dsc";

            }
            catch
            {

            }
        }

        private void dataGrid_desc_DataSourceChanged(object sender, EventArgs e)
        {
            dataGrid_desc.AutoResizeColumns();
        }

        private void dataGrid_dadosArmazenados_DataSourceChanged(object sender, EventArgs e)
        {
            dataGrid_dadosArmazenados.AutoResizeColumns();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CentralDeAjudaPDF pdf = new CentralDeAjudaPDF();
            pdf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ControladoresBD.Visualizador(rtb_cmds.Text, 1, "dados");
                dataGrid_desc.DataSource = ControladoresBD._dataSet;
                dataGrid_desc.DataMember = "dados";
                lb_linhas_desc.Text = dataGrid_desc.RowCount.ToString();
                lb_colunas_desc.Text = dataGrid_desc.ColumnCount.ToString();
            }
            catch
            {

            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void dataGrid_dadosArmazenados_MouseCaptureChanged(object sender, EventArgs e)
        {
            lb_linhas_selecionadas.Text = dataGrid_dadosArmazenados.SelectedRows.Count.ToString();
        }

        private void abrirCMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl_principal.Contains(tabc_CMD))
            {
                tabControl_principal.SelectedTab = tab_cmds;
            }
            else
            {
                tabControl_principal.TabPages.Add(tab_cmds);
                tabControl_principal.SelectedTab = tab_cmds;
            }
        }

        private void rtb_comandos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            lb_total_linhas.Text = rtb_comandos.Lines.Count().ToString();
            lb_total_caracteres.Text = rtb_comandos.TextLength.ToString();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrocarSenha trocar_senha = new TrocarSenha();
            trocar_senha.ShowDialog();
        }

        private void atualizarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreencherTreeViewBancos();
        }

        private void tabControl_principal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Delete)
            {
                if (tabControl_principal.SelectedTab == tab_principal)
                {

                }
                else
                {
                    tabControl_principal.TabPages.Remove(tabControl_principal.SelectedTab);
                }
            }
        }

        private void hotKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shift + Delete = Fecha a aba selecionada.","HotKeys",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void rtb_comandos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void rtb_cmds_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                try
                {
                    LockWindowUpdate(rtb_comandos.Handle);

                    int selPos = rtb_comandos.SelectionStart;

                    foreach (Match keyWordMatch in Hili.Syntaxes.Matches(rtb_comandos.Text))
                    {
                        rtb_comandos.Select(keyWordMatch.Index, keyWordMatch.Length);
                        rtb_comandos.SelectionColor = Color.Blue;
                        rtb_comandos.SelectionStart = selPos;
                        rtb_comandos.SelectionColor = Color.Black;
                    }
                }
                finally { LockWindowUpdate(IntPtr.Zero); }
            }
        }
    }
}
