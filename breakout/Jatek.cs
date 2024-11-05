
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace breakout
{
    public partial class Jatek : Form
    {
        GameModel gm;
        Random r = new Random();
        private int point = 0;
        public int Point
        {
            get { return point; }
            set { point = value; }
        }
        private int lives;
        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
        public KeyEventArgs CreateKeyEventArgs(Keys key)
        {

            return new KeyEventArgs(key);
        }

        public Jatek()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(Form1_PreviewKeyDown);
            gm = new GameModel(labda, deszka);
            gm.gameOver += gameModel_GameOver;
            gm.liveChanged += liveChange;
            gm.pointChanged += pointChange;
            gm.brickRemoved += OnBrickRemoved;
            gameTimer.Tick += mainGameTimer;
            this.Controls.Add(gm.Labda);
            this.Controls.Add(gm.Deszka);
            Debug.WriteLine("konstruktor lefutott");
            lives = gm.lives;
            this.FormClosing += new FormClosingEventHandler(Jatek_FormClosing);
        }
        private void Jatek_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void Form1_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }
        private void setup()
        {
            labda.X = labda.XAlap;
            labda.Y = labda.YAlap;
            labda.Location = new System.Drawing.Point(labda.XKezdo, labda.YKezdo);
            livesLabel.Text = "Élet: " + gm.lives;
            point = 0;
            gameTimer.Start();
        }

        private void Jatek_Load(object sender, EventArgs e)
        {
            setup();
            foreach (Control c in this.Controls)
            {
                if (c is Button && Convert.ToString(c.Tag) == "Brick")
                {
                    gm.teglak.Add((Button)c);
                }
            }
        }
        private void gameModel_GameOver(object? sender, GameModel g)
        {
            gameTimer.Stop();
            Debug.WriteLine("game over");
            this.Hide();
            gameTimer.Stop();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys k) //mozgató nyilak figyekése
        {
            KeyEventArgs e = CreateKeyEventArgs(k);
            deszka.move(e, this.ClientSize.Width);
            return base.ProcessCmdKey(ref msg, k);
        }
        private void liveChange(object? sender, int x)
        {
            try
            {
                livesLabel.Text = $"Élet: {x}";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("A label nem található:" + ex.Message);
            }
        }
        private void pointChange(object? sender, int x)
        {
            deszka.Value++;
        }
        private void mainGameTimer(object? sender, EventArgs e)
        {

            try
            {
                gm.ballMove();

                gm.over30();
                if (labda.Left <= 1 || labda.Right >= this.ClientSize.Width - 1) //labda érintkezése az oldalfallal
                {
                    gm.ballBounceHorizontal();

                }
                if (labda.Location.Y <= 1) //labda érintkezése a plafonnal
                {
                    gm.ballBounceVertical();
                }
                if (labda.Location.Y > 582) //labda lezuhanása
                {
                    gm.ballFall();



                }
                if (labda.Bounds.IntersectsWith(deszka.Bounds)) //labda visszapattanása a deszkáról
                {
                    gm.ballBounceVertical();
                }
                gm.CheckCollision(labda);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hiba a játék futása során:" + ex.Message);
            }

        }
        private void OnBrickRemoved(object? sender, Button removedBrick)
        {
            try
            {
                this.Controls.Remove(removedBrick);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hiba a tégla törlése közben" + ex.Message);
            }
        }
    }
}

