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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }
        private void Menu_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Jatek j = new Jatek();
                var currentPosition = this.Location;
                j.StartPosition = FormStartPosition.Manual;
                j.Location = currentPosition;
                j.Show();
            }
            catch (GameStartException ex)
            {
                Debug.WriteLine("Hiba a játék betöltése közben"+ex.Message);
            }
        }

        private void topListButton_Click(object sender, EventArgs e)
        {
            //try { 
            this.Hide();
            Ranglista r = new Ranglista();
            var currentPosition = this.Location;
            var currentSize = this.Size;
            r.StartPosition = FormStartPosition.Manual;
            r.Location = currentPosition;
            r.Size = currentSize;
            r.Show();
            //}
            //catch (RankingListException ex)
            //{
            //    Debug.WriteLine("Hiba a ranglista betöltése közben" + ex.Message);
            //}
        }
    }
    public class GameStartException : Exception
    {
        public GameStartException(string m) : base(m) { }
    }
    public class RankingListException : Exception
    {
        public RankingListException(string m) : base(m) { }
    }
}
