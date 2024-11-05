using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace breakout
{
    public class Fajlkezeles
    {
        const string fajlnev = "ranglista.txt";
        private List<ListaElem> lista = new List<ListaElem>();

        public List<ListaElem> Lista
        {
            get { return lista; } 
            set { lista = value; } 
        }
        public Fajlkezeles()
        {
            olvasas();

            
        }
        public void olvasas()
        {
            try
            {
                if (File.Exists(fajlnev))
                {
                    StreamReader sr = new(fajlnev);
                    lista = new List<ListaElem>();
                    ListaElem a = new ListaElem();
                    while (!sr.EndOfStream)
                    {
                        string? sor = sr.ReadLine();
                        if (!string.IsNullOrEmpty(sor)) // Null vagy üres ellenőrzés
                        {
                            string[] temp = sor.Split(";");
                            a.Nev = temp[1];
                            a.PontSzam = int.Parse(temp[2]);
                            lista.Add(a);
                        }
                    }
                    sr.Close();
                }
                else
                {
                    Debug.WriteLine("A fájl nem létezik: " + fajlnev);
                }
            }
            catch (FileNotFoundException E)
            {
                Debug.WriteLine("A fájl nem található:" + E.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine("I/O hiba történt a fájl olvasása közben: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt az olvasás közben: " + ex.Message);
            }
        }
        public void iras()
        {
            try
            {
                StreamWriter sw = new(fajlnev);
                for (int i = 0; i < lista.Count; i++)
                {
                    sw.WriteLine(i + ";" + lista[i].Nev + ";" + lista[i].PontSzam);
                }
                sw.Flush();
                sw.Close();
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine("Nincs jogosultság a fájl írásához: " + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine("I/O hiba történt a fájl írása közben: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt az írás közben: " + ex.Message);
            }
        }
        public void hozzaad(string nev, int pont)
        {
            try
            {
                Debug.WriteLine("kozzáad meghívva");
                olvasas();
                ListaElem x = new ListaElem();
                x.Nev = nev;
                x.PontSzam = pont;
                lista.Add(x);
                rendez();
                for (int i = 0; i < lista.Count; i++)
                {
                    Debug.WriteLine(lista[i].Nev);
                }
                iras();
            }
            catch (AddPointException ex)
            {
                Debug.WriteLine("Hiba történt a hozzáadás közben: " + ex.Message);
            }
        }
        private void rendez()
        {
            try
            {
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    for (int j = i + 1; j < lista.Count; j++)
                    {
                        if (lista[j].PontSzam > lista[i].PontSzam)
                        {
                            ListaElem x = lista[j];
                            lista[j] = lista[i];
                            lista[i] = x;

                        }
                    }
                }
            }
            catch (SortException ex)
            {
                Debug.WriteLine("Hiba történt a rendezés közben: " + ex.Message);
            }

        }
        
        public class AddException : Exception
        {
            public AddException(string m) : base(m) { }
        }
        public class SortException : Exception
        {
            public SortException(string m) : base(m) { }
        }
    }
    public struct ListaElem
    {
        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        private int pontSzam;
        public int PontSzam
        {
            get { return pontSzam; }
            set { pontSzam = value; }
        }
    }

}


