using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySqlToolCTG_IT
{
    class CriadorBanco
    {
        private string nomeBanco;
        private string sintaxeBanco;
        private string charSet;
        private string collate;
        private bool enableCharset = false;
        private bool enableColation = false;

        public string _nomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = value; }
        }
        public string _sintaxeBanco
        {
            get { return sintaxeBanco; }
            set { sintaxeBanco = value; }
        }
        public string _charSet
        {
            get { return charSet; }
            set { charSet = value; }
        }
        public string _collate
        {
            get { return collate; }
            set { collate = value; }
        }
        public bool _enableCharset
        {
            get { return enableCharset; }
            set { enableCharset = value; }
        }
        public bool _enableColation
        {
            get { return enableColation; }
            set { enableColation = value; }
        }

        public void SQL()
        {
            if (_enableCharset == false)
            {
                _sintaxeBanco = "CREATE DATABASE "+_nomeBanco +";";
                ControladorBanco controlodorBD = new ControladorBanco();
                controlodorBD.Modificador(_sintaxeBanco, true, "Banco de dados criado com sucesso!");
            }
            else
            {
                if (_enableColation == false)
                {
                    _sintaxeBanco = "CREATE DATABASE " + _nomeBanco + "; ALTER DATABASE " + _nomeBanco + " CHARACTER SET " + _charSet + ";";
                    ControladorBanco controlodorBD = new ControladorBanco();
                    controlodorBD.Modificador(_sintaxeBanco, true, "Banco de dados criado com sucesso!");
                }               
                else
                {
                    _sintaxeBanco = "CREATE DATABASE " + _nomeBanco + "; ALTER DATABASE " + _nomeBanco + " CHARACTER SET " + _charSet + " COLLATE " + _collate + ";";
                    ControladorBanco controlodorBD = new ControladorBanco();
                    controlodorBD.Modificador(_sintaxeBanco, true, "Banco de dados criado com sucesso!");
                }
            }
            

        }
    }
}
