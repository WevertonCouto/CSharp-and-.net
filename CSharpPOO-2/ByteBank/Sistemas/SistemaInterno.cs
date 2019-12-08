using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senhaTentativa)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senhaTentativa);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Welcome to the System");
                return true;
            } else
            {
                Console.WriteLine("Wrong Password");
                return false;
            }
        }
    }
}
