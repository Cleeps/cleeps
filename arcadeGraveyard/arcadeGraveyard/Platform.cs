using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace arcadeGraveyard
{
    class Platform : GameObject
    {
        public Vector2 PlatformPosition
        {
            get { return position; }
        }

        public Rectangle PlatformRect
        {
            get { return rectangle; }
        }

        public Platform(int platX, int platY, int platW, int platH)
        {
            position.X = platX;
            position.Y = platY;
            rectangle.Width = platW;
            rectangle.Height = platH;
        }
    }
}
