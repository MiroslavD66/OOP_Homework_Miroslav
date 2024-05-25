using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Ninja : Hero
    {
        public Ninja(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice < 30) // 30% chance for stealth attack
            {
                baseAttack += baseAttack; // Ignore opponent's defense
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice < 30) // 30% chance to dodge
            {
                Console.WriteLine($"{Name} dodged the attack.");
                return;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
