using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame2.Scripts
{
    internal class Monster
    {
        private protected Vector2 StartPos;
        private protected Vector2 CurPos;


        public Monster(Vector2 posititon) 
        {
            StartPos = posititon;   
            CurPos = StartPos;

        }


        public Vector2 GetCurPos() 
        {
            return CurPos;
        }

        public void ResetStartPos()
        {
            CurPos = StartPos;
        }


        public void up ()
        {
            CurPos.Y += 1.0f;
        }

        public void Down()
        {
            CurPos.Y -= 1.0f;
        }
        public void Left()
        {
            CurPos.X -= 1.0f;
        }

        public void Right()
        {
            CurPos.X += 1.0f;
        }


    }
}
// egg 