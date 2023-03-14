namespace ListaExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor da base: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o valor da altura");
            double altura = Convert.ToDouble(Console.ReadLine());   

            Console.WriteLine("informe o valor do lado");
            double lado = Convert.ToDouble(Console.ReadLine());

            double volume = b * altura * lado;
            Console.WriteLine("resultado é: " + volume);



        }
    }
}