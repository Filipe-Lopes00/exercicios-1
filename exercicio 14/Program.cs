namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, diasDeVida;
            string nome;

            Console.WriteLine("digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite seu nome: ");
            nome = Console.ReadLine();

            diasDeVida = idade * 365;
            Console.WriteLine(nome + "Voce ja viveu "+ diasDeVida+" dias");



        }
    }
}