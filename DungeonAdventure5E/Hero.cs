using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonAdventure5E 
{
    abstract class Hero : DungeonCharacter
    {
        private int numTurns;
        private int[] inventory = new int[2];
        private int foundPillars = 0;

        public Hero(string name, CharacterStats stats) : base(name,stats)
        {
            setInitialInventory();


        }

        public int NumTurns
        {
            get { return this.numTurns; }
            set { this.numTurns = value; }
        }
        public int[] Inventory
        {
            get { return this.inventory; }
            set { this.inventory[0] = value[0]; this.inventory[1] = value[1]; }
        }

        private void setInitialInventory()
        {
            int[] temp = { 0, 0 };
            temp.CopyTo(this.inventory,0);
        }

        public void addPillar()
        {
            this.foundPillars++;
        }

        public int getPillar()
        {
            return this.foundPillars;
        }

        public bool defend()
        {
            Random generator = new Random();

            return generator.NextDouble() <= base.Stats.ChanceToBlock;
        }

        public void subHP(int hp)
        {
            if (defend())
                Console.WriteLine(base.Name + " blocked the attack!");
            else
                base.subHP(hp);
        }

        public void useHealthPotion()
        {
            if (this.inventory[0] > 0)
            {
                this.inventory[0]--;
                this.addHP(25);
            }
            else
                Console.WriteLine("You don't have any Health Potions.");
        }

        public void addHealthPotion()
        {
            this.inventory[0]++;
        }

        public void useVisionPotion()
        {
            if (this.inventory[1] > 0)
                this.inventory[1]--;
            else
                Console.WriteLine("You don't have any Vision Potions.");
        }

        public void addVisionPotion()
        {
            this.inventory[1]++;
        }

        public void battleChoices(DungeonCharacter opponent)
        {
            if (opponent is null)
                throw new Exception("Opponent parameters in Hero was passed as null.");

            this.numTurns = base.Stats.AttackSpeed / opponent.Stats.AttackSpeed;

            if(this.numTurns == 0)
            {
                this.numTurns++;
            }

            Console.WriteLine("Number of turns this round is: " + this.numTurns);
        }

        public override string ToString()
        {
            return "Hero name: " + base.Name + "\n"
                + "Hitpoints: " + base.CurrentHP + "\n"
                + "Total Healing Potions: " + this.inventory[0] + "\n"
                + "Total Vision Potions: " + this.inventory[1] + "\n"
                + "Total Pillars of OO Found: " + this.foundPillars;
        }

    }
}
