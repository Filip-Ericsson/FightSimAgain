using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Program
    {
        static public int enemyCount; //Deklarerar två variablar som används när programmet vill veta hur många fiender som ska staplas i en stack senare. 
        static bool amountCheck = false;
       
        static void Main(string[] args)
        {
            Utils utilsClass = new Utils();
            Console.WriteLine("How many enemies do you want to face");
            while (amountCheck == false)
            {
                enemyCount = utilsClass.TryParse(); //kallar på tryParse metoden från Utils. 
                if (enemyCount <= 0)
                {
                    Console.WriteLine("Number has to be larger than 0"); //Om svaret inte är en siffra eller mindre än 0 får spelaren ett felmedelande
                }
                else
                {
                    amountCheck = true;
                }

            }
            Arena newArena = new Arena();
           

        }
        
        
        
    }


}
