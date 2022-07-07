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
        Vector2 startPos;
        Vector2 endPos;
        Vector2 origin;
        int rotation = 0;
        float scale = 1f;
        int speed;

        public Snowball(Texture2D text, Vector2 pos, int tarX, int tarY)
        {
            this.texture = text;
            this.position = pos;
            startPos = new Vector2((int)position.X, (int)position.Y);
            endPos = new Vector2((int)tarX, (int)tarY);
        }

        public void Update()
        {
            Vector2 length = new Vector2(endPos.X - startPos.X, endPos.Y - startPos.Y);

            // Set the speed of the snowball based on distance
            if (this.position != endPos)
            {
                if (length.Length() > 200)
                {
                    speed = 50;
                }
                else if (length.Length() > 150)
                {
                    speed = 40;
                }
                else
                {
                    speed = 5;
                }

                // Update the snowball's position based on the length of its target
                this.position.X += (endPos.X - startPos.X) / speed;
                this.position.Y += (endPos.Y - startPos.Y) / speed;

                // Ensure that the snowball can always hit its mark by correcting its position 
                if (length.X > 0)
                {
                    if (this.position.X > endPos.X - (endPos.X - startPos.X) / speed)
                    {
                        this.position = endPos;
                    }
                }
                else
                {
                    if (this.position.X < endPos.X - (endPos.X - startPos.X) / speed)
                    {
                        this.position = endPos;
                    }
                }

                // Rotation Calculation
                if (rotation < 360)
                {
                    rotation += 15;
                }
                else
                {
                    rotation = 0;
                }

                // Scale Calculation
                
            }
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            origin = new Vector2(this.position.X + 32, this.position.Y - 32);

            _spriteBatch.Draw(this.texture, 
                              this.position, 
                              null,
                              Color.White,
                              0f,
                              //rotation,                // Rotation   
                              Vector2.Zero,            // Origin
                              scale,                   // Scale
                              SpriteEffects.None,
                              0);
        }
    }
}
