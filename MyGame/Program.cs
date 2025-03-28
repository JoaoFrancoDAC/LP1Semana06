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




            Enemy testEnemy = new Enemy("Teste");
            Console.WriteLine($"Spawnou agora:\nNome: {testEnemy.GetName()}\nVida: {testEnemy.GetHealth()}\nEscudo: {testEnemy.GetShield()}\n\n\n");


            testEnemy.PickupPowerUp(PowerUp.Shield, 30);
            Console.WriteLine($"Pegou 30 de shield aqui: \nNome: {testEnemy.GetName()} \nVida: {testEnemy.GetHealth()}\nEscudo: {testEnemy.GetShield()}\n\n\n");

            testEnemy.TakeDamage(60);
            Console.WriteLine($"Tomou 60 de damage aqui: \nNome: {testEnemy.GetName()}\nVida: {testEnemy.GetHealth()}\nEscudo: {testEnemy.GetShield()}\n\n\n");

            testEnemy.PickupPowerUp(PowerUp.Health, 31);
            Console.WriteLine($"Pegou 31 de cura aqui: \nNome: {testEnemy.GetName()}\nVida: {testEnemy.GetHealth()}\nEscudo: {testEnemy.GetShield()}\n\n\n");


            Console.WriteLine($"Total de PowerUps coletados(Tem que ser 2): {Enemy.GetTotalPowerUps()}");

        }
    }
}
