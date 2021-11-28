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

            while (sentenca != null)
            {
                for(i = 0; i< sentenca.Length; i++)
                {
                    if(sentenca[i].ToString() != " ")
                    {
                        if(letraPassada)
                        {
                            Console.Write(sentenca[i].ToString().ToLower());
                            letraPassada = false;
                        }
                        else
                        {
                            Console.Write(sentenca[i].ToString().ToUpper());
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
