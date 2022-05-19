using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calismalarim.Struct
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int numara;
            string ad, soyad;
            Console.Write("Kayit sayisini giriniz: ");
            int KayitSayisi = int.Parse(Console.ReadLine());
            var OgrenciListesi = new List<Ogrenci>();
            for (int i = 0; i < KayitSayisi; i++)
            {
                Console.WriteLine($"{i+1}. Ogrenci;");
                Console.Write("Isim: ");
                ad = Console.ReadLine();
                Console.Write("Soyad: ");
                soyad = Console.ReadLine();
                Console.Write("Numara: ");
                numara = int.Parse(Console.ReadLine());
                (ad, soyad, numara);
            }
            foreach(Ogrenci i in OgrenciListesi)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
