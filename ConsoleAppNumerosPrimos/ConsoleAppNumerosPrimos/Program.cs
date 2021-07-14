using System;

namespace ConsoleAppNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;
            int cont = 0;
            while (numero <= 100)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine("Numero primo " + numero);
                }
                cont = 0;
                numero++;
            }
        }
    }
}
