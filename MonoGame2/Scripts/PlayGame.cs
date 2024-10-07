using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame2.Scripts
{
    internal class PlayGame
    {
        private Vector2 screensize;
        public PlayGame(Vector2 dimensions)
        {
            screensize = dimensions;
        }

        public E_Gamestates Update() 
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                return E_Gamestates.MENU;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                return E_Gamestates.GAME_OVER;
            }
            return E_Gamestates.PLAY;
        }

        public void Draw(GraphicsDevice graphicsDevice)
        {
            graphicsDevice.Clear(Color.Green);
        }
    }
}
