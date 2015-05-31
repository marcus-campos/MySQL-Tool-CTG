using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Encriptografias;
using System.IO;

namespace MySqlToolCTG_IT
{
    class CriptografarHD
    {
        public string hdCrip()
        {
            ENCRIPTOGRAFAR_SENHAS encrip = new ENCRIPTOGRAFAR_SENHAS();
            encontrarHD enc = new encontrarHD();
            string criptografado = encrip.EncriptografarSenhas(enc.serialHD(Directory.GetCurrentDirectory().Substring(0,3)));
            return criptografado;
        }        
       
    }
}
