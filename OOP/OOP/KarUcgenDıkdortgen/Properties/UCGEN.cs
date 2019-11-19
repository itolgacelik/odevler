using System;
using KarUcgenDıkdortgen;

namespace OOP
{
    public class UCGEN: IAlan
    {
        private int kenar1;
        private int kenar2;
        
        
     // ctorf komutu ile alttakı constructor u kendı otomatık olusturuyo elle yazmaya gerek yok !
     
        public UCGEN(string kenar1, string kenar2)
        {
            this.kenar1 = Convert.ToInt32(kenar1);
            this.kenar2 = Convert.ToInt32(kenar2);
        }


        public int Alanhesapla()
        {
            return kenar1 * kenar2 / 2;
        }

        public string sekiladi()
        {
            return "UCGEN";
        }
    }
}