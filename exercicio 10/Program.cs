namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, peso1, nota2, peso2, mediaPonderada;

            Console.WriteLine("informe o valor da nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o peso 1: ");
            peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o peso2: "); 
            peso2 = Convert.ToDouble(Console.ReadLine());


            mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            Console.WriteLine( "o valor da media ponderada é : "+ mediaPonderada);
            

        }
    }
}