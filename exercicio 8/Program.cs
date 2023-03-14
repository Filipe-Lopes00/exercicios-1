namespace exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, raio;

            Console.WriteLine("informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o Raio: ");
            raio = double.Parse(Console.ReadLine());



            Console.WriteLine("o volume da lata de oleo é: " + (altura * raio * raio * 3.14));
        }
    }
}