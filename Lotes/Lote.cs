using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lotes
{
    class Lote
    {
        /*Atributos*/


        private int qtdLotes; //o x
        public int QtdLotes
        {

            get { return (this.qtdLotes); }
            set { this.qtdLotes = value; }
        }

        private int valor; //o y
        public int Valor
        {

            get { return (this.valor); }
            set { this.valor = value; }
        }


        /*Construtor*/
        public Lote(int qtdLotes, int valor)
        {

            this.qtdLotes = qtdLotes;
            this.valor = valor;
        }

        public List<Lote>(int qtdLotes, int valor)
        {
            
            this.qtdLotes = qtdLotes;
            this.valor = valor;
        }
}
}
