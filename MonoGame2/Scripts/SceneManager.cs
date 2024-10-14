using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.XAudio2;

namespace MonoGame2.Scripts
{
    enum E_Gamestates
    {
        MENU, PLAY, GAME_OVER
    }

    internal class SceneManager
    {
        private E_Gamestates gamestate;
        private Menu menu;
        private PlayGame play;
        private GameOver gameover;

        public SceneManager(Vector2 vector2)
        {   
            gamestate = E_Gamestates.MENU;
      
            gameover = new GameOver();
            play = new PlayGame();
        }

        public void Update(Game1 game, GameTime time) 
        {
            double deltatime = time.ElapsedGameTime.TotalSeconds;
            switch (gamestate) 
            {
                case E_Gamestates.PLAY:
                    SwitchState(play.Update());
                    break;
                case E_Gamestates.GAME_OVER:
                    SwitchState(gameover.Update(deltatime));
                    break;
                case E_Gamestates.MENU:
                    SwitchState(menu.Update(game));
                    break;
            }
        }


        public void LoadContent (ContentManager contentManager, GraphicsDeviceManager graphicsDeviceManager)
        {
            play.LoadContent(contentManager, graphicsDeviceManager);
            menu = new Menu(play.GetScreenWH());
        }

        public void Draw(GraphicsDevice graphics, SpriteBatch spriteBatch) 
        {
            switch (gamestate)
            {
                case E_Gamestates.PLAY:
                    play.Draw(graphics, spriteBatch);
                    break;
                case E_Gamestates.GAME_OVER:
                    gameover.Draw(graphics);
                    break;
                case E_Gamestates.MENU:
                    menu.Draw(graphics);
                    break;
            }
            spriteBatch.Begin();
            spriteBatch.End();
        }

        private void SwitchState(E_Gamestates state)
        {
            gamestate = state;
        }
    }
}
