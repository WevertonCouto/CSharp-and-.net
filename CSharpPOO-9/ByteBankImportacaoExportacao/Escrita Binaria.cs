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
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Create))
            {
                using (var escritor = new BinaryWriter(fs))
                {
                    escritor.Write("ysad");
                }
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Open))
            {
                using (var leitor = new BinaryReader(fs))
                {
                    // ele vai mudando a posição do ponteiro, quando faz a leitura
                    var agencia = leitor.ReadInt32();
                    var saldo = leitor.ReadInt32();
                }
            }
        }
    }
}
