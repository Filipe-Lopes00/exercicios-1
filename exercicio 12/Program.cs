namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double frente, lado, area;

            Console.WriteLine("informe o valor da frente: ");
            frente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o valor do lado: ");
            lado = Convert.ToDouble(Console.ReadLine());

            area = frente * lado;
            Console.WriteLine("a dimensao é: " + area);

        }
    }
}