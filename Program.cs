using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to memory leak");
            LeakyApp app = new LeakyApp();
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
