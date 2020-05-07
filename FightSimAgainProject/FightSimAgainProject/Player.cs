using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Player:Character
    {

        public Player()
        {
            hp = 10;
            armour = 2;
            attackDmg = 5;
        }
        public override void TakeDmg(int DmgTaken)
        {
            DmgTaken = DmgTaken - armour;
            base.TakeDmg(DmgTaken);
        }

    }
}
