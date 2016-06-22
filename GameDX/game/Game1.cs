/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;*/
using System;
using System.Collections.Generic;
using System.Linq;
using PathFinder;
using GameDX.characters.enemy;
using System.Threading;
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;

namespace GameDX
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 /*: Microsoft.Xna.Framework.Game*/
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
       

        PathFinder.Character.CharacterBase testenemy;
        PathFinder.Character.CharacterBase test2;
        harcos harcs;
        maps.area1 area1 = new maps.area1();
        
        public Game1()
        {
          //  graphics = new GraphicsDeviceManager(this);
          //  Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected /*override*/ void Initialize()
        {
           
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected /*override*/ void LoadContent()
        { //spriteBatch = new SpriteBatch(GraphicsDevice);
            if (/*vars.state==Engine.gamestate.world*/true)
            {            
                area1.LoadContent();
            }
            else if (/*vars.state == gamestate.load*/true) 
            { 

            }
            
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected/* override*/ void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        
        protected /*override*/ void Update(GameTime gameTime)
        {
            if (/*vars.state==Engine.gamestate.world*/true)
            {
                area1.Update(gameTime);
                
            }
          
                
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected /*override*/ void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            if (/*vars.state==Engine.gamestate.world*/true)
            {
                spriteBatch.Begin();
                area1.Draw(gameTime, ref spriteBatch);
                spriteBatch.End();
            }
           
        }
    }
}
