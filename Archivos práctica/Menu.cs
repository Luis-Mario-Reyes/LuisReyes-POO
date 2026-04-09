using System;
using System.Linq;

namespace Menu;

public static class Program
{
    public static void Main()
    {


        while (true)
        {



            Console.WriteLine("Opciones disponibles:");
            Console.WriteLine("1er opcion: Sacar una potencia");
            Console.WriteLine("2da opcion: Km a mts");
            Console.WriteLine("3ra opcion: Pesos a dolar");
            Console.WriteLine("4ta opcion: °C a °F");
            Console.WriteLine("5ta opcion: Ordenar nuneros");
            Console.WriteLine("6ta opcion: Fizz buzz");
            Console.WriteLine("Ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());



            switch (opc)
            {
                case 1:
                    int r = 1;
                    Console.WriteLine("Usted selecciono la opc 1 (Calcular potencias)");
                    Console.WriteLine("Ingrese la base:");
                    int a = int.Parse(Console.ReadLine());//=*
                    Console.WriteLine("Ingrese el exponente:");
                    int b = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= b; i++)
                    {
                        r = r * a;
                    }
                    Console.WriteLine("Resultado: " + r);

                    break;

                case 2:
                    Console.WriteLine("Usted selecciono la opc 2 (Conversion de km a mts)");
                    Console.WriteLine("Ingrese los Km que quisiera convertir a metros:");
                    int km = int.Parse(Console.ReadLine());
                    int mts = km * 1000;
                    Console.WriteLine("Lo(s):" + km + " kilometro(s) convertidos a mts es igual a:" + mts + " metro(s)");


                    break;


                case 3:
                    decimal dls = 17.89m;
                    Console.WriteLine("Usted selecciono la opc 3 (Conversion de pesos a dls)");
                    Console.WriteLine("Ingrese los pesos que desea comvertir a dolares: ");
                    Console.WriteLine("Ojo el dolar actualmente esta a : " + dls);
                    decimal pesos = decimal.Parse(Console.ReadLine());
                    decimal conversion = pesos / dls;
                    Console.WriteLine("Tu(s) " + pesos + " Pesos son igual a: " + conversion + " Dolares ");





                    break;


                case 4:
                    Console.WriteLine("Usted selecciono la opc 4 (Conversion de grados)");
                    Console.WriteLine("Ingrese los grados en °C que desea convertir a °F:");
                    float gradosc = float.Parse(Console.ReadLine());
                    float congrados = (gradosc * 9 / 5) + 32;
                    Console.WriteLine(gradosc + " Grado(s) °C es igual a: " + congrados + " grados °F ");


                    break;



                case 5:
                    Console.WriteLine("Usted selecciono la opc 5 (Ordenamiento de 3 valores)");
                    Console.WriteLine("Ingrese su primer numero");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su segundo numero");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su tercer numero");
                    int num3 = int.Parse(Console.ReadLine());

                    int mayor = 0;
                    int medio = 0;
                    int menor = 0;

                    //mayor
                    if (num1 > num2 && num1 > num3)
                    {
                        mayor = num1;

                    }
                    if (num2 > num1 && num2 > num3)
                    {
                        mayor = num2;

                    }
                    if (num3 > num1 && num3 > num2)
                    {
                        mayor = num3;

                    }
                    //menor
                    if (num1 < num2 && num1 < num3)
                    {
                        menor = num1;

                    }
                    if (num2 < num1 && num2 < num3)
                    {
                        menor = num2;

                    }
                    if (num3 < num1 && num3 < num2)
                    {
                        menor = num3;

                    }
                    //medio
                    medio = num1 + num2 + num3 - mayor - menor;

                    Console.WriteLine("Los numeros ordenados de menor a mayor son los siguientes:");
                    Console.WriteLine("El valor menor es: " + menor);
                    Console.WriteLine("El valor medio es: " + medio);
                    Console.WriteLine("El valor mayor es: " + mayor);

                    break;

                case 6:
                    for (int i = 0; i <= 100; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.WriteLine("FIZZ BUZ");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.WriteLine("BUZ");
                        }
                        else if (i % 3 == 0)
                        {
                            Console.WriteLine("FIZZ");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }



                    }

                    break;

                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
            Console.WriteLine("Desea continuar? (1=si 0=No)");
            int opi = int.Parse(Console.ReadLine());

            if (opi == 0)
            {
                Console.WriteLine("Gracias por usar mi menu :)");
                break;
            }
        }

    }
}

