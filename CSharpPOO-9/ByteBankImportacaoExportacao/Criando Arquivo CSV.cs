using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "123,123123,123.3,Weverton";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("123123,213123,123213.23,Weverton");
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";
            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    escritor.WriteLine();
                }
            }
        }
    }
}
