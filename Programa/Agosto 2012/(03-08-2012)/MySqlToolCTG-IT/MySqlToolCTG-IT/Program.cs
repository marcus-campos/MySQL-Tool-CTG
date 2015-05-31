using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MySqlToolCTG_IT
{
    static class Program
    {
        
        private static string ConectionStringMySql = "Persist Security Info=False;server=localhost;Port=3306;database=mysql;uid=root;pwd=";
        private static string ConectionStringMySqlOnline = "Persist Security Info=False;server=www.mysqltoolctg.com.br;Port=3306;database=mysqltoolctg;uid=root;pwd=";
        private static string ConectionStringAcces = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MTCTG.accdb; Jet OLEDB:Database Password=RUbRYoimgTwQxmg6urBd; Persist Security Info=True";
        private static string LoginUsuario = "";

        public static string _ConectionStringMySql
        {
            get { return ConectionStringMySql; }
            set { ConectionStringMySql = value; }
        }
        public static string _ConectionStringMySqlOnline
        {
            get { return ConectionStringMySqlOnline; }
            set { ConectionStringMySqlOnline = value; }
        }

        public static string _ConectionStringAcces
        {
            get { return ConectionStringAcces; }
            set { ConectionStringAcces = value; }
        }


        public static string _LoginUsuario
        {
            get { return LoginUsuario; }
            set { LoginUsuario = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </sumumary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaDeLogin());
        }
    }
}
