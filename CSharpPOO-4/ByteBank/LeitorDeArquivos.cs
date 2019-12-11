using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }
        

        public LeitorDeArquivos(string arquivo)
        {
            this.Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Arquivo fechado");
        }

        public void Dispose()
        {
            this.Fechar();
        }
    }
}
