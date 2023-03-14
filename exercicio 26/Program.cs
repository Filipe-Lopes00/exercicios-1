namespace exercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("digite o valor inicial: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = a-1; i > 0; i--) 
               
            {
                a = a * i; //implementaçao para aparecer o resultado
                
            
            }
            Console.WriteLine(a);
        }
    }
}