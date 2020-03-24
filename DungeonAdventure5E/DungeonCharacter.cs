using System;

namespace DungeonAdventure5E
{
    abstract class DungeonCharacter : Attack
    {
        private string name;
        private int currentHP = 0;
        private CharacterStats stats;

        public DungeonCharacter(string name, CharacterStats stats)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name parameter in DungeonCharacter was empty or null.");
            if (stats is null)
                throw new Exception("Stats parameter in DungeonCharacter was null");

            this.Stats = stats;
            this.Name = name;
            this.CurrentHP = this.stats.MaxHealthPoints;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int CurrentHP
        {
            get { return this.currentHP; }
            set
            {
                this.currentHP = value;
            }
        }

        public CharacterStats Stats
        {
            get { return this.stats; }
            set { this.stats = value; }
        }

        public void addHP(int hp)
        {
            if (hp < 1)
                throw new Exception("HP passed into DungeonCharacter addHP was less that one.");

            if(this.currentHP > 0)
            {
                if (this.currentHP + hp > this.stats.MaxHealthPoints)
                    this.currentHP = this.stats.MaxHealthPoints;
                else
                    this.currentHP += hp;
            }
            
        }

        public void subHP(int hp)
        {
            this.currentHP -= hp;
        }

        public void attack(DungeonCharacter opponent)
        {
            if (opponent is null)
                throw new Exception("Opponent passed into Attack was null.");

            Random generator = new Random();

            bool canAttack = generator.NextDouble() <= this.stats.ChanceToHit;

            if(canAttack)
            {
                int damage = (int)(generator.NextDouble() * (this.stats.MinDamage - this.stats.MaxDamage + 1)) + this.stats.MinDamage;
                Console.WriteLine(this.Name + "'s attack connected with: " + opponent.Name + " dealing " + damage);
                opponent.subHP(damage);
                Console.WriteLine();
                Console.WriteLine(opponent.Name + "'s health points: " + opponent.CurrentHP);
            }
            
            else
            {
                Console.WriteLine(this.Name + "'s attack failed to connect with " + opponent.Name);
                Console.WriteLine();
            }

        }

    }
}
