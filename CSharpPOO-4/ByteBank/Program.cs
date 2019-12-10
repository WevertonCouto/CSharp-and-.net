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
                //int b = 0;
                //Dividir(1, b);
            }
            catch (KeyNotFoundException e)
            {
            }
        }

        public static double Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
