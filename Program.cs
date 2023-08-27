using System;
using System.Collections.Generic;
using System.Text;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Console.WriteLine("Introduzca un numero de 1 al 7");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            { 
                case 1 :
                    Console.WriteLine("Es lunes");
                    break;
                case 2:
                    Console.WriteLine("Es martes");
                    break;
                case 3:
                    Console.WriteLine("Es miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es jueves");
                    break;
                case 5:
                    Console.WriteLine("Es viernes");
                    break;
                case 6:
                    Console.WriteLine("Es sabado");
                    break;
                case 7:
                    Console.WriteLine("Es domingo");
                    break;
                default:
                    Console.WriteLine("no es un dia");
                    break;
              }
              Console.ReadKey();


        }
    }
}
