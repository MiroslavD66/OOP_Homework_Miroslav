using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Samurai : Hero
    {
        public Samurai(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            if (Health < 250) // 35% more damage if health drops below 50%
            {
                baseAttack = (int)(baseAttack * 1.50);
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (Health < 250) // 35% reduced damage if health drops below 50%
            {
                incomingDamage = (int)(incomingDamage * 0.65);
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
