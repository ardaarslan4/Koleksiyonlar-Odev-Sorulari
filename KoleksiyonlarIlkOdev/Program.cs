using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyon_odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)
            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

            List<int> asalSayilarList = new List<int>();
            List<int> asalOlmayanSayilarList = new List<int>();
            
            Console.WriteLine("Lütfen 20 adet pozitif sayi giriniz:");
            
            for (int i =0; i<20; i++)
            {
                Console.WriteLine("Lütfen {0}.sayiyi giriniz:",i+1);
                int sayilar = int.Parse(Console.ReadLine());

                if (sayilar < 0)
                {
                    throw new Exception("Number must be positive!");
                }

                else
                {

                    if(IsPrime(sayilar))
                    {
                        asalSayilarList.Add(sayilar);
                        
                    }
                    else
                    {
                        asalOlmayanSayilarList.Add(sayilar);
                        
                    }
                }
            }


            asalSayilarList.Sort();
            Console.WriteLine("Asal Olan Rakamlarin Siralamasi:");
            Console.WriteLine(string.Join(",", asalSayilarList));

            asalOlmayanSayilarList.Sort();
            Console.WriteLine("Asal Olmayan Rakamlarin Siralamasi:");
            Console.WriteLine(string.Join(",", asalOlmayanSayilarList));

            Console.WriteLine("Asal Olan Rakamlarin sayisi:");
            Console.WriteLine(asalSayilarList.Count());
            Console.WriteLine("Asal Olan Rakamlarin ortalamasi:");
            Console.WriteLine((double)asalSayilarList.Sum()/(double)asalSayilarList.Count());

            Console.WriteLine("Asal Olmayan Rakamlarin sayisi:");
            Console.WriteLine(asalOlmayanSayilarList.Count());
            Console.WriteLine("Asal Olmayan Rakamlarin ortalamasi:");
            Console.WriteLine((double)asalOlmayanSayilarList.Sum()/(double)asalOlmayanSayilarList.Count());

        }

        public static bool IsPrime(int sayi)
        {
            if (sayi <= 1) return false;
            if (sayi == 2) return true;
            if (sayi % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(sayi));
          
            for (int i = 3; i <= boundary; i += 2)
            {
                if (sayi % i == 0)
                return false;
            }       
            return true; 
        }
    }
    
}
