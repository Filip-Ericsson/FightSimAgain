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

            playerCharacter = new Player();//skapar en stack för enemies som spelaren kommer att slåss mot i spelet.
            enemies = new Stack<Enemy>();//skapar en instans för spelarkaraktären

            for (int i = 0; i < Program.enemyCount; i++) //I program.cs fick spelaren välja hur många fiender som hen ville möta
            {
                enemies.Push(new Enemy()); //så många instanser av enemies pushas in i stacken
            }
            Console.WriteLine("You will face {0} enemies", enemies.Count);
            Combat();
        }

        static void Combat()
        {
            Utils utilsClass = new Utils();

            
            while (enemies.Count > 0 && playerCharacter.GetHp() > 0)//sålänge det finns instanser av enemies i stacken och spelaren har mer än 0 hp körs combat
            {

                while (enemies.Peek().GetHp() > 0 && playerCharacter.GetHp() > 0) //om spelaren och den översta instansen av en enemy har mer än 0 hp körs själva "attack fasen" av combat
                {
                    bool attackCheck = false;
                    while (attackCheck == false) //spelaren får välja om hen vill slå en light eller heavy attack
                    {
                        int attackOption;
                        Console.WriteLine("Light attack press: 1\nHeavy Attack press: 2");
                        attackOption = utilsClass.TryParse(); //kallar till utilsClass.TryParse igen

                        if (attackOption == 1)//light attack gör standard skadan för en playerCharacter
                        {
                            enemies.Peek().TakeDmg(playerCharacter.Attack());
                            attackCheck = true;
                        }
                        else if (attackOption == 2)//en heavy attack gör playerCharacters attackDmg*2
                        {
                            enemies.Peek().TakeDmg(playerCharacter.Attack() * 2);
                            attackCheck = true;
                        }
                        else //om spelaren inte skriver 1 eller 2
                        {
                            Console.WriteLine("Please choose 1 or 2");
                            attackCheck = false;
                        }
                    }
                    //programmet beräknar hur mycket skada spelaren tog av enemies och skriver det nuvarande hpt av den översta enemies och playerCharacter
                    Console.WriteLine("Enemy hp: " + enemies.Peek().GetHp());
                    playerCharacter.TakeDmg(enemies.Peek().Attack());
                    Console.WriteLine("Players hp: " + playerCharacter.GetHp());
                    Console.ReadLine();
                }
                if (enemies.Peek().GetHp() <= 0)//om den översta instansen av enemies har mindre eller 0 hp förstörs den översta. 
                {
                    enemies.Pop();

                    if (enemies.Count == 0) //om inga är kvar har spelaren vunnigt
                    {
                        Console.WriteLine("There are no enemies remaining");
                    }
                    else //om stacken inte är tomm.
                    {
                        Console.WriteLine("There are {0} enemies left", enemies.Count);
                    }
                }
            }
            if (playerCharacter.GetHp() > 0)
            {
                Console.WriteLine("Congratulations Challenger! You defeated all the opponents!");

            }
            else
            {
                Console.WriteLine("You have been defeated in combat... Unfortunate for you");
            }


            Console.ReadLine();

        }
    }
}
