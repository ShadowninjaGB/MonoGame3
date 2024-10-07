using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame2.Scripts
{
    internal class Player : Monster
    {

        private int Init_lives = 3;
        private int Lives;
        private int Player_Score;



        public Player(Vector2 position, int lives) : base(position) 
        {
            Lives = lives;
            Lives = Init_lives;
            Player_Score = 0;
        }

        public int GetLives()
        {
            return Lives;
        }

        public void RemoveLives()
        {
            Lives--;
        }


        public void ResetLives ()
        {
                Lives = Init_lives;
        }

    }
}
