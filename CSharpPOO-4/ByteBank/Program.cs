using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(123, 123);
                conta.Depositar(500);
                conta.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("Contas.txt"))
            {

            }
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("Contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (System.IO.IOException)
            //{

            //    throw;
            //}
            //finally
            //{
            //    if(leitor != null)
            //        leitor.Fechar();
            //}
            
        }

        public static double Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
