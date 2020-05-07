using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Program
    {

        static List<Enemy> enemies;
        static Player playerCharacter;
        static int enemyCount;
        static bool amountCheck = false;
        static void Main(string[] args)
        {
            playerCharacter = new Player();
            Console.WriteLine("How many enemies do you want to face");
            while (amountCheck ==false)
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
        static void Combat()
        {

            enemies = new List<Enemy>();
            
            for (int i = 0; i < enemyCount; i++)
            {
                enemies.Add(new Enemy());
            }
            Console.WriteLine(  "You will face {0} enemies", enemies.Count);

            enemies[0].TakeDmg(playerCharacter.Attack());
            Console.WriteLine(enemies[0].GetHp());

            playerCharacter.TakeDmg(enemies[0].Attack());
            Console.WriteLine(playerCharacter.GetHp());

            Console.ReadLine();

        }
    }


}
