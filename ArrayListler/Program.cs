using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

        private static void ListOlusturma()
        {
            int[] Seri = new int[] { 10, 20, 30 };
            // Tanımlama
            List<int> Sayilar = new List<int>();

            // Eleman ekleme
            Sayilar.Add(1);
            Sayilar.Add(2); // İçine yazılan değer listeye eklenir
            Sayilar.Add(3);
            Sayilar.AddRange(Seri); // İçine yazılan diziyi listeye ekler

            // Yazdırma
            foreach (int i in Sayilar)
                Console.Write(i + "  ");
            Console.WriteLine();

            // Araya eleman ekleme
            Sayilar.Insert(2, 29); // Belirtilen indise belirtilen değeri ekler
            Sayilar.InsertRange(4, new int[] { 100, 200, 300 }); // Belirtilen indisten itibaren belirtilen dizi eklenir
            foreach (int i in Sayilar)
                Console.Write(i + "  ");
            Console.WriteLine();

            // Eleman Silme
            Sayilar.RemoveAt(0); // Belirtilen indisteki değeri listeden kaldırır
            Sayilar.Remove(100); // Belirtilen değeri listeden kaldırır
            Sayilar.RemoveRange(2, 3); // Belirtilen indisten itibaren belirtilen sayi kadar eleman kaldırılır
            foreach (int i in Sayilar)
                Console.Write(i + "  ");
            Console.WriteLine();

            // Listeyi sıralama
            Sayilar.Sort();
            foreach (int i in Sayilar)
                Console.Write(i + "  ");
        }

        private static void ArrayListler()
        {
            // Oluşturma
            var DiziListesi = new ArrayList();

            // Eleman Ekleme
            DiziListesi.Add(10);
            DiziListesi.Add("Emin Erol");
            DiziListesi.Add(2);
            DiziListesi.Add(true);

            // Dolaşma
            foreach (var i in DiziListesi)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();

            // ArrayList'e dizi ekleme
            int[] dizi = new int[] { 17, 29, 8 };
            DiziListesi.AddRange(dizi);
            foreach (var i in DiziListesi)
                Console.Write(i + "  ");
            Console.WriteLine();

            // Elemana erişme
            Console.WriteLine(DiziListesi[3]);

            // Eleman silme
            DiziListesi.RemoveRange(0, 4); // Belirtilen indisten başlanarak belirtilen adet kadar eleman kaldırılır
            DiziListesi.Remove(17);        // Belirtilen değeri listeden kaldırır
            DiziListesi.RemoveAt(0);       // Belirtilen indisi listeden kaldırır
            foreach (var i in DiziListesi)
                Console.Write(i + "  ");
        }
    }
}
