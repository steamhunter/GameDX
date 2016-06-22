using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PathFinder._2D;

namespace PathFinder.Character.Managment 
{
    public class management
    {
        static Base[] array = new Base[100];
        static int db = 0;
        public static void register(Base charact)
        {
            array[db] = charact;
            db++;
        }
        public static void colision(Unit2D player)
        {
            for (int i = 0; i < db; i++)
            {
                if (array[i].unit.rectangle.Intersects(player.rectangle))
                {
                    array[i].ifcolide(1);
                }
            }
        }
    }

}
