using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    public class Program
    {
        static void Main(string[] args)
        {

            var listContas = new List<ContaCorrente>()
            {
                new ContaCorrente(100, 123123),
                new ContaCorrente(120, 173123),
                new ContaCorrente(110, 113123),
                new ContaCorrente(105, 124123),
            };

            listContas.Sort();



            var list = new List<int>();
            list.Add(1);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.AdicionarVarios(1, 2, 3);

            list.Sort();
            list.Remove(10);
            

        }
    }
}
