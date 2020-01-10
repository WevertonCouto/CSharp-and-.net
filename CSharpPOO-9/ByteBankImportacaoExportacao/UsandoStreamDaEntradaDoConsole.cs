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
        public void UsarStreamEntrada()
        {
            using (var fluxoEntrada = Console.OpenStandardInput())
                using (var fs = new FileStream("entradaconsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var byteslidos = fluxoEntrada.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, byteslidos);
                    fs.Flush();
                    Console.WriteLine(byteslidos);
                }
            }
        }
    }
}
