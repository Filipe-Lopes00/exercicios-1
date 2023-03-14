namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paoVendido, broaVendido, total, poupanca;

            Console.WriteLine("quantos paes foram vendidos?: ");
            paoVendido = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("quantas Broas foram vendidas?: ");
            broaVendido = Convert.ToDouble(Console.ReadLine());

            total = (paoVendido * 0.12) + (broaVendido * 1.50);
            poupanca = total * 0.10; //mesma coisa q 10% ou q dividido por 100

            Console.WriteLine("o valor do total é:" + total);
            Console.WriteLine("o valor da poupança é: " + poupanca);



        }
    }
}