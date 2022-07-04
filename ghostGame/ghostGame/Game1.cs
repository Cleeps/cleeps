using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ghostGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D testSquare;
        private Texture2D ghostTest;
        private Texture2D crosshairText;
        private KeyboardState kbState;
        private KeyboardState prevKbState;
        private Ghost ghost;
        private Snowman snowman;
        private Crosshair crosshair;
        private int gameNum = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            testSquare = Content.Load<Texture2D>("littleWhiteSquare");
            ghostTest = Content.Load<Texture2D>("ghostTemp");
            crosshairText = Content.Load<Texture2D>("crosshair");


            ghost = new Ghost(ghostTest, new Vector2(100, 100));
            snowman = new Snowman(testSquare, new Vector2(100, 100));
            crosshair = new Crosshair(crosshairText, new Vector2(0, 0));

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            kbState = Keyboard.GetState();

            if (kbState.IsKeyUp(Keys.OemTilde) && prevKbState.IsKeyDown(Keys.OemTilde))
            {
                gameNum += 1;

                if (gameNum > 1)
                {
                    gameNum = 0;
                }
            }

            switch (gameNum)
            { 
                case 0:
                    ghost.Update();
                    break;

                case 1:
                    snowman.Update();
                    crosshair.Update(testSquare, snowman);
                    break;
            }

            prevKbState = Keyboard.GetState();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();

            switch (gameNum)
            {
                case 0:
                    ghost.Draw(_spriteBatch, ghostTest, ghost.Positon);
                    break;

                case 1:
                    snowman.Draw(_spriteBatch);
                    crosshair.Draw(_spriteBatch);
                    break;
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
