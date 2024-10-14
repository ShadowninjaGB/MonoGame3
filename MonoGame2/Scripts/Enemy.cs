using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.DXGI;

namespace MonoGame2.Scripts
{
    internal class Enemy : Monster
    {
        public Enemy(Vector2 position) : base(position)
        {
            
        }

        public void Chase(Player player)
        {
            if (player.GetCurPos().X < CurPos.X) 
            {
                Left();
            }
            
            if (player.GetCurPos().Y > CurPos.Y)
            {
                Down();
            }

            if (player.GetCurPos().X > CurPos.X)
            {
                Right();
            }

            if (player.GetCurPos().Y < CurPos.Y)
            {
                up();
            }

        }

        public bool Caught(Player player) 
        {
            if (player.GetCurPos() == CurPos)
            {
                return true;  
            }
            else return false;
        }


    }
}
