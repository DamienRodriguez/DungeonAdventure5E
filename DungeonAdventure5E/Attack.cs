using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonAdventure5E
{
    interface Attack
    {
        void attack(DungeonCharacter opponent);
        void addHP(int hp);
        void subHP(int hp);
    }
}
