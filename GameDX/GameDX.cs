
using GameDX.characters.enemy;
using SharpDX;
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;
using SharpDX.Toolkit.Input;
using System;
using PathFinder._2D;
using PathFinder;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDX
{
    internal class GameDX: Game
    {
        private GraphicsDeviceManager deviceManager;
        private KeyboardManager Mykeyboardmanager;
        private SpriteBatch spriteBatch;


        Unit2D player;
        PathFinder.Character.CharacterBase testenemy;
        PathFinder.Character.CharacterBase test2;
        harcos harcs;
       defaultBG defaultBG = new defaultBG();
        maps.area1 area1 = new maps.area1();

        Unit2D[,] terrain;
        public GameDX()
        {
            deviceManager = new GraphicsDeviceManager(this);
            deviceManager.PreferredBackBufferWidth = 600;
            deviceManager.PreferredBackBufferHeight = 800;
            Mykeyboardmanager = new KeyboardManager(this);
            this.Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        { 
            Mykeyboardmanager.Initialize();
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
           
            this.IsMouseVisible = true;
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            if (vars.state == gamestate.world)
            {
                player = new Unit2D("player", this);
                // Create a new SpriteBatch, which can be used to draw textures.


                testenemy = new PathFinder.Character.CharacterBase();
                testenemy.game = this;
                testenemy.init("enemy");
                test2 = new PathFinder.Character.CharacterBase();
                test2.game = this;
                test2.init("enemy");
                harcs = new harcos();
                harcs.game = this;
                harcs.init("enemy");
                //entitypos.registerEntity(30, 30);
                /*testenemy.drawing.locationX = 30;
                testenemy.drawing.locationY = 30;
                test2.drawing.locationX = 150;
                test2.drawing.locationY = 100;*/
                player.locationX = 50;
                player.locationY = 50;
                area1.game = this;
                area1.LoadContent();
                /*harcs.drawing.locationX = 200;
                harcs.drawing.locationY = 200;*/


                terrain = new Unit2D[config.worldy, config.worldx];
                for (int i = 0; i < config.worldx; i++)
                {
                    for (int j = 0; j < config.worldy; j++)
                    {
                        terrain[j, i] = new Unit2D("grass", this);

                        terrain[j, i].locationX = 32 * i;
                        terrain[j, i].locationY = 32 * j;
                    }

                }




            }
            else if (vars.state == gamestate.load)
            {

            }

        }
        protected override void Update(GameTime gameTime)
        {
            Mykeyboardmanager.Initialize();
            
                if (vars.state == gamestate.world)
            {
                if (Mykeyboardmanager.GetState().IsKeyDown(Keys.W))
                {
                    Console.WriteLine("heuréka");
                    player.locationY = player.locationY - 2;
                    Console.WriteLine(player.locationY + " Y");
                    if (player.locationY < 0)
                    {
                        player.locationY = 0;
                    }
                }
                if (Mykeyboardmanager.GetState().IsKeyDown(Keys.S))
                {
                    player.locationY = player.locationY + 2;
                    Console.WriteLine(player.locationY + " Y");
                    if (player.locationY > config.worldy * 32 - 32)
                    {
                        player.locationY = config.worldy * 32 - 32;
                    }
                }
                if (Mykeyboardmanager.GetState().IsKeyDown(Keys.A))
                {
                    player.locationX = player.locationX - 2;
                    Console.WriteLine(player.locationX + " X");
                    if (player.locationX < 0)
                    {
                        player.locationX = 0;
                    }
                }
                if (Mykeyboardmanager.GetState().IsKeyDown(Keys.D))
                {
                    player.locationX = player.locationX + 2;
                    Console.WriteLine(player.locationX + " X");
                    if (player.locationX > config.worldx * 32 - 32)
                    {
                        player.locationX = config.worldx * 32 - 32;
                    }
                }

                /*testenemy.update();
                test2.update();
                harcs.update();*/
                area1.Update(gameTime);
                PathFinder.Character.Managment.management.colision(player);




                base.Update(gameTime);
            }
            else if (vars.state == gamestate.battle)
            {
                defaultBG.LoadContent(this);
                defaultBG.Update(gameTime);
            }

            // Allows the game to exit
            if (Mykeyboardmanager.GetState().IsKeyDown(Keys.Escape))
                this.Exit();


        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            if (vars.state == gamestate.world)
            {
                spriteBatch.Begin();



                for (int i = 0; i < config.worldx; i++)
                {
                    for (int j = 0; j < config.worldy; j++)
                    {
                        terrain[j, i].draw(spriteBatch);
                    }

                }


                player.draw(spriteBatch);

                /*testenemy.draw(spriteBatch);
                test2.draw(spriteBatch);
                harcs.draw(spriteBatch);*/
                area1.Draw(gameTime, ref spriteBatch);
                spriteBatch.End();
            }
            else if (vars.state == gamestate.load)
            {

            }
            else if (vars.state == gamestate.battle)
            {
                spriteBatch.Begin();
                defaultBG.Draw(ref spriteBatch, this);
                spriteBatch.End();
            }


            //base.Draw(gameTime);
        }
    }
}
