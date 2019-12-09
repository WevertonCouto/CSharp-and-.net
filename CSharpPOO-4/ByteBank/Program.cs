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
            Console.ReadLine();

            try
            {
                int b = 0;
                double a = (1 / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}
