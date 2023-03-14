using System.ComponentModel.Design;

namespace exercicios_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Informe o valor de A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B");
            b = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe o valor de C");
            c = Convert.ToInt32(Console.ReadLine());

           if (a + b <c) 
            {
                Console.WriteLine($"a soma de {a} + {b} é menor que {c}");
            }
           else 
            { 
                Console.WriteLine($"a soma de {a} + {b} é maior que {c}");
            
            }
        
        
        }  



    }
}