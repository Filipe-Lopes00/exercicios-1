using System.Net.NetworkInformation;

namespace exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totaldeVendas, comissao, salarioFinal;

            Console.WriteLine("informe o salario base: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o total de vendas: ");
            totaldeVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("informe a comissao: ");
            comissao = double.Parse(Console.ReadLine());

            salarioFinal = salarioBase + (totaldeVendas * comissao / 100);

            Console.WriteLine("o salario final é" + salarioFinal);

            Console.ReadLine();



        }
    }
}