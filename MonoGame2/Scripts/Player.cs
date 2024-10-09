using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.XAudio2;

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
            movementSpeed = 2.0f;
        }

        public override void Left()
        {
            base.Left();
        }

        public override void Down()
        {
            base.Down();
        }

        public override void Right()
        {
            base.Right();
        }

        public override void up()
        {
            base.up();
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
