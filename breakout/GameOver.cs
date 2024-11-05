using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breakout
{
    public partial class GameOver : Form
    {
        GameModel gm;
        Fajlkezeles fajl = new Fajlkezeles();
        private int point;
        public GameOver(int p) : base()
        {
            InitializeComponent();
            point = p;
            gm = new GameModel();
            this.FormClosing += new FormClosingEventHandler(gameOver_FormClosing);
        }
        private void gameOver_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            fajl.hozzaad(NevBevitel.Text, point);
            Debug.WriteLine("gomb lenyomva");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Menu m = new Menu();
            var currentPosition = this.Location;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = currentPosition;
            m.ShowDialog();
        }
    }
}
