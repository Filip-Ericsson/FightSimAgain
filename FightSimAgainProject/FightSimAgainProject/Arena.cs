using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{

    class Arena
    {
        static Stack<Enemy> enemies;
        static Player playerCharacter;
        public Arena()
        {

            playerCharacter = new Player();
            enemies = new Stack<Enemy>();

            for (int i = 0; i < Program.enemyCount; i++)
            {
                enemies.Push(new Enemy());
            }
            Console.WriteLine("You will face {0} enemies", enemies.Count);
            Combat();
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
