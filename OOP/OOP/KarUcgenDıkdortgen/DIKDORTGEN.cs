using System;
using System.Windows.Forms;
using KarUcgenDıkdortgen;

namespace OOP
{
    public class DIKDORTGEN: IAlan
    {
        private int _kenar1;
        private int _kenar2;

        public DIKDORTGEN(string kenar1, string kenar2)
        {
            _kenar1 = Convert.ToInt32(kenar1);
            _kenar2 = Convert.ToInt32(kenar2);
        }
     

        public DIKDORTGEN(TextBox T1, TextBox T2)
        {
            
            _kenar1 = Convert.ToInt32(T1.Text);
            _kenar2 = Convert.ToInt32(T2.Text);
            
            
        }

        public int Alanhesapla()
        {
            return _kenar1 * _kenar2;
        }

        public string sekiladi()
        {
            return "DİKDÖRTGEN";
        }
    }
}