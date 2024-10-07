using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame2.Scripts
{
    internal class Enemy : Monster
    {
        public Enemy(Vector2 position) : base(position)
        {
            
        }

        public void Chase() 
        { 

        }

        public bool Caught() 
        {
            return false;
        }


    }
}
