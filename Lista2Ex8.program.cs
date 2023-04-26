using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Formação de triângulos retângulos:");
            Console.Write("Digite o valor da primeira aresta:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da segunda aresta:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da terceira aresta:");
            c = double.Parse(Console.ReadLine());

            

            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("É um triângulo retângulo");
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("É um triângulo retângulo");
            }
            else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("É um triângulo retângulo");
            }
            else 
            {
                Console.WriteLine("Não é um trângulo retângulo");
            }
        }
    }
}
