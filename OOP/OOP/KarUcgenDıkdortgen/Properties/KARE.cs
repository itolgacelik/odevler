using System;
using System.Runtime.Remoting.Messaging;
using KarUcgenDıkdortgen;

namespace OOP
{
    public class KARE: IAlan
    {
        private int kenar;

        public KARE(string kenar)
        {

            this.kenar = Convert.ToInt32(kenar);

        }


        public KARE(int kenar)
        {
            this.kenar = kenar;
        }
       


        public int Alanhesapla()
        {
            return kenar * kenar;
        }

        public string sekiladi()
        {
            return "KARE";
        }
    }
}