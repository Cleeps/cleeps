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
        Platform tempPlatform;

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

            player = new Player(new Vector2(GraphicsDevice.Viewport.Width / 2, 0));
            tempPlatform = new Platform(GraphicsDevice.Viewport.Width/2, GraphicsDevice.Viewport.Height/2 + 200, 64, 32);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //if (player.PlayerPos.Y + player.PlayerRect.Height > tempPlatform.Top)
            //{
            //    //while (player.PlayerPos.Y + player.PlayerRect.Height != tempPlatform.Top)
            //    //{
            //    //    player.PlayerPosY--;
            //    //}

            //    player.IsGrounded = true;
            //}
            //else
            //{
            //    //if (player.PlayerPos.Y + player.PlayerRect.Height != tempPlatform.Top)
            //    //{
            //    //    player.IsGrounded = false;
            //    //}
            //}

            player.Update();

            if (player.CheckYCollision(player, tempPlatform) &&
                player.IsInBoundsOfX(player, tempPlatform))
            {
                player.PlayerPosY = tempPlatform.PlatformPosition.Y - player.PlayerRect.Height;

                player.IsGrounded = true;
            }
            else
            {
                player.IsGrounded = false;
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(tempPlayerTexture, tempPlatform.PlatformPosition, Color.White);
            _spriteBatch.Draw(tempPlayerTexture, player.PlayerPos, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
