using System;

namespace _1507
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntdCasos;
            int qntdString;
            string principal, subString;
            int i, j;

            qntdCasos = int.Parse(Console.ReadLine()); // Armazena a quantidade de casos.

            for(i=0; i<qntdCasos; i++)
            {
                principal = Console.ReadLine(); // Armazena a string principal
                qntdString = int.Parse(Console.ReadLine()); // armazena a quantidade de strings a serem comparadas
                for (j = 0; j < qntdString; j++)
                {
                    subString = Console.ReadLine();
                    if(isSubString(principal, subString))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }

        // Procedimento feito para analisar se uma string é substring da outra.
        static bool isSubString(string frase, string sub)
        {
            int tamString = frase.Length;
            int tamSub = sub.Length;
            int i, j;

            for(i = 0, j = 0; j < tamSub && i < tamString; i++)
            {
                if(sub[j] == frase[i])
                {
                    j++;
                }
            }

            if(j == tamSub)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
