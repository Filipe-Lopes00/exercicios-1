namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primo;

            Console.WriteLine("informe o numero primo: ");
            primo = Convert.ToInt32(Console.ReadLine());

            bool numeroPrimo = true;


            for (int i = 2; i < primo; i++)
            {
                if (primo % i == 0)
                {
                 numeroPrimo = false;

                }  

            }
            Console.WriteLine("é primo ?: " + numeroPrimo);
        }
    }
}