

using System.Collections;
using System.ComponentModel;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            //(Array sınıfını kullanarak yazınız.)


            int[] sayilar = new int[6];
            ArrayList buyuk = new ArrayList();
            ArrayList kucuk = new ArrayList();
            int bToplam = 0;
            int kToplam = 0;
            float kOrt = 0;
            float bOrt = 0;


            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Dizinin {0}. elemanını giriniz : ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            Console.WriteLine("En küçük 3 eleman");
            for (int i = 0; i < Math.Min(3, 6); i++)
            {
                Console.WriteLine(sayilar[i]);
                kucuk.Add(sayilar[i]);
                kToplam += sayilar[i];
            }
            Array.Reverse(sayilar);
            Console.WriteLine("En büyük 3 eleman:");
            for (int i = 0; i < Math.Min(3,6); i++)
            {
                Console.WriteLine(sayilar[i]);
                buyuk.Add(sayilar[i]);
                bToplam += sayilar[i];
            }
            kOrt = kToplam / 3;
            bOrt = bToplam / 3;
            Console.WriteLine("Küçük sayıların ortalaması : {0}",kOrt);
            Console.WriteLine("Büyük sayıların ortalaması : {0}", bOrt);
            Console.WriteLine("Ortalama toplamları : {0}",kOrt + bOrt);



        }
    }

    
      

}






