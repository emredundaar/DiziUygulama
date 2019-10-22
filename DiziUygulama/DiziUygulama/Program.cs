using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];          
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {               
                sayi = rnd.Next(1, 100);

                a[i] = sayi;               
                Console.WriteLine(a[i]);
            }
           
            
            Console.WriteLine("Sayı Giriniz: ");
            bool sonuc=false;
            int girilensayi=Convert.ToInt32(Console.ReadLine());
            for (int kk=0;kk<dizi.length;kk++)
            {
	        if (a[kk]==girilensayi)
		    sonuc=true;
            }
            if (sonuc==true)
            {
	        Console.WriteLine("Girdiğiniz Sayı Dizide Mevcut!");
            }
            else
            {
	        Console.WriteLine("Girdiğiniz Sayı Dizide Mevcut Değil!");
            }
            Console.ReadKey();
        }
    }
}
