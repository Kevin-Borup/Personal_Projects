using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter();
        }

        static void Starter()
        {
            Manager myManager = new Manager();

            myManager.mgaTest();
            Console.WriteLine(myManager.mgaSum());
            Console.ReadKey();


        }
    }
}
