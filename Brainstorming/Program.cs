using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainstorming
{
    class Program
    {
        static void Main(string[] args)
        {
            string drive = "C";
            Console.WriteLine("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            Console.WriteLine($@"Win32_LogicalDisk.DeviceID=""{drive}:""");
        }
    }
}
