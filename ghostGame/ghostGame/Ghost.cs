using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ghostGame
{
    class Ghost : GameObject
    {
        private KeyboardState keyboardState;
        //private Vector2 updatePos;
        private float updatePosX;
        private float updatePosY;
        private const int maxSpeed = 8;
        private const int minSpeed = -8;

        public Ghost(Texture2D text, Vector2 pos)
        {
            texture = text;
            position = pos;
        }

        public Vector2 Positon
        {
            get { return position; }
            set { position = value; }
        }

        public void Update()
        {
            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.W))
            {
                updatePosY -= 1f;
            }

            if (keyboardState.IsKeyDown(Keys.S))
            {
                updatePosY += 1f;
            }

            if (keyboardState.IsKeyDown(Keys.D))
            {
                updatePosX += 1f;
            }

            if (keyboardState.IsKeyDown(Keys.A))
            {
                updatePosX -= 1f;
            }

            // While the player isn't moving, slow them down
            if (!(keyboardState.IsKeyDown(Keys.W) &&
                keyboardState.IsKeyDown(Keys.S) &&
                keyboardState.IsKeyDown(Keys.A) &&
                keyboardState.IsKeyDown(Keys.D)))
            {
                if (updatePosX != 0)
                {
                    if (updatePosX > 0)
                    {
                        updatePosX -= 0.2f;
                    }
                    else
                    {
                        updatePosX += 0.2f;
                    }

                    if (updatePosX > -0.1 && updatePosX < 0.1)
                    {
                        updatePosX = 0;
                    }
                }

                if(updatePosY != 0)
                {
                    if (updatePosY > 0)
                    {
                        updatePosY -= 0.2f;
                    }
                    else
                    {
                        updatePosY += 0.2f;
                    }

                    if (updatePosY > -0.1 && updatePosY < 0.1)
                    {
                        updatePosY = 0;
                    }

                }
            }

            // If the player 
            if (updatePosY > maxSpeed || updatePosY < minSpeed)
            {
                if (updatePosY > 0)
                {
                    updatePosY = maxSpeed;
                }
                else
                {
                    updatePosY = minSpeed;
                }
            }

            if(updatePosX > maxSpeed || updatePosX < minSpeed)
            {
                if (updatePosX > 0)
                {
                    updatePosX = maxSpeed;
                }
                else
                {
                    updatePosX = minSpeed;
                }
            }

            position.X += (updatePosX);
            position.Y += (updatePosY); 
        }

        public void Draw(SpriteBatch _spriteBatch, Texture2D texture, Vector2 position)
        {
            _spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
