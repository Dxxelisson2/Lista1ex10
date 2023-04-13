using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1_ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double cot, quantidade, reais;
            Console.WriteLine("Digite a quantidade de dolares");
            quantidade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da cotação:");
            cot = Convert.ToDouble(Console.ReadLine());

            reais = quantidade * cot;

            Console.WriteLine("o valor em reais é: R$" + reais);

            Console.ReadKey();
        }
    }
}
