using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado area1;
            area1 = new Quadrado();

            Console.WriteLine("\n---------Exercício 3 da Lista 1---------\n");

            Console.Write("Insira o Valor da Diagonal do Quadrado(m): ");
            area1.setDiag(double.Parse(Console.ReadLine()));

            area1.calcular();

            Console.WriteLine("");

            Console.WriteLine("A área do quadrado de diagonal {0}m é {1}m²",
                area1.getDiag(), area1.getArea());
        }
    }
}
