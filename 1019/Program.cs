using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            int hors, min;

            sec = int.Parse(Console.ReadLine());
            // Determinas quantas horas tem em N segundos
            hors = sec / 3600;
            sec = sec - (hors * 3600);
            // Determinar quantas minutos tem no valor restante de N segundos
            min = sec / 60;
            sec = sec - (min * 60);

            Console.WriteLine(hors + ":" + min + ":" + sec);
        }
    }
}
