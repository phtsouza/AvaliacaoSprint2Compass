using System;

namespace _1251
{

    // Classe criada para armazenar os dados de uma letra
    public class Dados
    {
        public int freq;
        public int asc;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Dados[] palavra = new Dados[1001];
            bool[] visto = new bool[1001];
            int i, j, k = 0;
            int contFreq = 0;

            text = Console.ReadLine(); // Armazena o texto informado.

            for (i=0; i<=1000; i++)
            {
                visto[i] = false;
            }
            while(text != null)
            {
                for (i = 0; i < text.Length; i++)
                {
                    contFreq = 0;
                    palavra[k] = new Dados();

                    if (!visto[i])
                    {
                        for (j = 0; j < text.Length; j++)
                        {
                            if (text[i] == text[j])
                            {
                                contFreq++;
                                visto[j] = true;  // Armazena se uma letra já foi vista ou não
                            }
                        }
                    }
                    palavra[k].asc = (int)text[i];
                    palavra[k].freq = contFreq;
                    k++;
                }

                OrdenaAsc(palavra, k);
                OrdenaFreq(palavra, k);

                for (i = 0; i < k; i++)
                {
                    if (palavra[i].freq != 0)
                    {
                        Console.WriteLine(palavra[i].asc + " " + palavra[i].freq);
                    }
                }
                Console.WriteLine();
                text = Console.ReadLine();
            }
            
        }

        // Função feita para ordenar os dados em relação a tabela asc.
        static void OrdenaAsc(Dados[] palavra, int tam)
        {
            Dados aux;
            int i, j;

            for(i = 0; i<tam; i++)
            {
                for(j = i+1; j< tam; j++)
                {
                    if(palavra[i].asc > palavra[j].asc)
                    {
                        aux = palavra[i];
                        palavra[i] = palavra[j];
                        palavra[j] = aux;
                    }
                }
            }
        }

        // Função feita para ordenar os dados em relação a sua frequência.
        static void OrdenaFreq(Dados[] palavra, int tam)
        {
            Dados aux;
            int i, j;

            for (i = 0; i < tam; i++)
            {
                for (j = i + 1; j < tam; j++)
                {
                    if (palavra[i].freq > palavra[j].freq)
                    {
                        aux = palavra[i];
                        palavra[i] = palavra[j];
                        palavra[j] = aux;
                    }
                }
            }
        }
    }
}
