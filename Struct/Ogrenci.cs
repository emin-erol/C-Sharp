using System;

namespace Calismalarim.Struct
{
    internal partial class Program
    {
        public struct Ogrenci
        {
            public Ogrenci(string isim,string soyisim,int no) // Constructor metod tanımladık
            {
                OgrNo = no;
                Ad = isim;
                Soyad = soyisim;
            }
            public int OgrNo { get; set; } // Ozellik tanimliyoruz
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public override string ToString()
            {
                return $"{Ad,-5} " +
                       $"{Soyad,-5} " +
                       $"{OgrNo,-5}";
            }
        }
    }
}
