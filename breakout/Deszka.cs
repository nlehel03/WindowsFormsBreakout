using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakout
{
    public class Board : NumericUpDown
    {
        public Board() : base() { }


        private int lepes = 20;
        
        public void move(KeyEventArgs e, int formWidth)
        {
            try
            {
                Keys k = e.KeyCode;
                if (k == Keys.Right && this.Left + this.Width + lepes <= formWidth)
                {
                    Left += lepes;
                }
                if (k == Keys.Left && Left - lepes >= 0)
                {
                    Left -= lepes;
                }
            }
            catch(BoardMoveException ex)
            {
                Debug.WriteLine("Hiba a deszka mozgatásában"+ex.Message);
            }
        }
    }
    public class BoardMoveException : Exception
    {
        public BoardMoveException(string m) : base(m) { }
    }
}
