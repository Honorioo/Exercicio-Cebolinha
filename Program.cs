using System;

namespace Exercicio_Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           Console.Beep(); 
            
            String Cebolinha;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------Fale Igual ao Cebolinha da Turma da Monica---------------");
            Console.ResetColor();
            Console.Write("Escreva algo: ");
            Cebolinha = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Cebolinha.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("r","l").Replace("R","L")}");
            Console.ResetColor();
           
        
        }
    }
}
