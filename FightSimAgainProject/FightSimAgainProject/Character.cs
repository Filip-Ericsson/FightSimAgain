using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimAgainProject
{
    class Character
    {
        protected int armour;
        protected int hp;
        protected int attackDmg;

        public virtual int Attack()
        {
            return attackDmg;
        }

        public virtual void TakeDmg(int DmgTaken)
        {
            hp -= DmgTaken;
        }

        public int GetHp()
        {
            return hp;
        }
    }

    
}
