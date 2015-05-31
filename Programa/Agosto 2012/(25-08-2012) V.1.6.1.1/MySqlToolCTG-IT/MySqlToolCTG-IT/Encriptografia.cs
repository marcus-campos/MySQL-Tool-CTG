﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Encriptografias
{
    class ClasseDeEncriptografia
    {
        public string EncriptografarString(string input)
        {
            try
            {
                Directory.GetCurrentDirectory();
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] Bytes_de_entrada = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(Bytes_de_entrada);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X8"));
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return MessageBox.Show(ex.Message).ToString();
            }

        }
    }
}
