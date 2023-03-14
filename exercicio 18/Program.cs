namespace exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)


        {
            double a, b, c;
            Console.WriteLine("informe o valor a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o valor b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o valor c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > b && b > c) Console.WriteLine($"{a} {b} {c}");

            else if (a > c && c > b) Console.WriteLine($"{a} {c} {b}");

            else if (b > a && a > c) Console.WriteLine($"{b} {a} {c}");

            else if (b > c && c > a) Console.WriteLine($"{b} {c} {a}");

            else if (c > a && a > b) Console.WriteLine($" {c} {a} {b}");

            else if (c > b && b > a) Console.WriteLine($" {c} {b} {a}");








        }
    }
}