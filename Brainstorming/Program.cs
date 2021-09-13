using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Brainstorming
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputMethod1();
            //inputMethod2();
            string folder = "HealthClinic";
            string file = "patient";
            Directory.CreateDirectory(folder);
            FileStream patientFile = new FileStream($"{folder}\\{file}.txt", FileMode.CreateNew);
            StreamWriter writer = new StreamWriter(patientFile);

            writer.WriteLine("Hej");

            writer.Close();
        }
        static void inputMethod1()
        {
            string input = string.Empty;

            Console.WriteLine("Type to write...");
            while (true)
            {
                string line = Console.ReadLine();
                if (line.Equals("END")) break; else input += line + "\n";
            }


            Console.WriteLine("");
            Console.WriteLine(input);
        }
        static void inputMethod2()
        {

            string doctor = "Lars Hansen";
            string description;
            Console.WriteLine("Type to write...");
            description = Format1(doctor);
            description = Format2(doctor);
            description = Format3(doctor);
            description = Format4(doctor);
            description = Format5(doctor);
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(description);

            
            string Format1(string doctorName)
            {
                string todayDateFormat = DateTime.Now.ToString("yyyy/MM/dd HH:mm");

                Console.WriteLine($"{todayDateFormat} - {doctorName}:");
                string input = UserInput("\t");

                return input;
            }
            string Format2(string doctorName)
            {
                string todayDateFormat = DateTime.Now.ToString("yyyy/MM/dd '-' HH:mm");

                Console.WriteLine($"{todayDateFormat}");
                Console.WriteLine($"\t{doctorName}:");

                string input = UserInput("\t\t");

                return input;
            }
            string Format3(string doctorName)
            {
                DateTime thisTime = DateTime.Now;
                string todayDateFormat = thisTime.ToString("yyyy/MM/dd");
                string todayTimeFormat = thisTime.ToString("HH:mm");

                Console.WriteLine($"{todayDateFormat} | {todayTimeFormat} | {doctorName} |");
                string input = UserInput("\t");

                return input;
            }
            string Format4(string doctorName)
            {
                string todayDateFormat = DateTime.Now.ToString("yyyy/MM/dd:\n\tHH:mm");

                Console.WriteLine($"{todayDateFormat} - {doctorName}:");
                string input = UserInput("\t");

                return input;
            }
            string Format5(string doctorName)
            {
                string todayDateFormat = DateTime.Now.ToString("yyyy/MM/dd");
                string todayTimeFormat = DateTime.Now.ToString("HH:mm");

                Console.WriteLine($"{todayDateFormat}:");
                Console.WriteLine($"\t{doctorName} ({todayTimeFormat}):");
                string input = UserInput("\t");

                return input;
            }

            string UserInput(string tabs)
            {
                string textBlock = string.Empty;
                while (true)
                {
                    Console.Write(tabs);
                    string line = Console.ReadLine();
                    if (line.Equals("END")) break; else textBlock += tabs + line + "\n";
                }
                return textBlock;
            }
        }
    }

    class Person
    {
        public List<object> job = new List<object>();

    }

    class Doctor
    {
        public bool education;
    }
}
