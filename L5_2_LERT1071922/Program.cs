using System;

namespace L5_2_LERT1071922
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dia;
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingresar numero ");

            Dia = Convert.ToInt32(Console.ReadLine());

            if (Dia < 0)
            {
                Console.WriteLine("ERROR EN EL PROGRAMA");
            }
            if (Dia > 7)
            {
                Console.WriteLine("ERROR EN EL PROGRAMA");
            }
            if (Dia == 1)
            {
                Console.WriteLine("el dia es lunes");
            }
            if (Dia == 2)
            {
                Console.WriteLine("El dia es martes");
            }
            if (Dia == 3)
            {
                Console.WriteLine("El resultado es Miercoles");
                if (Dia == 4)
                {
                    Console.WriteLine("El dia es Jueves");
                }
                if (Dia == 5)
                {
                    Console.WriteLine("El dia es Viernes");
                }
                if (Dia == 6)
                {
                    Console.WriteLine("El dia es Sabado");
                    if (Dia == 7)
                    {
                        Console.WriteLine("El dia es Domingo");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}

