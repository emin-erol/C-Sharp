using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    internal class Program
    {
        private static int x;

        static void Main(string[] args)
        {
            int x = 11;
            int y = 7;
            Console.WriteLine($"{x} : {y}");
            Degistir(ref x, ref y);
            Console.WriteLine($"{x} : {y}");

            Console.ReadKey();
        }

        private static void Degistir(ref int a, ref int b) // Objelerdeki değişiklikleri kalıcı yapar
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine($"{a} : {b}");
        }

        private static double Topla(params double[] Seri) // Dinamik olarak gönderilen objeleri tutma
        {
            double toplam = 0;
            foreach (var s in Seri)
                toplam += s;
            return toplam;
        }

        public static int Karsilastir(int a,int b)
        {
            return a>b ? a : b;
        }
    }
}
