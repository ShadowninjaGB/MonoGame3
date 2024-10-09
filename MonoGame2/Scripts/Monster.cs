using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace MonoGame2.Scripts
{
    internal class Monster
    {
        private protected Vector2 StartPos;
        private protected Vector2 CurPos;
        protected Texture2D Sprite;
        private protected float movementSpeed = 1.0f;


        public Monster(Vector2 posititon) 
        {
            StartPos = posititon;   
            CurPos = StartPos;

        }

        public void LocalContent(ContentManager cm, string name) 
        {
            Sprite = cm.Load<Texture2D>(name);
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle rect)
        {
            spriteBatch.Draw(Sprite,CurPos, rect, Color.White);
        }

        public Vector2 GetCurPos() 
        {
            return CurPos;
        }

        public void ResetStartPos()
        {
            CurPos = StartPos;
        }


        public virtual void up ()
        {
            CurPos.Y += -1.0f * movementSpeed;
        }

        public virtual void Down()
        {
            CurPos.Y -= -1.0f *movementSpeed;
        }
        public virtual void Left()
        {
            CurPos.X -= 1.0f * movementSpeed;
        }

        public virtual void Right()
        {
            CurPos.X += 1.0f * movementSpeed;
        }


    }
}
