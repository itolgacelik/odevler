using System;
using System.Threading;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, Rulet Oyununa Hoşgeldin :) İlk olarak kaç tur oynayacağını girmelisin");
            int tursayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simdide kaç doların var söyle bakalım");
            int sermaye = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= tursayisi; i++)
            {
                Console.WriteLine(i + "turu için ne kadar para ayıracaksın?");
                int girisparası = Convert.ToInt32(Console.ReadLine());
                if (girisparası > sermaye)
                {
                    Console.WriteLine("Sermayenden fazlasını kullanamazsın");
                    i--;
                    continue;
                }

                int kalansermaye = sermaye - girisparası;
                Console.WriteLine("KALAN PARA = " + kalansermaye);

                
                Console.WriteLine("Lütfen 0-5 arası bir sayıya bahis yap");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                while (tahmin <= 0 || tahmin >= 5)
                {
                    Console.WriteLine("Bu sayıya bahis giremezsin!!");
                    Console.WriteLine("Lütfen 0-5 arası bir sayıya bahis yap");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                }
                
                if (sermaye <= 0 )
                {
                    Console.WriteLine("paran bitti moruq. bas git!!!!");
                    return;
                }
                
                
                var rnd =new Random();
                var rndno = rnd.Next(6);
                Console.Clear();
                Console.WriteLine("veeeeeeeeeeee KAZANAN NUMARA ....");
                Thread.Sleep(new Random().Next(10000)); // 10000 milisanıyeye kadar bekletme sonrakı kodu 
                Console.WriteLine("kazanan sayı = " + rndno);
                
                if (tahmin == rndno && rndno == 0)
                {
                    sermaye = kalansermaye + girisparası * 6;
                    
                    Console.WriteLine("Tebrikler (0) tutturarak giriş paranın 6 katını kazandın. Kalan Sermayen = " + sermaye);
                }
                else if (tahmin == rndno && rndno!= 0)
                {
                    sermaye = kalansermaye + girisparası * 5;
                    Console.WriteLine("Tebrikler (1-5) arası tahmınını tutturarak giriş paranın 5 katını kazandın. Kalan sermaye =  " + sermaye);
                }
                else
                {
                    Console.WriteLine("Maalesef kazanamadın. yeniden deneyiniz");
                    sermaye = kalansermaye;
                    Console.WriteLine("kALAN PARA = " + sermaye);
                }
            }

        }
    }
}