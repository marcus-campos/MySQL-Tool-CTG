using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MySqlToolCTG_IT
{
    public partial class CentralDeAjudaPDF : Form
    {
        public CentralDeAjudaPDF()
        {
            InitializeComponent();
        }

        private void CentralDeAjudaPDF_Load(object sender, EventArgs e)
        {
            leitor_pdf.src = Directory.GetCurrentDirectory() + "//AjudaOff//PDF//Ajuda.pdf";
        }
    }
}
