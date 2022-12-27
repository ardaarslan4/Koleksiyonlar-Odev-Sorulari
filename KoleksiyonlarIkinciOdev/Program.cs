using System;

namespace KoleksiyonlarIkinciOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını
            console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/
            int[] sayiDizisi = new int[6];
            Console.WriteLine("Lütfen 20 adet pozitif sayi giriniz:");
            
            for (int i =0; i<20; i++)
            {
                Console.WriteLine("Lütfen {0}.sayiyi giriniz:",i+1);
                //int sayilar = int.Parse(Console.ReadLine());
                //sayiDizisi.Append<int>(int.Parse(Console.ReadLine()));
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(sayiDizisi);
            Console.WriteLine(string.Join(",", sayiDizisi));

            int sumEnBuyukSayilar=0;
            int sumEnKucukSayilar =0;

            for(int i=19; i>16; i--)
            {
                sumEnBuyukSayilar += sayiDizisi[i];
                Console.WriteLine(sumEnBuyukSayilar);
            }

            for(int i=0; i<3; i++)
            {
                sumEnKucukSayilar += sayiDizisi[i];
                Console.WriteLine(sumEnKucukSayilar);

            }
            int OrtSumEnBuyukSayilar = sumEnBuyukSayilar/3;
            int OrtSumEnKucukSayilar = sumEnKucukSayilar/3;
            double OrtSumEnBuyukEnKucukSayilar = (double)(sumEnBuyukSayilar+sumEnKucukSayilar)/(double)6;

            Console.WriteLine("En Büyük 3 Sayinin Ortalamasi:");
            Console.WriteLine(OrtSumEnBuyukSayilar);
            Console.WriteLine("En Küçük 3 Sayinin Ortalamasi:");
            Console.WriteLine(OrtSumEnKucukSayilar);
            Console.WriteLine("En Büyük 3 ve En Küçük 3 Sayinin Ortalamasi:");
            Console.WriteLine(OrtSumEnBuyukEnKucukSayilar);
    
        }
    }
}
