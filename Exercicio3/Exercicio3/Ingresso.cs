using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public abstract class Ingresso
    {
        public double Valor { get; set; }

        public Ingresso(double valor)
        {
            this.Valor = valor;
        }

        public abstract void ExibirValorIngresso();
        
    }
}
