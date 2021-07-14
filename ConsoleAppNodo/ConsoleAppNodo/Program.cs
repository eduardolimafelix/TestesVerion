using System;
using System.Collections.Generic;

namespace ConsoleAppNodo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(13);
            list.AddFirst(10);
            list.AddFirst(8);
            list.AddFirst(19);
            var node = new LinkedListNode<int>(13);

            //EstaNaLista(13, node);

            bool EstaNaLista(int ch, LinkedListNode<int> head)
            {
                if (ch == head.Value)
                {
                    return true;
                }
                return false;
            }
            Console.WriteLine(EstaNaLista(136, node));
        }
    }
}