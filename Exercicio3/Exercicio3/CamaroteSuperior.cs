using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class CamaroteSuperior : Vip
    {
        private const double ValorAdicional = 5.53;
        public CamaroteSuperior(double valor) : base(valor)
        {
            this.Valor += ValorAdicional;
        }
        public override void ExibirValorIngresso()
        {
            Console.WriteLine("Valor do  Ingresso Camarote Superior = " + this.Valor.ToString("C"));
        }
    }
}
