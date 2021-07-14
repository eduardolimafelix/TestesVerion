using System;
using System.Collections.Generic;

namespace ConsoleLotes
{
    class Program
    {
        static List<Lote> lotes;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite C para compra ou V para venda!");
            string controle = Console.ReadLine();

            if (controle == "c" || controle == "C" || controle == "v" || controle == "V")
            {
                if (controle == "c" || controle == "C")
                {
                    //Compra
                    int x, y, w, z;
                    lotes = new List<Lote>();
                    controle = "S";
                    while (controle == "S" || controle == "s")
                    {
                        Console.WriteLine("Entre com a quantidade de lotes comprados");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entre agora com o valor");
                        y = int.Parse(Console.ReadLine());
                        
                        lotes.Add(new Lote(x, y));

                        Console.WriteLine("Deseja add outro lote? Pressione S para SIM");
                        controle = Console.ReadLine();
                    }
                    //Simulação de venda
                    Console.WriteLine("Diga a qtd de lotes vendidos e em seguida o valor");
                    w = int.Parse(Console.ReadLine());
                    z = int.Parse(Console.ReadLine());
                    Lote l1 = new Lote();
                    int i;
                    i = l1.calculaValor(lotes, w, z);
                    if (i > 0)
                    {
                        Console.WriteLine("Lucro de: "+i.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Prejuizo de: " + i.ToString());
                    } 
                    Lote l2 = new Lote();
                    l2.percorrerLista(lotes);
                }
                else
                {
                    //Venda

                }
            }
            else Console.WriteLine("Opção inválida");
        }
    }
}
