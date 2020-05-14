using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Program
    {
        static public int enemyCount;
        static bool amountCheck = false;
        static void Main(string[] args)
        {
            
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
            Arena newArena = new Arena();
           

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
        
        
    }


}
