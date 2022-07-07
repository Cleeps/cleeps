using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ghostGame
{
    class Crosshair : GameObject
    {
        MouseState mouseState;
        MouseState prevMouseState;
        int targetPosX;
        int targetPosY;
        List<Snowball> snowballs = new List<Snowball>();

        public Crosshair(Texture2D text, Vector2 pos)
        {
            this.texture = text;
            this.position = pos;
        }

        public void Update(Texture2D ballTexture, Snowman snowman)
        {
            mouseState = Mouse.GetState();
            targetPosX = mouseState.X - 32;
            targetPosY = mouseState.Y - 32;

            if (mouseState.LeftButton == ButtonState.Released && prevMouseState.LeftButton == ButtonState.Pressed)
            {
                snowballs.Add(new Snowball(ballTexture, new Vector2(snowman.X, snowman.Y), targetPosX, targetPosY));
            }

            for (int i = 0; i < snowballs.Count; i++)
            {
                snowballs[i].Update();
            }

            this.position.X = targetPosX;
            this.position.Y = targetPosY;

            prevMouseState = Mouse.GetState();
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.texture, this.position, Color.White);

            for (int i = 0; i < snowballs.Count; i++)
            { 
                snowballs[i].Draw(_spriteBatch);
            }
        }
    }
}
