using System;

namespace problema2semana7
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1; 

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Divisor de Omar Orlandini " + contador + ": ");
                    Console.WriteLine(i);
                    contador++;
                    
                }
            }
            Console.ReadKey();
        }
    }
}
