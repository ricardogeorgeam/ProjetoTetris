using ProjetoTetris;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;


namespace ProjetoTetris
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load textures
            Texture2D tilesTexture = Content.Load<Texture2D>("tiles");
            Texture2D backgroundTexture = Content.Load<Texture2D>("background");
            Texture2D frameTexture = Content.Load<Texture2D>("frame");

            // Initialize sprites
            // Set sprite positions
        }

        protected override void Update(GameTime gameTime)
        float delay = 0.0f;
        {
            // Handle input
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Up)) { /* rotate=true; */ }
            else if (keyboardState.IsKeyDown(Keys.Left)) { /* dx=-1; */ }
            else if (keyboardState.IsKeyDown(Keys.Right)) { /* dx=1; */ }

            if (keyboardState.IsKeyDown(Keys.Down)) delay = 0.05f;

            // Move block left or right

            // Rotate block

            // Move block down

            base.Update(gameTime);
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            // Draw sprites

            spriteBatch.End();

            base.Draw(gameTime);

        }
    }
}