using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quilômetros conversao1;
            conversao1 = new Quilômetros();

            Console.WriteLine("\n---------Exercício 6 da Lista 1---------\n");

            Console.Write("Insira um Valor (em Milhas Marítimas): ");
            conversao1.setMilhaM(double.Parse(Console.ReadLine()));

            conversao1.calcular();

            Console.WriteLine("");

            Console.WriteLine("{0} Milhas Marítimas Equivalem á {1} Quilômetros",
                conversao1.getMilhaM(), conversao1.getKm());
        }
    }
}
