﻿using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vetUm = Console.ReadLine().Split(' ');
            int maior, maiorAB;

            A = int.Parse(vetUm[0]);
            B = int.Parse(vetUm[1]);
            C = int.Parse(vetUm[2]);
            // Fórmula para procurar o maior valor
            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maior + " eh o maior");

            Console.ReadLine();
        }
    }
}
