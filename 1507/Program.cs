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

            qntdCasos = int.Parse(Console.ReadLine());

            for(i=0; i<qntdCasos; i++)
            {
                principal = Console.ReadLine();
                qntdString = int.Parse(Console.ReadLine());
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
