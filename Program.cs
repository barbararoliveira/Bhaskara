using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ----- CALCULADORA DE EQUAÇÕES DE SEGUNDO GRAU ----- \n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Olá usuário, digite os valores:");
            
            Console.Write("a: ");
                    a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
                    b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
                    c = Convert.ToDouble(Console.ReadLine());
            
            if (a == 0)

           {
            Console.WriteLine("Não é uma equação de segundo grau.");
            Environment.Exit(-1);
           }
           
            delta = (b*b) - (4*a*c);
            
            if (delta < 0)

           {
            Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais.");
            Environment.Exit(-1);
           }

            if (a >=1 && delta >=1)

           {    
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"x1 = {x1} e x2 = {x2}");
            Environment.Exit(-1);
           }       
   
           Console.WriteLine ("Pressione enter para finalizar.");
           Console.ReadKey();
        }
    }
}
