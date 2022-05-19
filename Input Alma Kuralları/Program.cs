using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Alma_Kuralları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gecici;
            Console.WriteLine("Matrisin boyutlarini giriniz");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] matris = new int[a, b];
            int[] SatirlarToplami = new int[a];
            var r = new Random();
            for(int i = 0; i < a; i++)
                SatirlarToplami[i] = 0;
            for(int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matris[i, j] = r.Next(1, 50);
                    Console.Write($"{matris[i,j],5}");
                    SatirlarToplami[i] += matris[i, j];
                }
                Console.WriteLine("\n");
            }
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j<b; j++)
                {
                    for(int k = 0; k < b - j-1; k++)
                    {
                        if(matris[i,k] > matris[i, k + 1])
                        {
                            gecici = matris[i,k];
                            matris[i,k] = matris[i,k + 1];
                            matris[i, k + 1] = gecici;
                        }
                    }
                }
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{matris[i, j],5}");
                }
                Console.Write($"  ={SatirlarToplami[i],4}");
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

        private static void CokBoyutluDiziOlusturma()
        {
            int[,] matris = new int[4, 4];
            var r = new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = r.Next(1, 10);
                    if (matris[i, j] % 2 != 0)
                    {
                        matris[i, j] = 0;
                    }
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }
                }
            }
            Console.WriteLine("MATRIS:\n");
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j],2}");
                }
                Console.WriteLine();
            }
        }

        private static void RandomSayilarlaDiziOlusturmak()
        {
            Console.Write("Dizinin boyutunu giriniz: ");
            int boyut = int.Parse(Console.ReadLine());
            int[] dizi = new int[boyut];
            var r = new Random();
            for (int i = 0; i < boyut; i++)
                dizi[i] = r.Next(1, 20);
            Console.Write("Dizinin elemanlari: ");
            foreach (int i in dizi)
                Console.Write($"{i,-4}");
        }

        private static void BasitDiziIslemleri()
        {
            Console.Write("Dizinin boyutunu giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            int toplam = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dizinin {i + 1}. elemani: ");
                dizi[i] = int.Parse(Console.ReadLine());
                toplam += dizi[i];
            }
            Console.Write("Dizi: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{dizi[i],-4}");
            }
            Console.WriteLine($"\nDizi elemanlarinin toplami: {toplam}");
            Console.WriteLine($"Dizinin ortalamasi: {toplam / n}");
        }

        private static void InputAlma()
        {
            Console.Write("Bir sayi girin: ");
            int a = Convert.ToInt32(Console.ReadLine()); // Int e convert ederek input alabiliriz
            Console.Write("Bir sayi girin: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ilk sayi: {0}\nIkinci sayi:{1}", a, b);
        }
    }
}
