using System;

namespace _1259
{
    class Program
    {
        static void Main(string[] args)
        {
            int entradas;
            int[] par = new int[100001];
            int[] impar = new int[100001];
            int j = 0, i = 0, k;
            int n;

            entradas = int.Parse(Console.ReadLine());

            for (k = 0; k < entradas; k++)
            {
                n = int.Parse(Console.ReadLine()); // Armzena os valores das entradas.

                if (n % 2 == 0) // Separa os valores informados em par ou ímpar.
                {
                    par[i] = n;
                    i++;
                }
                else
                {
                    impar[j] = n;
                    j++;
                }
            }

            MergeSort(par, 0, i -1);
            MergeSort(impar, 0, j -1);

            PrintaVetor(par, i);
            PrintaVetorInvertido(impar, j);
            
        }

        static void Merge(int[] vet, int esq, int mid, int dir)
        {
            int[] esqVet = new int[mid - esq + 1];
            int[] dirVet = new int[dir - mid];
            int j = 0, i = 0, k;
            Array.Copy(vet, esq, esqVet, 0, mid - esq + 1);
            Array.Copy(vet, mid + 1, dirVet, 0, dir - mid);
            
            for(k = esq; k < dir + 1; k++)
            {
                if(i == esqVet.Length)
                {
                    vet[k] = dirVet[j];
                    j++;
                }
                else if(j == dirVet.Length)
                {
                    vet[k] = esqVet[i];
                    i++;
                }
                else if(esqVet[i] <= dirVet[j])
                {
                    vet[k] = esqVet[i];
                    i++;
                }
                else
                {
                    vet[k] = dirVet[j];
                    j++;
                }
            }
        }

        // Realiza a ordenção do vetor.
        static void MergeSort(int[] vet, int esq, int dir)
        {
            if(esq < dir)
            {
                int mid = (esq + dir) / 2;

                MergeSort(vet, esq, mid);
                MergeSort(vet, mid + 1, dir);

                Merge(vet, esq, mid, dir);
            }
        }

        // Procedimento feito para printa o vetor em ordem crescente
        static void PrintaVetor(int[] vet, int tam)
        {
            int k;
            for (k = 0; k < tam; k++)
            {
                Console.WriteLine(vet[k]);
            }
        }

        // Procedimento feito para printa o vetor em ordem decrescente
        static void PrintaVetorInvertido(int[] vet, int tam)
        {
            int k;
            for(k = tam-1; k>-1; k--)
            {
                Console.WriteLine(vet[k]);
            }
        }
    }
}
