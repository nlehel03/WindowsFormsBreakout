namespace breakout
{
    
    public partial class Form1 : Form
    {
        Deszka d=new Deszka();
        Labda l=new Labda();
        Random r = new Random();
        Tegla t= new Tegla();
        bool isGameOver;
        
        
        

        public Form1()
        {
            InitializeComponent();
            setup();

        }
        private void setup()
        {
            gameTimer.Start();
        }
        private void GameManager()
        {




        }

        private void deszka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && deszka.Left + deszka.Width + l.lepes <= this.ClientSize.Width)
            {

                d.jobbra = false;
                d.balra = true;
            }
            else if (e.KeyCode == Keys.Left && deszka.Left - l.lepes >= 0)
            {


                d.balra = false;
                d.jobbra = true;
            }

        }
        private void mainGameTimer(object sender, EventArgs e)
        {
            if (d.balra == true && !(deszka.Left + deszka.Width + l.lepes > this.ClientSize.Width))
            {
                deszka.Left += l.lepes;
            }
            if (d.jobbra == true)
            {
                deszka.Left -= l.lepes;
            }

            if (deszka.Left - l.lepes < 0)
            {
                d.jobbra = false;
            }
            if (deszka.Right - l.lepes < 0)
            {
                d.balra = false;
            }
            labda.Left += l.x;
            labda.Top += l.y;
            if (labda.Left < 0 || labda.Right > this.ClientSize.Width)
            {
                l.x *= -1;
                l.xTouchCount++;
                if(l.xTouchCount==3)
                {
                    l.x++;
                    l.xTouchCount = 0;
                }

            }
            if (labda.Top < 0)
            {
                l.y *= -1;
                l.yTouchCount++;
                if(l.yTouchCount==3)
                {
                    l.y++;
                    l.yTouchCount = 0;
                }
            }

            if (labda.Bounds.IntersectsWith(deszka.Bounds))
            {
                l.y *= -1;

                
            }

        }
          

    }

}
