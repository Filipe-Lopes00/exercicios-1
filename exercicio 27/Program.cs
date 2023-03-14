namespace exercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaFahrenheit, temperaturaCelsius;

            Console.WriteLine(" Digite a temperatura em Graus Fahrenheit: ");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
            Console.WriteLine("a temperatura em graus celsius é: " + temperaturaCelsius);


        }
    }
}