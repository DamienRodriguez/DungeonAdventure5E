using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonAdventure5E
{
    class CharacterStats
    {
        private int maxHealthPoints, attackSpeed, minDamage, maxDamage, minHeal, maxHeal;
        private double chanceToHit, chanceToBlock, chanceToHeal;

        public CharacterStats(int maxHealthPoints, int attackSpeed, int minDamage, int maxDamage, int minHeal, int maxHeal, double chanceToHit, double chanceToBlock, double chanceToHeal)
        {
            this.MaxHeal = maxHealthPoints;
            this.AttackSpeed = attackSpeed;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.MinHeal = minHeal;
            this.MaxHeal = maxHeal;
            this.ChanceToHit = chanceToHit;
            this.ChanceToBlock = chanceToBlock;
            this.ChanceToHeal = chanceToHeal;
        }

        public int MaxHealthPoints
        {
            get { return this.maxHealthPoints; }
            set { this.maxHealthPoints = value; }

        }

        public int AttackSpeed
        {
            get { return this.attackSpeed; }
            set { this.attackSpeed = value; }

        }

        public int MinDamage
        {
            get { return this.minDamage; }
            set { minDamage = value; }

        }

        public int MaxDamage
        {
            get { return this.maxDamage; }
            set { maxDamage = value; }

        }

        public int MinHeal
        {
            get { return this.minHeal; }
            set { minHeal = value; }

        }

        public int MaxHeal
        {
            get { return this.maxHeal; }
            set { maxHeal = value; }

        }

        public int[] damageVariance()
        {

            int[] temp = { this.MinDamage, this.MaxDamage };
            
            return temp;
        }

        public int[] healVariance()
        {

            int[] temp = { this.MinHeal, this.MaxHeal };

            return temp;
        }

        public double ChanceToHit
        {
            get { return this.chanceToHit; }
            set { this.chanceToHit = value; }
        }

        public double ChanceToBlock
        {
            get { return this.chanceToBlock; }
            set { this.chanceToBlock = value; }
        }

        public double ChanceToHeal
        {
            get { return this.chanceToHeal; }
            set { this.chanceToHeal = value; }
        }


        
        public static CharacterStats getWarriorStats()
        {
            return new CharacterStats(125, 4, 35, 60, 0, 0, .8, .2, 0.0);
        }

        public static CharacterStats getSorceressStats()
        {
            return new CharacterStats(75, 5, 25, 50, 0, 0, 0.7, 0.3, 0.0);

        }

        public static CharacterStats getThiefStats()
        {
            return new CharacterStats(75, 6, 20, 40, 0, 0, 0.8, 0.5, 0.0);

        }

        public static CharacterStats getAlchemistStats()
        {
            return new CharacterStats(68, 4, 21, 51, 0, 0, 0.6, 0.6, 0.0);
        }

        public static CharacterStats getClericStats()
        {
            return new CharacterStats(100, 4, 19, 40, 0, 0, 0.3, 0.9, 0.0);
        }

        public static CharacterStats getOgreStats()
        {
            return new CharacterStats(200, 2, 30, 50, 30, 50, 0.6, 0.0, 0.1);
        }

        public static CharacterStats getSkeletonStats()
        {
            return new CharacterStats(100, 3, 15, 25, 30, 50, 0.8, 0.0, 0.3);
        }


        public static CharacterStats getGremlinStats()
        {
            return new CharacterStats(70, 5, 5, 15, 20, 40, .8, 0.0, 0.4);
        }


        public static CharacterStats getGoblinStats()
        {
            return new CharacterStats(80, 7, 16, 25, 22, 42, 0.9, 0.0, 0.3);
        }


        public static CharacterStats getBugBearStats()
        {
            return new CharacterStats(73, 4, 13, 32, 13, 33, 0.7, 0.0, 0.5);
        }
    }
}
