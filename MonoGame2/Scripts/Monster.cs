using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoGame2.Scripts
{
    internal class Monster
    {
        private protected Vector2 StartPos;
        private protected Vector2 CurPos;


        private void MoveCreature(Vector2 posititon) 
        {
            
            CurPos = posititon;



        }

        private void Start()
        {
            CurPos=StartPos;
        }

        public Vector2 GetCurPos() 
        {
            return CurPos;
        }

        public void ResetStartPos()
        {
            StartPos = CurPos;
        }


        public void up ()
        {
            CurPos.Y += 1.0f;
        }

        public void Down()
        {
            CurPos.Y -= 1.0f;
        }
        public void Left()
        {
            CurPos.X -= 1.0f;
        }

        public void Right()
        {
            CurPos.X += 1.0f;
        }


    }
}
