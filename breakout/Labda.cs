using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakout
{
    public class Ball : RadioButton
    {
        public Ball() : base()
        {

        }
        private int xAlap = 3;
        public int XAlap
        {
            get { return xAlap; }
            set { xAlap = value; }
        }
        private int yAlap = 3;
        public int YAlap
        {
            get { return yAlap; }
            set { yAlap = value; }
        }
        private int xKezdo= 421;
        public int XKezdo
        {
            get { return xKezdo; }
            set { xKezdo = value; }
        }
        private int yKezdo = 500;
        public int YKezdo
        {
            get { return yKezdo; }
            set { yKezdo = value; }
        }
        private int x = 3;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y = 3;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        private int xTouchCount = 1;
        public int XTouchCount
        {
            get { return xTouchCount; }
            set { xTouchCount = value; }
        }
        private int yTouchCount = 1;
        public int YTouchCount
        {
            get { return yTouchCount; }
            set { yTouchCount = value; }
        }

        public void speedChange()
        {
            try
            {
                if (x >= 0)
                {
                    xTouchCount += 1;
                }
                else if (x < 0)
                {
                    xTouchCount -= 1;
                }

                if (y >= 0)
                {
                    yTouchCount += 1;
                }
                else if (y < 0)
                {
                    yTouchCount -= 1;
                }
                if (xTouchCount == 10) //minden tizedik pattanásnál gyorsul a tempó
                {
                    x++;
                    xTouchCount = 0;
                    Debug.WriteLine("labda gorsul: " + x + ";" + y);
                }
                if (yTouchCount == 10) //minden tizedik pattanásnál gyorsul a tempó
                {
                    y++;
                    yTouchCount = 0;
                }
                Debug.WriteLine("labda sebessége: " + x + ";" + y);
            }
            catch(SpeedChangeException e)
            {
                Debug.WriteLine("Hiba a sebesség változtatás közben:" +e.Message);
            }
        }
    }
    public class SpeedChangeException : Exception
    {
        public SpeedChangeException(string message) : base(message) { }
    }
}
