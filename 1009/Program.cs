using System;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, bonusVendas;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bonusVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bonusVendas *= 0.15;
            salario += bonusVendas;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
