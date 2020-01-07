using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var file = "contas.txt";
            var stream = new FileStream(file, FileMode.Open);

            var buffer = new byte[1024];

            var numeroDebytes = -1;
            while(numeroDebytes != 0)
            {
                numeroDebytes = stream.Read(buffer, 0, 1014);
                EscreverBuffer(buffer);
            }
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var b in buffer)
            {
                Console.Write(b);
            }
        }
    }
} 
 