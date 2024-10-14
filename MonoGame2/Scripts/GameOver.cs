using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;                                                                                  
namespace MonoGame2.Scripts
{
    internal class GameOver
    {
        private double timelimit = 3f;
        private double totaltime = 0.0f;

        private Vector2 screensize;
        public GameOver()
        {

        }

        public E_Gamestates Update(double deltatime)
        {
            totaltime += deltatime;
            if (totaltime >= timelimit)
            {
                totaltime = 0.0f;
                return E_Gamestates.MENU;
            }
            return E_Gamestates.GAME_OVER;
        }

        public void Draw(GraphicsDevice graphicsDevice)
        {
            graphicsDevice.Clear(Color.HotPink);
        }
    }
}
