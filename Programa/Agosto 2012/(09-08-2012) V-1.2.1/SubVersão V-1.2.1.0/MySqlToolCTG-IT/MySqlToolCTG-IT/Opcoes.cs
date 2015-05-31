using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySqlToolCTG_IT
{
    class Opcoes
    {
        private bool CMDMostrarListaDeErros = true;
        private bool CMDMostrarListaDeMultiErros = false;

        public bool _CMDMostrarListaDeErros
        {
            get { return CMDMostrarListaDeErros; }
            set { CMDMostrarListaDeErros = value; }
        }

        public bool _CMDMostrarListaDeMultiErros
        {
            get { return CMDMostrarListaDeMultiErros; }
            set { CMDMostrarListaDeMultiErros = value; }
        }
    }
}
