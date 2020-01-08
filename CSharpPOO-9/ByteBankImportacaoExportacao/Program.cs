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
        static void Main(string[] args) 
        {
            var dir = "contas.txt";
            using (var stream = new FileStream(dir, FileMode.Open))
                using (var leitor = new StreamReader(stream))
                {
                    while (!leitor.EndOfStream)
                    {
                        Console.WriteLine(leitor.ReadLine());
                    }
                }
        }
    }
} 
 