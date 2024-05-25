using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Archer : Hero
    {
        public Archer(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice < 30) // 30% chance for critical hit
            {
                baseAttack *= 2;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            incomingDamage = incomingDamage - (incomingDamage / 20); // Reduce damage by 20%
            base.TakeDamage(incomingDamage);
        }
    }
}
