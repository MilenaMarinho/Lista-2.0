﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo area1;
            area1 = new Retangulo();

            Console.WriteLine("\n---------Exercício 1 da Lista 1---------\n");

            Console.Write("Insira o Valor da Base do Retângulo(m): ");
            area1.setB(double.Parse(Console.ReadLine()));

            Console.Write("Insira o Valor da Altura do Retângulo(m): ");
            area1.setH(double.Parse(Console.ReadLine()));

            area1.calcular();

            Console.WriteLine("");

            Console.WriteLine("A Área do Retângulo de Base {0}m e Altura {1}m é {2}m²",
                area1.getB(), area1.getH(), area1.getArea());
        }
    }
}
