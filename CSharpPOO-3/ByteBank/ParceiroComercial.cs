using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class ParceiroComercial
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
