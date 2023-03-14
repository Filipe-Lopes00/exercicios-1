namespace exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, raio;
            Console.WriteLine("informe o raio :");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4 * 3.14 * raio * raio * raio) / 3;

            Console.WriteLine("o valor do volume é :"+ volume);

        }
    }
}