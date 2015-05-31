using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySqlToolCTG_IT
{
    public partial class CentralDeAjuda : Form
    {
        private string URL = "";

        public string _URL
        {
            get { return URL; }
            set { URL = value; }
        }


        public CentralDeAjuda()
        {
            InitializeComponent();
        }

        private void CentralDeAjuda_Load(object sender, EventArgs e)
        {
            wb_ajuda.Navigate(_URL);
        }
    }
}
