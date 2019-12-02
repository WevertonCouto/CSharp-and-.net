using System;

namespace CreateVariables_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearold;
            yearold = 10;

            Console.WriteLine(yearold);

            yearold += 10;
            yearold -= 10;
            yearold = yearold - 5;

            Console.WriteLine(yearold + " years old");

            double weigth;
            weigth = 10.2;

            Console.WriteLine(weigth);

            weigth += 10.23;
            weigth -= 10.11;
            weigth = weigth - 5.10;
            
            Console.WriteLine(weigth + " weigth");


            long longNumber;
            longNumber = 1000000;

            Console.WriteLine(longNumber);

            longNumber += 10000000000000000;
            longNumber -= 10000000000000000;
            longNumber = longNumber - 5;

            Console.WriteLine(longNumber + " longNumber");
        }
    }
}
