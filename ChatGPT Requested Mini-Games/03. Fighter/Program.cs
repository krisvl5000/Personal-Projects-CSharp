using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize player and enemy
            int playerHealth = 100;
            int enemyHealth = 150;

            // Game loop
            while (playerHealth > 0 && enemyHealth > 0)
            {
                // Display health
                Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Enemy Health: " + enemyHealth);

                // Display menu
                Console.WriteLine("1. Punch");
                Console.WriteLine("2. Kick");
                Console.WriteLine("3. Heal");
                Console.Write("Choose an action: ");

                // Get player input
                int playerChoice = int.Parse(Console.ReadLine());

                // Player attack
                if (playerChoice == 1)
                {
                    Console.WriteLine("Player punched enemy for 10 damage.");
                    enemyHealth -= 10;
                }
                else if (playerChoice == 2)
                {
                    Console.WriteLine("Player kicked enemy for 15 damage.");
                    enemyHealth -= 15;
                }
                else if (playerChoice == 3)
                {
                    Console.WriteLine("Player healed for 20 health.");
                    playerHealth += 20;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                // Enemy attack
                Random rnd = new Random();
                int enemyChoice = rnd.Next(1, 3);
                if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy punched player for 5 damage.");
                    playerHealth -= 5;
                }
                else if (enemyChoice == 2)
                {
                    Console.WriteLine("Enemy kicked player for 8 damage.");
                    playerHealth -= 8;
                }

                // Check for victory or defeat
                if (playerHealth <= 0)
                {
                    Console.WriteLine("Player has been defeated.");
                }
                else if (enemyHealth <= 0)
                {
                    Console.WriteLine("Enemy has been defeated.");
                }

                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
