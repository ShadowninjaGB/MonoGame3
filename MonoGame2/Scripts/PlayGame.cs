﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using Microsoft.Xna.Framework.Content;

namespace MonoGame2.Scripts
{
    internal class PlayGame
    {
        private Enemy enemy;
        private Player player;
        private Vector2 screensize;
        private Level level;
        public PlayGame()
        {
            player = new Player(new Vector2(200, 200), 3);
            System.Console.WriteLine("Player position = " + player.GetCurPos());
            enemy = new Enemy(new Vector2(50,50));
            System.Console.WriteLine("Enemy position = " + enemy.GetCurPos());
            level = new Level();

        }

        public void LoadContent (ContentManager contentManager, GraphicsDeviceManager graphicsDeviceManager)
        {
            player.LocalContent(contentManager, "Chara6");
            enemy.LocalContent(contentManager, "Orc2");
            level.LoadContent(contentManager, "Wall1");
            graphicsDeviceManager.PreferredBackBufferWidth = (int)level.GetLevelSize().X;
            graphicsDeviceManager.PreferredBackBufferHeight = (int)level.GetLevelSize().Y;
            graphicsDeviceManager.ApplyChanges();

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
            if (Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A))
            {
                player.Left();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W))
            {
                player.up();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D))
            {
                player.Right();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S))
            {
                player.Down();
            }

            enemy.Chase(player);
            System.Console.WriteLine("Player Pos = " + player.GetCurPos()+ "Player Lives"+ player.GetLives());
            System.Console.WriteLine("Enemy Pos = " + enemy.GetCurPos());
            if (enemy.Caught(player))
            {
                player.RemoveLives();
                System.Console.WriteLine("Player isnt skibidi");
                player.ResetStartPos();
                enemy.ResetStartPos();
                if (player.GetLives() == 0) 
                {
                    player.ResetLives();
                    player.ResetStartPos();
                    enemy.ResetStartPos();
                    level.ResetLevels();
                    return E_Gamestates.GAME_OVER;
                }
            }
            System.Console.WriteLine(player.GetLives());
            return E_Gamestates.PLAY;
            
            
        }

        public void Draw(GraphicsDevice graphicsDevice, SpriteBatch spriteBatch)
        {
            graphicsDevice.Clear(Color.Green);
            spriteBatch.Begin();
            level.Draw(spriteBatch);
            player.Draw(spriteBatch, new Rectangle(0, 0, 52, 72));
            enemy.Draw(spriteBatch, new Rectangle(0, 0, 52, 72));
            spriteBatch.End();
        }

        public Vector2 GetScreenWH()
        {
            return level.GetLevelSize();
        }
    }
}
