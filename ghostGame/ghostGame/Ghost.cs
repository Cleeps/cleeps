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
        private double updatePosX;
        private double updatePosY;
        private const int maxSpeed = 10;
        private const int minSpeed = -10;

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
            //updatePos.X = 0;
            //updatePos.Y = 0;

            if (keyboardState.IsKeyDown(Keys.W))
            {
                updatePosY -= 2;
            }

            if (keyboardState.IsKeyDown(Keys.S))
            {
                updatePosY += 2;
            }

            if (keyboardState.IsKeyDown(Keys.D))
            {
                updatePosX += 2;
            }

            if (keyboardState.IsKeyDown(Keys.A))
            {
                updatePosX -= 2;
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
                        updatePosX--;
                    }
                    else
                    {
                        updatePosX--;
                    }
                }

                if(updatePosY != 0)
                {
                    if (updatePosY > 0)
                    {
                        updatePosY--;
                    }
                    else
                    {
                        updatePosY++;
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

            position.X += int.Parse(updatePosX);
            position.Y += int.Parse(updatePosY); 
        }

        public void Draw(SpriteBatch _spriteBatch, Texture2D texture, Vector2 position)
        {
            _spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
