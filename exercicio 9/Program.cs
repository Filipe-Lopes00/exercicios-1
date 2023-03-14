namespace exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, mediaHarmonica;
            Console.WriteLine("Digite a nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            mediaHarmonica = 2 / (1 / nota1 + 1 / nota2);

            Console.WriteLine("media armonica é: "+ mediaHarmonica);
        }
    }
}