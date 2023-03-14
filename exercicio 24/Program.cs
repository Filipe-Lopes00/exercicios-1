namespace exercicio_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Hello, World!");

            for (int i = 0; i <= 500 ; i++) 
            {
                if (i % 2 == 1 && i % 3 == 0)
                 n += i;   


            }

            Console.WriteLine(n);

        }
    }
}