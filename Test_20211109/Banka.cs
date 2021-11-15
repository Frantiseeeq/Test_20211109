using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Test_20211109
{
    public class Banka
    {
        public string Jmeno;
        public int Limit1 = 10000;
        public int Limit2 = 20000;
        public int Stav = 0;

        public Banka(string jmeno, int limit1, int limit2)
        {
            this.Jmeno = jmeno;
            this.Limit1 = limit1;
            this.Limit2 = limit2;
        }

        public void Vklad(int castka)
        {
            if (castka <= 200000)
            {
                Stav += castka;
            }
            else if(castka < 0)
            {
                MessageBox.Show("Nelze vložit záporná čísla");
            }
            else
            {
                MessageBox.Show("Nelze vložit více než 200000 Kč");
            }
        }

        public void Vyber(int castka) 
        {
            if(castka < 0)
            {
                MessageBox.Show("Nelze vybrat záporná čísla");
            }
            else if(castka > Limit1)
            {
                MessageBox.Show($"Nelze vybrat, protože váš limit je {Limit1}");
            }
            else
            {
                Stav -= castka;
            }
            
        }

        public void Platba(int castka)
        {
            if(castka <= Limit2)
            {
                Stav -= castka;
            }
            else
            {
                MessageBox.Show($"Nelze zaplatit {castka}");
            }
        }

        public void limit1(int castka)
        {
            if(castka > 0 )
            {
                Limit1 = castka;
            }
            else
            {
                MessageBox.Show("Zadali jste záporný limit");
            }
        }

        public void limit2(int castka)
        {
            if (castka > 0)
            {
                Limit2 = castka;
            }
            else
            {
                MessageBox.Show("Zadali jste záporný limit");
            }
        }

        public void platba(int castka)
        {
            if(castka > Limit2)
            {
                MessageBox.Show("Nelze jít přes váš limit");
            }
            else if(castka < 0)
            {
                MessageBox.Show("Nelze platit zápornými čísly");
            }
            else
            {
                Stav -= castka; 
            }
        }
    }
}
