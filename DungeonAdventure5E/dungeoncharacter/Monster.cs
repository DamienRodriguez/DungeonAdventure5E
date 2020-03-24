using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonAdventure5E
{
    abstract class Monster : DungeonCharacter
    {
        public Monster(string name, CharacterStats stats) : base(name, stats)
        {
            //nothing here because it is all handled at constructor level
        }


        public void subHP(int hp)
        {
            base.subHP(hp);
            this.heal();
        }

        public void heal()
        {
            Random generator = new Random();
            bool canHeal = (generator.NextDouble() < base.Stats.ChanceToHeal) && (base.CurrentHP > 0);


            if(canHeal)
            {
                int hp = (int)(generator.NextDouble() * (base.Stats.MaxHeal - base.Stats.MinHeal + 1)) + base.Stats.MinHeal;
                Console.WriteLine(base.Name + " healed itself for " + hp + " points.\n");
                this.addHP(hp);
            }

            Console.WriteLine("Total health points remaining are: " + base.CurrentHP);
        }

    }
}
