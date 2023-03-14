namespace exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioInicial, salarioAumentado, salarioFinal;

            Console.WriteLine("digite o valor do salario inicial: ");
            salarioInicial = Convert.ToDouble(Console.ReadLine());

            salarioAumentado = salarioInicial * 1.15;      //o numero 1 representa o 100%

            salarioFinal = salarioAumentado * 0.92;

            Console.WriteLine("o salario inicial é: " + salarioInicial);
            Console.WriteLine("o salario aumentado é: " + salarioAumentado);
            Console.WriteLine("o salario final é: " + salarioFinal);



        }
    }
}