namespace exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("informe o valor A! ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o valor de B");
            b = Convert.ToDouble(Console.ReadLine());

            if (a == b )
            {
                c = (a + b);
                Console.WriteLine(c);
            }
            else
            {
                c = (a * b);
                Console.WriteLine(c);
            }
        }
    }
}