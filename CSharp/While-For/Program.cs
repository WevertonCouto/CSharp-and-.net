using System;
using System.Collections.Generic;

namespace While_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while(count <= 10)
            {
                count++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.ForEach((a) =>
            {
                Console.WriteLine(a.ToString());
            });
        }
    }
}
