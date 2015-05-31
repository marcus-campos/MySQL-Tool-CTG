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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pg_carregando.Value >= 100)
            {
                timer1.Enabled = false;
                TelaDeLogin tl_login = new TelaDeLogin();
                tl_login.Show();
                this.Hide();
            }
            else
            {
                pg_carregando.Value += 10;
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
