using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFuncRecursiva
{
    class Program
    {
        static List<int> numeros;
        static void Main(string[] args)
        {
            numeros = new List<int> {1, 8, 19, 12, 24 };
            int x = 0;

            Console.WriteLine("Digite um numero:");
            int k = int.Parse(Console.ReadLine()); 

            if (funcc(numeros, x)){
                Console.WriteLine("O numero está na lista");
            }
            else
            {
                Console.WriteLine("O numero NÃO está na lista");
            }
            
            bool funcc(List<int> n, int z)
            {
                if (n[z] == k)
                {
                    return true;
                }
                else
                {
                    z++;
                    if (n.Count > z)
                    {
                        return funcc(n, z);
                    }
                    else
                        return false;
                    
                }
            }
        }
    }
}
