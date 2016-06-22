
using PathFinder;
using PathFinder.Button;
using SharpDX;
using SharpDX.Toolkit;
/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;*/
using SharpDX.Toolkit.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDX
{
    class defaultBG:fightBase
    {
       static  Texture2D texture;
       static  Rectangle rectangle;
       static button attack;
       static button[] target;
       bool loaded = false;
        public override void LoadContent(Game game)
        {
            if (!loaded)
            {
               texture = game.Content.Load<Texture2D>("terraincell");
            rectangle = new Rectangle(0,0,800,480);
            attack = new button();
            attack.init(600,100,60,20);
            ready = true;
            attack.text = "támadás";
            loaded = true;
            target = new button[FightHandler.lenght()];
            }
            
        }
        public override void Update(GameTime gameTime)
        {
            attack.internalupdate();
            if (attack.clicked)
            {
                for (int i = 0; i < FightHandler.lenght(); i++)
                {
                    target[i].internalupdate();
                }
                bool alldead = false;
                for (int i = 0; i < FightHandler.lenght(); i++)
                {
                    
                }

             }
               // attack.clickdone = true;
                
            
            
       }
        public override void Draw(ref SpriteBatch spritebatch,Game game)
        {
            
            if (ready)
	        {
               spritebatch.Draw(texture, rectangle,Color.White);
                for (int i = 0; i <FightHandler.lenght(); i++)
                {
                    spritebatch.Draw(FightHandler.enemylist[i].drawing.texture, new Rectangle(50+(i*50),100,64,64), Color.White);
                }
                spritebatch.DrawString(game.Content.Load<SpriteFont>("myfont"),"harcba ütköztél kérlek nyomj egy szóközt az elenfél legyözéséhez",new Vector2(0f,0f),Color.Black);
                spritebatch.Draw(texture, new Rectangle(600, 100, 60, 20), Color.Red);
                for (int i = 0; i < FightHandler.lenght(); i++)
                {
                    spritebatch.DrawString(game.Content.Load<SpriteFont>("myfont"),"HP: " +(FightHandler.enemylist[i].health).ToString(), new Vector2(600f, 150f + (i * 50)), Color.Red);
                       
                }
                for (int i = 0; i < FightHandler.lenght(); i++)
                {
                    spritebatch.DrawString(game.Content.Load<SpriteFont>("myfont"), attack.text, new Vector2(600f,100f+(i*50f)), Color.Black);
                }
                  
                
            }
            
        }
    }
}
