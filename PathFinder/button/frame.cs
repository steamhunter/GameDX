﻿using SharpDX;
using SharpDX.Toolkit.Graphics;
//using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;*/

namespace PathFinder.Button
{
    class managment 
    {
        static button[] butons=new button[20];
        public static int db = 0;
        public static  void registerButton(button Button) 
        {
            if (db<=20)
            {
                butons[db] = Button;
                db++;
            }
            else
            {
               Error.error.basicError(100);
            }
 
        }
    }
    public class button
    {
         Vector2 pos;
         Vector2 size;
         Rectangle buttonRec;
         //ButtonState prevstate = ButtonState.Released;
         protected Texture2D texture;
         bool ready = false;
         public bool clicked = false;
         //public bool clickdone = false;
         public string text = "";

         public void internalupdate()
         {

             if (clicked/*&&clickdone*/)
             {
                 clicked = false;
                // clickdone = false;
             }
             if (/*Mouse.GetState().LeftButton == ButtonState.Pressed && ready && prevstate != Mouse.GetState().LeftButton*/true)
             {
                 Console.WriteLine("press");
                 if (/*buttonRec.Intersects(new Rectangle(Mouse.GetState().X, Mouse.GetState().Y, 1, 1))*/true)
                 {
                     clicked = true;
                 }
             }
            // prevstate = Mouse.GetState().LeftButton;
             
         }
         public void init(int x,int y,int w,int h)
         {
             pos = new Vector2(Convert.ToSingle(x), Convert.ToSingle(y));
             size = new Vector2(Convert.ToSingle(w), Convert.ToSingle(h));
             buttonRec = new Rectangle(x, y, w, h);
             ready = true;
             managment.registerButton(this);
         }

    }
}