using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Program
    {

        static Stack<Enemy> enemies;
        static Player playerCharacter;
        static int enemyCount;
        static bool amountCheck = false;
        static void Main(string[] args)
        {
            playerCharacter = new Player();
            Console.WriteLine("How many enemies do you want to face");
            while (amountCheck == false)
            {
                enemyCount = TryParse();
                if (enemyCount <= 0)
                {
                    Console.WriteLine("Number has to be larger than 0");

                }
                else
                {
                    amountCheck = true;
                }

            }
            PreCombat();
            Combat();

        }
        static int TryParse()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    return number;
                }
                else
                {
                    Console.WriteLine("You have to enter a number");
                }
            }
        }

        static void PreCombat()
        {
            enemies = new Stack<Enemy>();

            for (int i = 0; i < enemyCount; i++)
            {
                enemies.Push(new Enemy());
            }
            Console.WriteLine("You will face {0} enemies", enemies.Count);
        }
        static void Combat()
        {
            while (enemies.Count > 0 && playerCharacter.GetHp() > 0)
            {

                while (enemies.Peek().GetHp() > 0 && playerCharacter.GetHp() > 0)
                {
                    enemies.Peek().TakeDmg(playerCharacter.Attack());
                    Console.WriteLine(enemies.Peek().GetHp());

                    playerCharacter.TakeDmg(enemies.Peek().Attack());
                    Console.WriteLine(playerCharacter.GetHp());
                    Console.ReadLine();
                }
                if (enemies.Peek().GetHp() <= 0)
                {
                    enemies.Pop();

                    if (enemies.Count == 0)
                    {
                        Console.WriteLine("There are no enemies remaining");
                    }
                    else
                    {
                        Console.WriteLine("There are {0} enemies left", enemies.Count);
                    }

                }


            }


            Console.ReadLine();

        }
    }


}
