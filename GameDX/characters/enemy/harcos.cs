using PathFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDX.characters.enemy
{
    class harcos:PathFinder.Character.CharacterEnemyBase
    {
        private bool r2 = false;
        int fightid = -1;
        override public void ifcolide(int count)
        {
            if (!isdead)
            {
                
                   fightid=FightHandler.addEnemy(this);
                
            
            vars.state = gamestate.battle;
            Console.WriteLine("harc");
            }
           
        }
    }
}
