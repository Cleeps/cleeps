using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace arcadeGraveyard
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Player Assets
        Texture2D tempPlayerTexture;
        Player player;
        Rectangle tempPlatform;

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
            tempPlayerTexture = Content.Load<Texture2D>("littleWhiteSquare");

            player = new Player();
            tempPlatform = new Rectangle(GraphicsDevice.Viewport.Width/2, GraphicsDevice.Viewport.Height/2 + 200, 64, 32);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (player.PlayerPos.Y > tempPlatform.Y - player.PlayerRect.Height)
            {
                while (player.PlayerPos.Y > tempPlatform.Y)
                {
                    player.PlayerPosY--;
                }

                player.IsGrounded = true;
            }
            else
            {
                player.IsGrounded = false;
            }

            player.Update();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(tempPlayerTexture, tempPlatform, Color.White);
            _spriteBatch.Draw(tempPlayerTexture, player.PlayerPos, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
