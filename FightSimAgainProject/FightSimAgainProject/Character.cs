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
        protected int attackDmg; //deklarerar lite variabler till basklassen character som både fienden och spelare ärver ifrån

        public virtual int Attack()
        {
            return attackDmg; //Attack metoden returnerar instansens värde på attackDmg, är virtual så children till klassen kan göra mer specifika för sig.
        }

        public virtual void TakeDmg(int DmgTaken) //instansens hp- en int som innehåller hur mycket skada instansen tog.
        {
            hp -= DmgTaken;
        }
                       
        public int GetHp()//returnerar värdet på int:en hp
        {
            return hp;
        }
    }

    
}
