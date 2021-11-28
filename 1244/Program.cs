using System;

namespace _1244
{
    class Program
    {
        static void Main(string[] args)
        {
            int casos;
            string[] palavras;
            int i, j;

            casos = int.Parse(Console.ReadLine()); // Armazena o número de casos

            for(i = 0; i<casos; i++)
            {
                palavras = Console.ReadLine().Split(' ');
                OrdenaStringTam(palavras);
                for(j = 0; j < palavras.Length; j++)
                {
                    Console.Write(palavras[j]);
                    if (j == palavras.Length - 1)
                        continue;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        /*
         Função feita para determinar o tamanho das palavras dentro de uma string 
         Entrada: String
         Saída: Tamanho da palavra
        */
        public static int[] TamPalavra(String[] palavras)
        {
            int[] tamPalavras = new int[palavras.Length];
            int i;
            for (i = 0; i < palavras.Length; i++){
                tamPalavras[i] = palavras[i].Length;
            }
            return tamPalavras;
        }

        /*
         Função feita para ordenar a string em relação ao tamanho das palavras
         Entrada: String
         Saída: String ordenada em relação ao tamanho das palavras dentro dela
        */
        public static void OrdenaStringTam(String[] palavras)
        {
            int[] tamPalavras = TamPalavra(palavras);
            int i, j;

            for (i=0; i < palavras.Length - 1; i++)
            {
                for(j=0; j<palavras.Length-i-1; j++)
                {
                    if(tamPalavras[j] < tamPalavras[j + 1])
                    {
                        TrocaString(j, j + 1, palavras, tamPalavras);
                    }
                }
            }
        }

        /*
         Função feita para trocar uma string com outra.
         Entrada: posição de troca, string e o seu tamanho.
         Saída: string trocada com as posições informadas.
        */
        public static void TrocaString(int pos1, int pos2, string[] palavras, int[] tamPalavras)
        {
            string aux = palavras[pos1];
            int tamAux = tamPalavras[pos1];

            palavras[pos1] = palavras[pos2];
            tamPalavras[pos1] = tamPalavras[pos2];
            palavras[pos2] = aux;
            tamPalavras[pos2] = tamAux;
        }
    }
}
