using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace breakout
{
    public class GameModel
    {
        public Ball Labda { get; set; }= new Ball();
        public Board Deszka { get; set; } = new Board();
        public int points { get; set; }
        public int lives { get; set; }
        public List<Button> teglak { get; private set; } = new List<Button>();
        public event EventHandler<GameModel>? gameOver;
        public event EventHandler<int>? liveChanged;
        public event EventHandler<int>? pointChanged;
        public event EventHandler<Button>? brickRemoved;
        public GameModel() { }
        public GameModel(Ball l, Board d)
        {
            Labda = l;
            Deszka = d;
            
            lives = 3;
        }
        //public void reset()
        //{
        //    points = 0;
        //    lives = 3;
        //}
        public void addPoints()
        {
            try
            {
                points++;
            }
            catch (AddPointException e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
        }
        public void ballMove()
        {
            try
            {
                Labda.Left -= Labda.X;
                Labda.Top -= Labda.Y;
                //Debug.WriteLine(Labda.Location.X + ";" + Labda.Location.Y);
            }
            catch (BallMoveException e)
            {
                Debug.WriteLine("Hiba a labda mozgása közben: " + e.Message);
            }

        }
        public void ballBounceHorizontal()
        {
            try
            {
                Labda.X *= -1;
                Labda.speedChange();
            }
            catch (BallBounceException e)
            {
                Debug.WriteLine("Hiba a labda pattogása közben: " + e.Message);
            }
        }
        public void ballBounceVertical()
        {
            try
            {

                Labda.Y *= -1;
                Labda.speedChange();
            }
            catch (BallBounceException e)
            {
                Debug.WriteLine("Hiba a labda pattogása közben: " + e.Message);
            }
        }
        public void ballFall()
        {
            try
            {
                lives -= 1;
                liveChanged?.Invoke(this, lives);
                Labda.Location = new Point(Labda.XKezdo, Labda.YKezdo);
                if (lives > 0)
                {
                    Labda.Location = new Point(Labda.XKezdo, Labda.YKezdo);
                    ballBounceVertical();
                }
                else
                {
                    endGame();
                }
            }
            catch (BallFallException e)
            {
                Debug.WriteLine("Hiba a labda leesése közben: " + e.Message);
            }
        }
        public void over30()
        {
            try
            {
                if (points >= 30)
                {
                    points += lives * 5;
                    endGame();
                }
            }
            catch (Over30Exception e)
            {
                Debug.WriteLine("Hiba a játék végi kilépésnél: " + e.Message);
            }
        }
        public void CheckCollision(Ball labda)
        {
            try
            {
                for (int i = teglak.Count - 1; i >= 0; i--)
                {
                    var brick = teglak[i];
                    if (labda.Bounds.IntersectsWith(brick.Bounds))
                    {
                        teglak.RemoveAt(i);
                        addPoints();
                        pointChanged?.Invoke(this, points);
                        brickRemoved?.Invoke(this, brick);
                        labda.speedChange();
                        labda.Y *= -1;
                        break;
                    }
                }
            }
            catch (CheckCollisionException e)
            {
                Debug.WriteLine("Hiba az ütközés-ellenőrzésnél: " + e.Message);
            }
        }

        public void endGame()
        {
            try
            {
                gameOver?.Invoke(this, this);
                GameOver go = new GameOver(points);
                go.ShowDialog();
            }
            catch (EndGameException e)
            {
                Debug.WriteLine("Hiba a kilépésnél: " + e.Message);
            }
        }
    }
    public class EndGameException : Exception
    {
        public EndGameException(string m) : base(m) { }
    }
    public class CheckCollisionException : Exception
    {
        public CheckCollisionException(string m) : base(m) { }
    }
    public class Over30Exception : Exception
    {
        public Over30Exception(string m) : base(m) { }
    }
    public class BallFallException : Exception
    {
        public BallFallException(string m) : base(m) { }
    }
    public class BallBounceException : Exception
    {
        public BallBounceException(string m) : base(m) { }
    }
    public class BallMoveException : Exception
    {
        public BallMoveException(string m) : base(m) { }
    }
    public class AddPointException : Exception
    {
        public AddPointException(string m) : base(m) { }
    }
}
