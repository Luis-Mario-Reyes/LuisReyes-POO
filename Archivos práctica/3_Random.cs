using System;
using System.Linq;

namespace _Randoms;

public static class Program
{
    public static void Main()
    {
        Random rd = new Random();
        int total = 100;


        Console.WriteLine();

        int val1 = rd.Next(0, 101);
        Console.WriteLine("El valor 1 es: " + val1);

        total = total - val1;

        int val2 = rd.Next(0, total);
        Console.WriteLine("El valor 2 es: " + val2);

        int nt = val1 + val2;
        nt = 100 - nt;

        Console.WriteLine("El valor 3 es: " + nt);



        for (int i = 1; i < 101; i++)
        {
            if (i <= val1)
            {
                String emoji1 = "🫧";
                Console.WriteLine(i + "°~" + emoji1);
            }

            else if (i <= val1 + val2)
            {
                String emoji2 = "🔵";
                Console.WriteLine(i + "°~" + emoji2);
            }
            else
            {
                String emoji3 = "🧡";
                Console.WriteLine(i + "°~" + emoji3);
            }
        }


    }
}

