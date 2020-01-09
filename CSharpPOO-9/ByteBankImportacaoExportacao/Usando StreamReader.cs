using ByteBankImportacaoExportacao.Modelos;
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
        static void LendoArquivoComStreamReader()
        {
            var dir = "contas.txt";
            using (var stream = new FileStream(dir, FileMode.Open))
            using (var leitor = new StreamReader(stream))
            {
                while (!leitor.EndOfStream)
                {
                    var contaCorrente = ConverterPraContaCorrente(leitor.ReadLine());
                }
            }
        }

        static ContaCorrente ConverterPraContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2];
            var nomeTitular = campos[3];

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
            resultado.Depositar(double.Parse(saldo.Replace('.', ',')));
            resultado.Titular = titular;

            return resultado;
        }
    }
}
