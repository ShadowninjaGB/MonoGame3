using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System;
using Microsoft.Xna.Framework.Content;

namespace MonoGame2.Scripts
{
    internal class Level
    {
        private Texture2D WallTexture;
        private Vector2 WallTextureWH;
        private string[] LevelFile;
        private int LevelNum;

        public Level() 
        {
            LevelNum = 1;
            BuildNewLevel();
        }

        public void LoadContent (ContentManager contentManager, string FileName)
        {
            WallTexture = contentManager.Load<Texture2D>(FileName);
            WallTextureWH = new Vector2(WallTexture.Width, WallTexture.Height);
        }

        private int GetArrayWidth()
        {
            return LevelFile[0].Length;
        }

        private int GetArrayHeight()
        {
            return LevelFile.Length;
        }

        public Vector2 GetLevelSize()
        {
            return new Vector2(GetArrayWidth() * WallTextureWH.X, GetArrayHeight() * WallTextureWH.Y);
        }


        private int AddLevel()
        {
            LevelNum++;
            return LevelNum;
        }

        private void BuildNewLevel()
        {
            LevelFile = File.ReadAllLines(@"..\Levels\Level " + LevelNum + ".txt");
            foreach (var line in LevelFile)
            {
                Console.WriteLine(line);   
            }
        }
        public void ResetLevels()
        {
            LevelNum = 1;
            BuildNewLevel();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int col = 0; col < GetArrayWidth(); col++) 
            {
                for (int row = 0; row < GetArrayHeight(); row++)
                {
                    if (LevelFile[row][col] == 'W')
                    {
                        spriteBatch.Draw(WallTexture, new Vector2(WallTexture.Width * col, WallTexture.Height * row), Color.HotPink);
                    }
                }
            }
        }
    }
}
