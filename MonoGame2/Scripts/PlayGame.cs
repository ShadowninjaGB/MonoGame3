﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace MonoGame2.Scripts
{
    internal class PlayGame
    {
        private Enemy enemy;
        private Player player;
        private Vector2 screensize;
        public PlayGame(Vector2 dimensions)
        {
            screensize = dimensions;
            player = new Player(new Vector2(200, 200), 3);
            System.Console.WriteLine("Player position = " + player.GetCurPos());
            enemy = new Enemy(new Vector2(50,50));
            System.Console.WriteLine("Enemy position = " + enemy.GetCurPos());

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
                    return E_Gamestates.GAME_OVER;
                }
            }
            return E_Gamestates.PLAY;

            
        }

        public void Draw(GraphicsDevice graphicsDevice)
        {
            graphicsDevice.Clear(Color.Green);
        }
    }
}
