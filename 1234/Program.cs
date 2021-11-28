using System;
using System.Text;

namespace _1234
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenca;
            bool letraPassada = false;
            int i = 0;
            sentenca = Console.ReadLine();

            while (sentenca != null) // Enquanto a sentença for diferente de nula
            {
                for(i = 0; i< sentenca.Length; i++)
                {
                    if(sentenca[i].ToString() != " ")
                    {
                        if (letraPassada) // Se a letra passada for maiúscula
                        {
                            Console.Write(sentenca[i].ToString().ToLower()); // Transforama a letra em minúscula
                            letraPassada = false;
                        }
                        else // Se a letra passada for minúsucula
                        {
                            Console.Write(sentenca[i].ToString().ToUpper()); // Transforma a letra em maiúsucula
                            letraPassada = true;
                        }
                    }
                    else
                    {
                        Console.Write(sentenca[i]);
                    }
                }
                Console.WriteLine();
                sentenca = Console.ReadLine();
            }
        }
    }
}
