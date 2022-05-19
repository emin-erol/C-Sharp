using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Alt_Ve_Ust_Limitleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Signed 8-bit integer
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit       :{SByte.MinValue}");
            Console.WriteLine($"Ust limit       :{SByte.MaxValue}");
            Console.WriteLine($"Boyut           :{sizeof(SByte)}");
            Console.WriteLine();
            Console.ReadKey();
            // Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit       :{Byte.MinValue}");
            Console.WriteLine($"Ust limit       :{Byte.MaxValue}");
            Console.WriteLine($"Boyut           :{sizeof(Byte)}");
            Console.WriteLine();
            Console.ReadKey();
            // Signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit       :{Int16.MinValue}");
            Console.WriteLine($"Ust limit       :{Int16.MaxValue}");
            Console.WriteLine($"Boyut           :{sizeof(Int16)}");
            Console.WriteLine();
            Console.ReadKey();
            // Unsigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit       :{UInt16.MinValue}");
            Console.WriteLine($"Ust limit       :{UInt16.MaxValue}");
            Console.WriteLine($"Boyut           :{sizeof(UInt16)}");
            Console.WriteLine();
            Console.ReadKey();
            // Signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit       :{Int32.MinValue}");
            Console.WriteLine($"Ust limit       :{Int32.MaxValue}");
            Console.WriteLine($"Boyut           :{sizeof(Int32)}");
            Console.WriteLine();
            Console.ReadKey();
            // Unsigned 32-bit integer
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt limit       :{UInt32.MinValue}");
            Console.WriteLine($"Ust limit       :{UInt32.MaxValue}");
            Console.WriteLine($"Boyut           :{sizeof(UInt32)}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
