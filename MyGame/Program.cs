using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int enemyNumbers = int.Parse(args[0]);
            Enemy[] enemiesList = new Enemy[enemyNumbers];

            for (int i = 0; i < enemyNumbers; i++)
            {
                Console.WriteLine($"Nome do inimigo {i+1}:");
                string nameInputed = Console.ReadLine();
                enemiesList[i] = new Enemy(nameInputed);
            }

            foreach (Enemy enemyListed in enemiesList)
            {
                Console.WriteLine($"{enemyListed.GetName()} {enemyListed.GetHealth()} {enemyListed.GetShield()}");
            }

        }
    }
}
