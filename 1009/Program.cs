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

            nome = Console.ReadLine(); // Armazena o nome do empregado.
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Armazena seu salário
            bonusVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Armazena o número de vendas

            bonusVendas *= 0.15;
            salario += bonusVendas; // Realiza a bonificação do salário em relação ao número de vendas

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
