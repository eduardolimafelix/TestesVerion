using System;
using System.Collections.Generic;

namespace ConsoleAppLotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l1 = new Lista();
            public List<Lote> l2;

            Console.WriteLine("Digite C para compra ou V para venda!");
            string controle = Console.ReadLine();

            if (controle == "c" || controle == "C" || controle == "v" || controle == "V")
            {
                if (controle == "c" || controle == "C")
                {
                    //Compra
                    int x, y, w, z;
                    controle = "S";
                    
                    while (controle == "S" || controle == "s") {
                        /*Console.WriteLine("Entre com a quantidade de lotes compradas");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entre agora com os valores");
                        y = int.Parse(Console.ReadLine());*/

                        x = 100;
                        y = 20;
                        Lote lote1 = new Lote(x, y);
                        
                        l1.AddPrimeiro(lote1);
                        x = 20;
                        y = 24;
                        l1.AddPrimeiro(lote1);
                        x = 200;
                        y = 36;
                        l1.AddPrimeiro(lote1);

                        //l1.AddPrimeiro(lote1);
                        //Console.WriteLine("Deseja add outro lote? Pressione S para SIM");
                        controle = Console.ReadLine();
                    }
                    //Simulação de venda
                    //Console.WriteLine("Diga a qtd de lotes vendidos e em seguida o valor");
                    //w = int.Parse(Console.ReadLine());
                    //z = int.Parse(Console.ReadLine());
                    w = 150;
                    z = 30;
                    l1.RetirarPrimeiro();
                    int total = l1.calculaValor(l1.RetirarPrimeiro().QtdLotes, l1.RetirarPrimeiro().Valor, w, z);
                    
                    Console.WriteLine(total.ToString());
                }
                else
                {
                    //Venda

                }
            }
            else Console.WriteLine("Opção inválida");

            Console.ReadKey();
        }
    }
}
