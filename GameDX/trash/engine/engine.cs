using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;*/
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;
using SharpDX;


namespace Engine.trash
{
    public enum gamestate
    {
        load,
        world,
        battle

    }
    class vars
    {
        public static gamestate state = gamestate.world;
    }
    class Terrain
    {

        material material;
        public int locationX;
        public int locationY;

        public Terrain(string blockname, Game game)
        {

            material = new material(blockname, game);
        }

        public void update()
        {
            material.locationX = locationX;
            material.locationY = locationY;
            material.update();
        }
        public void draw(SpriteBatch spritebatch)
        {
            material.locationX = locationX;
            material.locationY = locationY;
            material.draw(spritebatch);
        }


    }
    class material : Texture
    {
        Texture2D texture;
        Rectangle rectangle;

        public material(string blockname, Game game)
        {
            texture = getTexture(blockname, game);

        }
        public void update()
        {

        }
        public void draw(SpriteBatch spritebatch)
        {
            rectangle = new Rectangle(locationX, locationY, 32, 32);
            spritebatch.Draw(texture, rectangle, Color.White);
        }
    }
    class entity : Texture
    {
        Texture2D texture;
        Rectangle rectangle;



        public entity(string entity, Game game)
        {
            texture = getTexture(entity, game);


        }
        public void update()
        {

        }
        public void draw(SpriteBatch spritebatch)
        {
            rectangle = new Rectangle(locationX, locationY, 32, 32);
            spritebatch.Draw(texture, rectangle, Color.White);
        }


    }
    class Texture
    {
        public int locationX;
        public int locationY;
        public static Texture2D getTexture(string entity, Game game)
        {

            switch (entity)
            {
                case "player": return game.Content.Load<Texture2D>("player");
                case "grass": return game.Content.Load<Texture2D>("terraincell");
                case "enemy": return game.Content.Load<Texture2D>("enemy");


                default: return null;

            }

        }

    }
    class dialog
    {
        public static string getDialog(string name)
        {
            try
            {
                string[] iname = new string[50];
                string[] engdialog = new string[50];
                string[] hundialog = new string[50];

                int n = 0;
                StreamReader dial = new StreamReader("dialogt.csv", Encoding.Default);/*resources böl nem fogadja el*/
                while (!dial.EndOfStream)
                {
                    string gdialog = dial.ReadLine();
                    string[] sdialog = gdialog.Split(';');
                    iname[n] = sdialog[0];
                    hundialog[n] = sdialog[1];
                    engdialog[n] = sdialog[2];
                    n++;
                }


                for (int i = 0; i < n; i++)
                {
                    if (iname[i] == name)
                    {
                        return hundialog[i];
                    }
                }
            }
            catch (FileNotFoundException)
            {

               PathFinder.Error.error.DialogFileNotFound("asd");

            }







            return PathFinder.Error.error.basicError(1);
        }
    }
    class caracter
    {
        Texture2D texture;
        public Rectangle rectangle;
        entity ent;
        public int locationX;
        public int locationY;


        public caracter(string entity, Game game)
        {
            //texture = Engine.Texture.getTexture(entity, game);
            ent = new entity(entity, game);

        }
        public bool isColided(caracter player, caracter enemy)
        {

            if (player.rectangle.Intersects(enemy.rectangle))
            {
                return true;
            }
            else return false;


        }
        public void update()
        {

            ent.locationX = locationX;
            ent.locationY = locationY;

        }
        public void draw(SpriteBatch spritebatch)
        {
            ent.locationX = locationX;
            ent.locationY = locationY;
            rectangle = new Rectangle(ent.locationX, ent.locationY, 32, 32);
            spritebatch.Draw(texture, rectangle, Color.White);
        }




    }
}

