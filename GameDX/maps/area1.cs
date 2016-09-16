using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameDX;
using GameDX.characters;
using GameDX.characters.enemy;
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;
/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;*/

namespace GameDX.maps
{
    /*asd*/
    class area1:AreaBase
    {
        static harcos e1;
        bool r2 = false;
        
        public  override void Update(GameTime gameTime)
        {
            if (ready)
            {
               
            }
            else
            {
               PathFinder.Error.error.basicError(6);
            }
        }
        public  override void LoadContent()
        {
            
            if (true)
            {
                e1 = new harcos();
                e1.game = game;
                e1.init("enemy");
                e1.unit.locationX = 200;
                e1.unit.locationY = 200;
                r2 = true;
                ready = true;
            }
            else
            {
               PathFinder.Error.error.basicError(4);
            }
        }
        public  override void Draw(GameTime gameTime,ref SpriteBatch spritebatch)
        {
            if (ready/*&&r2*/)
            {
                e1.draw(spritebatch);
            }
            else
            {
                PathFinder.Error.error.basicError(5);
            }
            
        }
    }
}
