using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            int dados = int.Parse(args[0]);
            int semente = int.Parse(args[1]);

            // Inicializa o gerador de números aleatórios com a semente fornecida
            Random random = new Random(semente);

            // Lança os dados e soma os resultados
            int soma = 0;
            for (int i = 0; i < dados; i++)
            {
                int lancamento = random.Next(1, 7); // Gera um número entre 1 e 6
                soma += lancamento;
            }

            // Mostra o resultado
            Console.WriteLine(soma);
        }
    }
}
