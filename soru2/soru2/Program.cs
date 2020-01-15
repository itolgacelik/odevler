using System;

namespace soru2
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Kaç sınava girdin?");
            var sınavadedi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            
            for (int i = sınavadedi; i > 0; i--)
            {
                Console.WriteLine("Lütfen " + i + " no lu sınav sonucunu giriniz");
                var sınavsonucu = Convert.ToInt32(Console.ReadLine());

                // if (sınavsonucu <= 100 && sınavsonucu >= 0)
                if(0 <= sınavsonucu && sınavsonucu <= 100)
                {
                    toplam = toplam + sınavsonucu;
                    
                }
                else
                {
                    Console.WriteLine("sınav sonucu 0 ile 100 arasında olmalı");
                    return;
                }

               
            }
            var ortalama = toplam*1.0 / sınavadedi;
            Console.WriteLine("Sınavlarınızın ortalaması = " + ortalama);
            
        }           
    }
}