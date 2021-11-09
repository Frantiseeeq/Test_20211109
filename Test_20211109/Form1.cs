using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Banka banka;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Banka banka = new Banka("Lumír Lumírovec", 10000, 20000);
            lbl_Jmeno.Text = banka.Jmeno;
            lbl_Limit1.Text = banka.Limit1.ToString();
            lbl_Limit2.Text = banka.Limit2.ToString();
            lbl_Stav.Text = banka.Stav.ToString();
        }

        private void btn_Vklad_Click(object sender, EventArgs e)
        {
            int castka = int.Parse(txtBox_Castka.Text);
            banka.Vklad(castka);
            lbl_Stav.Text = banka.Stav.ToString();
        }

        private void btn_Vyber_Click(object sender, EventArgs e)
        {
            int castka = int.Parse(txtBox_Castka.Text);
            banka.Vyber(castka);
            lbl_Stav.Text = banka.Stav.ToString();
        }

        private void txtBox_Limit1_TextChanged(object sender, EventArgs e)
        {
            int castka = int.Parse(txtBox_Limit1.Text);
            
        }
    }
}
