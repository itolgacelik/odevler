using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP;

namespace KarUcgenDıkdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<IAlan> ALANLAR = new List<IAlan>();

        private void karealanhesapla_Click(object sender, EventArgs e)
        {
            var kare = new KARE(Karekenar.Text);

            ALANLAR.Add(kare); // HER BUTONU BASILDIGINDA kare EKLER
            Karekenar.Text = "";
        }

        private void ucgenalanhesapla_Click(object sender, EventArgs e)
        {
            var ucgen = new UCGEN(ucgenkenar1.Text, ucgenkenar2.Text);

            ALANLAR.Add(ucgen);
            ucgenkenar1.Text = "";
            ucgenkenar2.Text = "";
        }

        private void dıkdortgenalanhesapla_Click(object sender, EventArgs e)
        {
            var dikdortgen = new DIKDORTGEN(dıkdortgenkenar1, dıkdortgenkenar2);

            ALANLAR.Add(dikdortgen);
            dıkdortgenkenar1.Text = "";
            dıkdortgenkenar2.Text = "";
        }

        private void ALANHESABI_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ALANLAR.Count; i++)
            {
                listBox1.Items.Add(ALANLAR[i].sekiladi() + i + " alanı = " + ALANLAR[i].Alanhesapla());
            }

        }
    }
}