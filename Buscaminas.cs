using System;
using System.Linq;

namespace Buscaminas;

public static class Program
{
    public static void Main()
    {
        int repetir = 0;
        do
        {
            string[] tablero = new string[10];
            bool[] visitadas = new bool[10];
            Random rnd = new Random();

            for (int i = 0; i < tablero.Length; i++)
            {
                tablero[i] = "0";
            }

            //Generar mina
            int posicionesMina = rnd.Next(0, 10);
            tablero[posicionesMina] = "*";
            for (int i = 0; i < tablero.Length; i++)
            {
                Console.Write("X");

            }

            //Antes de jugar 
            int pts = 0; //puntos comiecen desde 0
            bool Lose = false; //saber si perdio

            //turno del jugador
            while (!Lose && pts < 900)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese una posicion del 0-9");
                int posicion = int.Parse(Console.ReadLine());


                if (posicion < 0 || posicion > 9)
                {
                    Console.WriteLine("La posicion " + " " + posicion + " " + " Es invalida, favor de ingresar valido");
                }


                if (tablero[posicion] == "*")
                {
                    Lose = true;

                    Console.WriteLine("Ha explotado la bomba !!!PUM!!!");
                    Console.WriteLine("La mina estaba en la posicion:" + " " + posicionesMina);
                    Console.WriteLine("Usted a sacado:" + pts + " " + "Puntos felicidades");

                    //imptimir tablero si lose
                    for (int i = 0; i < tablero.Length; i++)
                    {
                        Console.Write(tablero[i]);

                    }

                    break;
                }

                if (tablero[posicion] == "0")
                {

                    Console.WriteLine("Usted esta en una zona segura");
                }

                if (visitadas[posicion] == true)
                {
                    Console.WriteLine("Ustes ya uso este numero no se sumara");
                }

                if (visitadas[posicion] == false)
                {
                    pts += 100;
                    visitadas[posicion] = true;
                }



                if (pts == 900)
                {
                    Console.WriteLine("Usted a ganado!!!");
                    Lose = true;
                    break;

                }


                int contadorMinas = 0;

                if (posicion > 0)
                {
                    //  
                    if (tablero[posicion - 1] == "*")
                    {
                        contadorMinas++;
                    }

                }

                if (posicion < 9)
                {
                    // 
                    if (tablero[posicion + 1] == "*")
                    {
                        contadorMinas++;
                    }
                }

                Console.WriteLine("Hay" + " " + contadorMinas + " " + "Minas Cercanas");
            }
            Console.WriteLine();
            Console.WriteLine("desea volver a jugar? 1.SI y 0.NO");
            repetir = int.Parse(Console.ReadLine());
            if (repetir == 0)
            {
                Console.WriteLine("Cerrando juego....");
            }
        } while (repetir == 1);
    }
}

