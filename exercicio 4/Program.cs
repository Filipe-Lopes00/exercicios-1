namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial, kmFinal, distancia, consumo, consumoPorKm;


            Console.WriteLine("informe a Quilometragem inicial: ");
            kmInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("informe kmFinal: ");
            kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("informe consumo: ");
            consumo = double.Parse(Console.ReadLine());
            distancia = kmFinal - kmInicial;
            consumoPorKm = distancia / consumo;
            Console.WriteLine("o resultado do consumo é: "+ consumoPorKm);

        }
    }
}