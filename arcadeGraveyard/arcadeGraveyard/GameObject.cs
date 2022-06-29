using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace arcadeGraveyard
{
    class GameObject
    {
        // Variables
        protected Rectangle rectangle;
        protected Vector2 position;

        public bool CheckYCollision(GameObject objectOne, GameObject objectTwo)
        {
            float objectOneHeight = (objectOne.rectangle.Height / 2);
            float objectTwoHeight = (objectTwo.rectangle.Height / 2);

            float separatingAxisY = (objectTwo.position.Y + objectTwoHeight) - (objectOne.position.Y + objectOneHeight);

            // Check for Y collisions
            if (separatingAxisY - (objectTwoHeight) - (objectOneHeight) > 0)
            {
                return false;
            }
            else if (separatingAxisY - (objectTwoHeight) - (objectOneHeight) < 0 ||
                     separatingAxisY - (objectTwoHeight) - (objectOneHeight) == 0)
            {
                return true;
            }

            return false;
        }

        public bool CheckXCollision(Vector2 obj1Pos, Vector2 obj2Pos, Rectangle obj1Size, Rectangle obj2Size)
        {
            float separatingAxisX = obj2Pos.X - obj1Pos.X;

            // Check for X collisions
            if (separatingAxisX - obj1Size.Width - obj2Size.Width > 0)
            {
                return false;
            }
            else if (separatingAxisX - obj1Size.Width - obj2Size.Width == 0)
            {
                return true;
            }
            else if (separatingAxisX - obj1Size.Width - obj2Size.Width < 0)
            {
                return true;
            }

            return false;
        }

        public bool IsInBoundsOfX(GameObject objectOne, GameObject objectTwo)
        {
            float xMidpointOne = objectOne.position.X + (objectOne.rectangle.Width / 2);
            float leftBound = objectTwo.position.X - (objectOne.rectangle.Width/2);
            float rightBound = objectTwo.position.X + (objectTwo.rectangle.Width/2) + (objectOne.rectangle.Width/2);

            if (xMidpointOne > leftBound &&
                xMidpointOne < rightBound)
            {
                return true;
            }

            return false;
        }

        public bool IsInBoundsOfY(GameObject objectOne, GameObject objectTwo)
        {
            float yMidpointOne = objectOne.position.X + (objectOne.rectangle.Width / 2);
            float topBound = objectTwo.position.X - (objectOne.rectangle.Width / 2);
            float bottomBound = objectTwo.position.X + (objectTwo.rectangle.Width / 2) + (objectOne.rectangle.Width / 2);

            if (yMidpointOne > topBound &&
                yMidpointOne < bottomBound)
            {
                return true;
            }

            return false;
        }
    }
}
