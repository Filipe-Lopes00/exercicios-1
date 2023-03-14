namespace exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a temperatura em celcius: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double f = (temp * 1.8) + 32;
            Console.WriteLine(" a temperatura em Fahrenhei é: " + f);
        }
}