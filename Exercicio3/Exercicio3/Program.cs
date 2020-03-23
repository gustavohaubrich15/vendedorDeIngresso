using System;
using System.Linq.Expressions;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorIngresso = 5;
            char digitado = '0';
            while (digitado!='1' && digitado!='2')
            {
                Console.WriteLine("Digite 1 para ingresso Normal");
                Console.WriteLine("Digite 2 para ingresso Vip");
                digitado = char.Parse(Console.ReadLine());

                switch (digitado)
                {
                    case '1':
                        Normal normal = new Normal(valorIngresso);
                        Console.WriteLine("----Ingresso Normal---");
                        normal.ExibirValorIngresso();
                        break;
                    case '2':
                        Console.WriteLine("----Ingresso Vip---");
                        char tipoVip = '0';
                        while (tipoVip != '1' && tipoVip != '2')
                        {
                            Console.WriteLine("Digite 1 para camarote superior");
                            Console.WriteLine("Digite 2 para camarote inferior");
                            tipoVip = char.Parse(Console.ReadLine());

                            switch (tipoVip)
                            {
                                case '1':
                                    CamaroteSuperior camaroteSuperior = new CamaroteSuperior(valorIngresso);
                                    Console.WriteLine("----Ingresso Camarote Superior ----");
                                    camaroteSuperior.ExibirValorIngresso();
                                    break;
                                case '2':
                                    CamaroteInferior camaroteInferior = new CamaroteInferior(valorIngresso);
                                    Console.WriteLine("----Ingresso Camarote Superior ----");
                                    camaroteInferior.ExibirValorIngresso();
                                    break;
                                default:
                                    Console.WriteLine("Opcao invalida");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("opcao invalida");
                        break;
                }
            }
        }
    }
}
