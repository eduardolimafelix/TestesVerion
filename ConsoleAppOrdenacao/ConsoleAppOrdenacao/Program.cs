using System;
using System.Collections.Generic;

namespace ConsoleAppOrdenacao
{
    class Program
    {
        static List<string> cores;
        static void Main(string[] args)
        {
            cores = new List<string> { "AZUL", "VERMELHO", "VERMELHO", "AZUL", "AZUL", "AZUL" };
            cores.Sort();

            foreach (string s in cores) {
                Console.WriteLine(s);
            }
        }
    }
}
