
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace arcadeGraveyard
{
    class Player
    {
        // Player Variables
        Rectangle playerRect;
        KeyboardState kbState;
        Vector2 velocity;
        Vector2 position;
        float gravityMultiplier = 1f;
        bool isGrounded;

        // Player Properties
        //public Rectangle PlayerPos
        //{
        //    get { return playerRect; }
        //}

        public Vector2 PlayerPos
        {
            get { return position; }
        }

        public bool IsGrounded
        {
            get { return isGrounded; }
            set { isGrounded = value; }
        }

        public Rectangle PlayerRect
        {
            get { return playerRect; }
            set { playerRect = value; }
        }

        /// <summary>
        /// Player constructor
        /// </summary>
        public Player()
        {
            playerRect = new Rectangle(0, 0, 32, 32);
        }

        /// <summary>
        /// Player update method
        /// </summary>
        public void Update()
        {
            kbState = Keyboard.GetState();

            velocity.X = 0;
            velocity.Y = 0;

            if (kbState.IsKeyDown(Keys.A))
            {
                velocity.X = -5f;
            }

            if (kbState.IsKeyDown(Keys.D))
            {
                velocity.X = 5f;
            }

            if (kbState.IsKeyDown(Keys.W) && isGrounded)
            {
                velocity.Y = -1f;
            }

            if (isGrounded)
            {
                gravityMultiplier = 1f;
                //velocity.Y = 0;
                isGrounded = true;
            }
            else
            {
                if (gravityMultiplier < 5)
                {
                    gravityMultiplier++;
                }

                velocity.Y = 0.15f * gravityMultiplier;
                isGrounded = false;
            }

            //playerRect.X += (int)velocity.X;
            //playerRect.Y += (int)velocity.Y;

            position += velocity;
        }
    }
}
