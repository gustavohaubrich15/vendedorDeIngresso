using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class Normal : Ingresso
    {
        public Normal(double valor) : base(valor)
        {
        }

        public override void ExibirValorIngresso()
        {
            Console.WriteLine("Valor do  Ingresso Normal = " + this.Valor.ToString("C"));
        }
    }
}
