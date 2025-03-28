using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int dados = int.Parse(args[0]);
            int semente = int.Parse(args[1]);

            Random random = new Random(semente);
        
            int soma = 0;
            for (int i = 0; i < dados; i++)
            {
                int lancamento = random.Next(1, 7); 
                soma += lancamento;
            }

            Console.WriteLine(soma);
        }
    }
}
