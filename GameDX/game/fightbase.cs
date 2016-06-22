using GameDX.maps;
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;
/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDX
{
    class fightBase
    {
         protected static bool  ready = false;
         public virtual  void Initialize()
        {
 
        }
       public virtual void LoadContent(Game game)
        { 

        }
       public virtual void UnloadContent()
        { 

        }
        public virtual void Update(GameTime gameTime)
        {
 
        }
        public virtual void Draw(ref SpriteBatch spritebatch, Game game)
        {

        }
    }
}
