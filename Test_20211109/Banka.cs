using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Test_20211109
{
    class Banka
    {
        public string Jmeno;
        
        public int Limit1;
        public int Limit2;
        public int Stav = 100;

        public Banka(string jmeno, int limit1, int limit2)
        {
            Jmeno = jmeno;
            Limit1 = limit1;
            Limit2 = limit2;
        }

        public void Vklad(int castka)
        {
            if(castka <= 200000)
            {
                Stav += castka;
            }
            else
            {
                MessageBox.Show("Zadejte částku menší než 200000 Kč");
            }
        }

        public void Vyber(int castka) 
        {
            if(castka > 0)
            {
                MessageBox.Show("Nelze vybrat záporná čísla");
            }
            else if(castka > Limit1)
            {
                MessageBox.Show($"Nelze vložit, protozže váš limit je {Limit1}");
            }
            else
            {
                Stav -= castka;
            }
            
        }

        public void Platba(int castka)
        {
            if(castka <= Limit1)
            {
                Stav -= castka;
            }
            else
            {
                MessageBox.Show($"Nelze zaplatit {castka}");
            }
        }
    }
}
