using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLotes
{
    public class Lote
    {
        public Lote() { }

        public int QtdLote { get; set; }
        public int ValorLote { get; set; }

        public Lote(int qtdLote, int valorLote) {
            this.QtdLote = qtdLote;
            this.ValorLote = valorLote; 
        }

        public void percorrerLista(List<Lote> lotes)
        {
            foreach (Lote l in lotes)
                {
                    Console.WriteLine("QTD: {0} VL: {1}", l.QtdLote, l.ValorLote);
                }
        }

        public int calculaValor(List<Lote> lotes, int w, int z)
        {
            int valor = 0;
            
            foreach (Lote l in lotes) {
                if (w > 0)
                {
                    if (w > l.QtdLote)
                    {
                        valor = valor + ((z - l.ValorLote)) * (l.QtdLote);
                        w = w - l.QtdLote;
                        l.QtdLote = 0;
                        l.ValorLote = 0;
                    }
                    else
                    {
                        valor = valor + (z - l.ValorLote) * w;
                        l.QtdLote = l.QtdLote - w;
                    }
                }
            }
            return valor;
        }
    }
 }
