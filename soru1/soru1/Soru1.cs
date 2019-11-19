using System;

namespace soru1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
           Console.WriteLine("Lütfen 1. sayıyı giriniz");
           var sayı1 = Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("lütfen '+', '-', 'x', '/' işlemlerinden yapmak istediğinizi giriniz");
           var islem = Console.ReadLine();
           
           Console.WriteLine(("lütfen ikinci sayıyı gırınız"));
           var sayı2 = Convert.ToInt32(Console.ReadLine());
           
           if (islem == "+")
           {
               var sonuc = sayı1 + sayı2;
               Console.WriteLine("İşlem sonucu = " + sonuc);
           }
           
           else if (islem == "-")
           {
               var sonuc = sayı1 - sayı2;
               Console.WriteLine("İşlem sonucu = " + sonuc);
           }
           else if (islem == "*")
           {
               var sonuc = sayı1 * sayı2;
               Console.WriteLine("İşlem sonucu = " + sonuc);
           }
           else if (islem == "/")
           {
               var sonuc = sayı1 / sayı2;
               Console.WriteLine("İşlem sonucu = " + sonuc);
           }
           else
           {
               Console.WriteLine("Lütfen girdiğiniz sayıları ve işlem türünü kontrol ediniz ve tekrar giriniz!");
               
           }
               
           // buraya işlemin başa dönmesini sağlamaya çalıştım ama olmadı. goto 
           Console.ReadKey();


        }
    }
}