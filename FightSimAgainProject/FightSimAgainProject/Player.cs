using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Player:Character
    {

        public Player() //I konstruktorn värdesätter jag värdet på de tre ints' som deklarerades i parent classen Character.
        {
            hp = 10;
            armour = 2;
            attackDmg = 5;
        }

        
        public override void TakeDmg(int DmgTaken) // speciellt för spelaren är att den har armour vilket gör att den tar värdet av armouren mindre från attacker.
        {
            DmgTaken = DmgTaken - armour; //tar man 5 skada och har 2 armour tar man 3 skada.
            base.TakeDmg(DmgTaken);
        }

    }
}
