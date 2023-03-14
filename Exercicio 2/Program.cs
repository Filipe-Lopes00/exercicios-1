namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a temperatura em Fahrenheit: ");
            double temp =Convert.ToDouble(Console.ReadLine());
            double c = (temp - 32) / 1.8;
            Console.WriteLine(" a temperatura em Celsius é: " + c );
        }
    }
}