using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D squareTexture;
        
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            squareTexture = Content.Load<Texture2D>("Wrecktangle");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
         
        }

        public void DrawBlankScreen()
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10000; i++)
            {
                Rectangle ColorSquare = new Rectangle(x, y, 14, 14);
                spriteBatch.Begin();

                spriteBatch.Draw(squareTexture, ColorSquare, Color.Red);

                x += 15;
                if (i % 53 == 52)
                {
                    y += 15;
                    x = 0;
                }

                spriteBatch.End();

            }
        }

        public void DrawCheckerBoard()
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10000; i++)
            {
                Rectangle ColorSquare = new Rectangle(x, y, 14, 14);
                spriteBatch.Begin();
                if (i % 2 == 0)
                spriteBatch.Draw(squareTexture, ColorSquare, Color.Gold);

                x += 15;
                
                if (i % 53 == 52)
                {
                    y += 15;
                    x = 0;
                }
  
                spriteBatch.End();

            }


        }

        public void DrawRainbow()
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < 7; i++)
            {
                Rectangle ColorSquare = new Rectangle(x, y, 115, 800);
                spriteBatch.Begin();
              
                if (i == 0)
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Red);
                else if (i == 1 )
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Orange);
                else  if (i == 2)
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Yellow);
                else if (i == 3)
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Green);
                else if (i == 4)
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Blue);
                else if (i == 5)
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Indigo);
                else if (i == 6)
                    spriteBatch.Draw(squareTexture, ColorSquare, Color.Violet);

                x += 115;

                spriteBatch.End();

            }


        }

        private void DrawRandom()
        {
            Random random = new Random();

            spriteBatch.Begin();

            Rectangle[] RandomSquare = new Rectangle[100];
            Rectangle ColorSquare = new Rectangle(x, y, 14, 14);


            spriteBatch.End();

        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            

           // DrawBlankScreen();
            //DrawCheckerBoard();
            //DrawRainbow();
            DrawRandom();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
            
        }
    }
}
