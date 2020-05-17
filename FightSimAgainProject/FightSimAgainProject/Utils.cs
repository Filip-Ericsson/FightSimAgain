using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Utils
    {
        public  int TryParse()//en väldigt standard tryParse
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
