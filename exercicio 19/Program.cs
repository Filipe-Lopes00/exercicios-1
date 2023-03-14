namespace exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("informe o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5) Console.WriteLine("abaixo do peso!");

            else if (imc >= 18.5 && imc < 25) Console.WriteLine("Peso normal");

            else if (imc >= 25 && imc < 30) Console.WriteLine("acima do peso");

            else Console.WriteLine("Obeso");


        }
    }
}