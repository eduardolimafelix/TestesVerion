using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLotes
{
    class Lista
    {
        class Celula
        {
            public Lote elemento;
            public Celula prox;
        }

        private int tam;
        public int Tam { get { return (this.tam); } }


        private Celula primeiro, ultimo, aux;


        public Lista()
        {
            this.tam = 0;
            this.primeiro = new Celula();
            this.primeiro.elemento = null;
            this.ultimo = this.primeiro;
        }

        public bool Vazia()
        {
            return (this.primeiro == this.ultimo);
        }


        public void AddPrimeiro(Lote Obj)
        {
            Celula novo = new Celula();

            novo.elemento = Obj;
            novo.prox = this.primeiro.prox;
            this.primeiro.prox = novo;

            if (this.Vazia())
            {
                this.ultimo = this.primeiro.prox;
            }

            this.tam++;
        }

        public Lote RetirarPrimeiro()
        {
            Lote retirado = null;

            if (!this.Vazia())
            {
                /*retirado = this.primeiro.prox.elemento;

                this.primeiro.prox = this.primeiro.prox.prox;

                if (this.primeiro.prox == null)
                    this.ultimo = this.primeiro;

                this.tam--;*/
                
                this.aux = this.primeiro.prox;
                Celula ant = this.primeiro;
                while (this.aux != this.ultimo)
                {
                    ant = this.aux;
                    this.aux = this.aux.prox;
                }

                retirado = this.aux.elemento;
                ant.prox = null;
                this.ultimo = ant;

                //calculaValor(retirado.QtdLotes,retirado.Valor, 150, 30);

                this.tam--;
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            return (retirado);
        }


        public int calculaValor(int x, int y, int w, int z)
        {
            int zy;
            int valorTotal;
            //valorTotal = x + y;
            this.aux = this.primeiro.prox;
            this.aux = this.primeiro;

            //foreach (Lote l1 in lote)
            //{
            //s = valorVendidos - this.aux.elemento.valor;
            //valorTotal = valorTotal + (this.aux.elemento.qtdLotes * s);
            //s = lote.Valor - 1;
            //}

            zy = z - y;
            valorTotal = x * zy;

            return valorTotal;
        }

    }
}
