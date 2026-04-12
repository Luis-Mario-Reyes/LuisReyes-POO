using System;
using System.Linq;

namespace Sumatoria_hasta_100;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Sumatoria de numeros con incremento hasta el 100");


        // 1+2=3
        // 3+3=6

        int num = 1;


        for (int i = 2; i <= 100; i++)
        {
            int numanterior = num; //Guardamos el numero antes de modificarlo para que se vaya almacenando y con cada vuelta se guarde el nuevo resultado

            num = num + i;
            Console.WriteLine(numanterior + "+" + i + "=" + num);
        }





    }
}

