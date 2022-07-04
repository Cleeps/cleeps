using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ghostGame
{
    class Snowman : GameObject
    {
        private KeyboardState keyboardState;
        private int targetX;
        private int targetY;

        public float Y
        {
            get { return position.Y; }
        }

        public float X
        {
            get { return position.X; }
        }

        public Snowman(Texture2D text, Vector2 pos)
        {
            this.texture = text;
            this.position = pos;
        }

        public void Update()
        {
            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.W))
            {
                position.Y -= 5;
            }

            if (keyboardState.IsKeyDown(Keys.S))
            {
                position.Y += 5;
            }

            if (keyboardState.IsKeyDown(Keys.D))
            {
                position.X += 5;
            }

            if (keyboardState.IsKeyDown(Keys.A))
            {
                position.X -= 5;
            }
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(this.texture, this.position, Color.White);
        }
    }
}
