using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComArquivosViaStream()
        {
            var file = "contas.txt";
            using (var stream = new FileStream(file, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDebytes = -1;
                while (numeroDebytes != 0)
                {
                    numeroDebytes = stream.Read(buffer, 0, 1014);
                    EscreverBuffer(buffer, numeroDebytes);
                }
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.WriteLine(texto);
            //foreach (var b in buffer)
            //{
            //    Console.Write(b);
            //}
        }
    }
}