using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace MonoGame2.Scripts
{
    internal class Menu
    {
        private Vector2 screensize;

        public Menu(Vector2 dimensions) 
        {
            screensize = dimensions;
        }

        public E_Gamestates Update(Game1 game1) 
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Mouse.GetState().X >= 0 && Mouse.GetState().X <= screensize.X - 1f && Mouse.GetState().Y >= 0 && Mouse.GetState().Y <= screensize.Y - 1f)
            {
                return E_Gamestates.PLAY;
            }
            else if (Mouse.GetState().RightButton == ButtonState.Pressed && Mouse.GetState().X >= 0 && Mouse.GetState().X <= screensize.X - 1f && Mouse.GetState().Y >= 0 && Mouse.GetState().Y <= screensize.Y - 1f)
            {
                return E_Gamestates.GAME_OVER;
            }
            else if (Keyboard.GetState().Equals(Keys.Escape)) 
            {

            }
            return E_Gamestates.MENU;
        }

        public void Draw(GraphicsDevice graphicsDevice) 
        {
            graphicsDevice.Clear(Color.White);
        }
    }
}
