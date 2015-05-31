using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MySql_Tool
{
    static class Program
    {
        public static string _infos_servidor = "";
        public static string _infos_porta = "";
        public static string _infos_database = "";
        public static string _infos_usuario = "";
        public static string _infos_senha = "";

        public static string ConectBD_MUNDI = "Persist Security Info=False;server=www.freesql.org;Port=3306;database=mysqltoolctg;uid=mysqlctg;pwd=7889dmg%";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
    }
}
