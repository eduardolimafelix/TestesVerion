using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotes
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
                retirado = this.primeiro.prox.elemento;

                this.primeiro.prox = this.primeiro.prox.prox;

                if (this.primeiro.prox == null)
                    this.ultimo = this.primeiro;

                this.tam--;
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            return (retirado);
        }


        public int calculaValor(int valorVendidos)
        {
            int s;
            int valorTotal;

            this.aux = this.primeiro.prox;

            for ()
            {
                s = valorVendidos - this.aux.elemento.valor;
                valorTotal = valorTotal + (this.aux.elemento.qtdLotes * s);
            }

            return (valorTotal);
        }


    }
}
