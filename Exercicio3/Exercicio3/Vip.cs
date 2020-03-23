using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public abstract class Vip : Ingresso
    {
        private const double ValorAdicional = 6.87;
        public Vip(double valor) : base(valor)
        {
            this.Valor += ValorAdicional;
        }
    }
}
