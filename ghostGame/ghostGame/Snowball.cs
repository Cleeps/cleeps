using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ghostGame
{
    class Snowball : GameObject
    {
        /*int targetX;
        int targetY;
        int intX;
        int intY;*/

        float targetX;
        float targetY;
        float intX;
        float intY;
        float xDifference;
        float yDifference;

        public Snowball(Texture2D text, Vector2 pos, int tarX, int tarY)
        {
            this.texture = text;
            this.position = pos;
            targetX = tarX;
            targetY = tarY;
            intX = this.position.X;
            intY = this.position.Y;
            xDifference = intX - targetX;
            yDifference = intY - targetY;
        }

        public void Update()
        {
            float distance = (float)Math.Sqrt((xDifference * xDifference) + (yDifference * yDifference));

            /*if ()
            {
                if (xDifference > 0)
                {
                    this.position.X -= xDifference / distance;
                }
                else
                {
                    this.position.X += (xDifference / distance) * (-1);
                }
            }

            if(this.position.Y > targetY || this.position.Y < targetY)
            {
                if (yDifference > 0)
                {
                    this.position.Y -= yDifference / distance;
                }
                else
                {
                    this.position.Y += (yDifference / distance) * (-1);
                }
            }*/
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.texture, this.position, Color.White);
        }
    }
}
