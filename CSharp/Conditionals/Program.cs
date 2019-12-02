using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            // <= >= == < > 

            if(number < 10)
            {
                Console.WriteLine("Number is greater than 10");
            } else if(number > 10)
            {
                Console.WriteLine("Number is less than 10");
            } else
            {
                Console.WriteLine("Number is equal the 10");
            }

            bool a = false;
            if(a)
            {
                Console.WriteLine("a is true");
            } else Console.WriteLine("a is false");
        }
    }
}
