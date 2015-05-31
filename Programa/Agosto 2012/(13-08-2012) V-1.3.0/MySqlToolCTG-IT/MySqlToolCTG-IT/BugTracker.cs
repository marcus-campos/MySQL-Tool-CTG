﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Encriptografias;

namespace MySqlToolCTG_IT
{
    public partial class BugTracker : Form
    {
        private string _OldConectStr = "";
        ControladorBanco controlarDB = new ControladorBanco();
        Encriptografias.ClasseDeEncriptografia Encriptografar = new Encriptografias.ClasseDeEncriptografia();
        public BugTracker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (rtb_desc.Text.ToUpper() == "{CONFIRMAR[CORRECAO]}".ToUpper())
            {
                if (panel1.Visible == true)
                {
                    panel1.Visible = false;
                }
                else
                {
                    panel1.Visible = true;
                }
            }
            else
            {
                _OldConectStr = Program._ConectionStringMySql;
                Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
                controlarDB.Modificador("Insert into tbl_bugs(assunto,descricao,login,data_reportado) values('"+tb_assunto.Text+"','"+rtb_desc.Text+"','"+Program._LoginUsuario+"',sysdate());",true,"Bug cadastrado com sucesso!");
                Program._ConectionStringMySql = _OldConectStr;
            }
        }

        public void CarregaGridADM()
        {
            _OldConectStr = Program._ConectionStringMySql;
            Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
            controlarDB.Visualizador("Select * from tbl_bugs;", 1, "dg_dadosArmazenados");
            dg_bugs.DataSource = controlarDB._dataSet;
            dg_bugs.DataMember = "dg_dadosArmazenados";
            Program._ConectionStringMySql = _OldConectStr;

            for (int x = 0; x < dg_bugs.RowCount; x++)
            {
                if (dg_bugs.Rows[x].Cells[5].Value.ToString() != "")
                {
                    dg_bugs.Rows[x].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dg_bugs.Rows[x].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void BugTracker_Load(object sender, EventArgs e)
        {
            /*Thread CarregarDados = new Thread(new ThreadStart(this.CarregarGrid));
            CarregarDados.Start();
            */
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            _OldConectStr = Program._ConectionStringMySql;
            Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
            controlarDB.Visualizador("Select codigo,assunto,descricao,data_reportado,data_correcao from tbl_bugs where login = '" + Program._LoginUsuario + "';", 1, "dg_dadosArmazenados");
            dg_bugs.DataSource = controlarDB._dataSet;
            dg_bugs.DataMember = "dg_dadosArmazenados";            
            Program._ConectionStringMySql = _OldConectStr;

            for (int x = 0; x < dg_bugs.RowCount; x++)
            {
                if (dg_bugs.Rows[x].Cells[4].Value.ToString() != "")
                {
                    dg_bugs.Rows[x].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dg_bugs.Rows[x].DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_senha.Text == "%toolctg123%")
            {
                _OldConectStr = Program._ConectionStringMySql;
                Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
                controlarDB.Modificador("Update tbl_bugs set data_correcao = sysdate() where codigo = '"+dg_bugs.SelectedRows[0].Cells[0].Value.ToString()+"';", true, "Bug corrigido com sucesso!");
                CarregaGridADM();
                Program._ConectionStringMySql = _OldConectStr;
                panel1.Visible = false;
            }
            else
                if (tb_senha.Text == "%123toolctg%")
                {
                    _OldConectStr = Program._ConectionStringMySql;
                    Program._ConectionStringMySql = Program._ConectionStringMySqlOnline;
                    CarregaGridADM();
                    Program._ConectionStringMySql = _OldConectStr;
                    panel1.Visible = false;
                }
        }
    }
}
