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

        private void SetLevelNumber() 
        {
            LevelNum = 1;
            BuildNewLevel();
        }

        private void LoadContent (ContentManager contentManager, string FileName)
        {
            contentManager.Load<Texture2D>(FileName);
            WallTextureWH = new Vector2 (WallTexture.Bounds.X, WallTexture.Bounds.Y);
        }

        private int GetArrayWidth()
        {
            return LevelFile[0].Length;
        }

        private int GetArrayHeight()
        {
            return LevelFile.Length;
        }

        private Vector2 GetLevelSize()
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
        private void ResetLevels()
        {
            LevelNum = 1;
            BuildNewLevel();
        }

        private void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < GetArrayWidth(); i++) 
            {
                for (int j = 0; j < GetArrayHeight(); j++)
                {
                    if (LevelFile[i] == "W")
                    {
                        spriteBatch.Draw(WallTexture, new Vector2(WallTexture.Width * i, WallTexture.Height * j), Color.HotPink);
                    }
                }
            }
        }
    }
}
