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

    public partial class Ranglista : Form
    {
        public Ranglista()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(rangLista_FormClosing);
        }
        
        private void listaz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Fajlkezeles fajlkezeles = new Fajlkezeles();
            fajlkezeles.olvasas();
            for(int i = 0;i<fajlkezeles.Lista.Count;i++)
            {
                listBox1.Items.Add(i+1+". "+fajlkezeles.Lista[i].Nev+" " + fajlkezeles.Lista[i].PontSzam);
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            Menu m= new Menu();
            var currentPosition = this.Location;
            var currentSize = this.Size;
            m.StartPosition = FormStartPosition.Manual;
            m.Location = currentPosition;
            m.Size = currentSize;
            m.Show();
            this.Hide();
        }
        private void rangLista_FormClosing(object? sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Debug.WriteLine("Ranglista form bezáródik");
                Application.Exit();
            }
        }
    }
}
