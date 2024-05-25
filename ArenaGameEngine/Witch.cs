using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Witch : Hero
    {
        public Witch(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice < 35) // 35 % chance to deal extra damage
            {
                baseAttack += Random.Shared.Next(0, 51); // Add random amount between 0 and 50
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice < 20) // 20% chance to heal instead of taking damage
            {
                int healing = incomingDamage / 2; // Heal by 50% of incoming damage
                Heal(healing);
                Console.WriteLine($"{Name} healed for {healing} health instead of taking damage.");
                return;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
