namespace exercicio_3
{
    internal class Program
    {// criar variavel pi
        static void Main(string[] args)


        {
            double altura, raio;

            Console.WriteLine("informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o Raio: ");
            raio = double.Parse(Console.ReadLine());
            


            Console.WriteLine("o volume do cilindro é: " + (altura*raio*raio*3.14));







        }
    }
}