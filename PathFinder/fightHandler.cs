using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PathFinder.Character;

namespace PathFinder
{
    public class FightHandler
    {
            public static CharacterEnemyBase[] enemylist = new CharacterEnemyBase[8];
            static int usedSlots = 0; 
        public static int addEnemy(CharacterEnemyBase enemy)
        {
            if (usedSlots!=7)
            {
                enemylist[usedSlots] = enemy;
                usedSlots++;
                return usedSlots--;
            }
            else
            {
                
                Console.WriteLine("regisztrációs hiba a FightHandlerben");
                return -1;
            }
            
        }
        public static void endFight()
        {
            for (int i = 0; i < usedSlots; i++)
            {
                enemylist[i].isdead = true;
            }
            enemylist = new CharacterEnemyBase[8];
            vars.state = gamestate.world;

        }
        public static int lenght() 
        {
            return usedSlots;
        }

    }
}
