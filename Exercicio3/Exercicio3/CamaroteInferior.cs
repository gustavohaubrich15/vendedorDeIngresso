using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio3
{
    public class CamaroteInferior : Vip
    {
        public CamaroteInferior(double valor) : base(valor)
        {
        }
        public override void ExibirValorIngresso()
        {
            Console.WriteLine("Valor do  Ingresso Camarote Inferior = " + this.Valor.ToString("C"));
        }
    }
}
