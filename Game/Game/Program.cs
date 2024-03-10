using System;

class Game
{
    static void Main()
    {

        int playerHealth = 20;
        int enemyHealth = 20;

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("You have " + playerHealth + " health.");

            if (enemyHealth == 20)
            {
                Console.WriteLine("You have encountered a vicious skeleton monster that has " + enemyHealth + " health.");
            }
            else
            {
                Console.WriteLine("The monster has " + enemyHealth + " health.");
            }
            Console.WriteLine("Type 'punch' or 'fire fist' to deal damage or 'block' to protect yourself from incoming strikes and 'Heal' to heal yourself.");

            string? choice = Console.ReadLine();

            if (choice == "punch")
            {
                int playerAttack = new Random().Next(2, 4); //Simulate players atk dmg
                Console.WriteLine("You attacked the skeleton! You have dealt 2 damage");
                enemyHealth -= playerAttack;
            }

            if (choice == "fire fist")
            {
                int playerAttack = new Random().Next(5, 6); //Simulate players skill dmg
                Console.WriteLine("You attacked the skeleton! You have dealt 2 damage");
                enemyHealth -= playerAttack;
            }

            int playerHeal = 2;
            int enemyAttack = new Random().Next(3, 5);

            if (choice == "heal")
            {
                int enemyatknull = 0;
                Console.WriteLine("you have healed by 2 points");
                playerHealth += playerHeal;
                enemyAttack = enemyatknull; //nulls enemy atk when you heal
            }


            if (choice != "block")
            {
                Console.WriteLine($"The skeleton attacked you! It dealt {enemyAttack} damage.");
                playerHealth -= enemyAttack;
            }

            else if (choice == "block")
            {
                // Reduce enemy's damage when blocking
                int blockDamageReduction = 3; // Assuming blocking reduces damage by 3
                Console.WriteLine("You blocked the attack! You received " + enemyAttack + " damage.");
                enemyAttack -= blockDamageReduction; // Simulate enemy attack damage with reduction
            }



            // Check if either player or enemy health has dropped to zero or below
            if (playerHealth <= 0)
            {
                Console.WriteLine("You have been defeated! Game Over!");
                break;
            }
            if (enemyHealth <= 0)
            {
                Console.WriteLine("You have defeated the skeleton! You win!");
                break;
            }
        }
        Console.ReadKey();
    }
}
