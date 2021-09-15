using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Brainstorming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(int).Name);

            /*
            DateTime today = DateTime.Now;
            CultureInfo provider = CultureInfo.InvariantCulture;

            Console.WriteLine(today.ToString("yyyy/MM/dd HH:mm", provider));
            Console.ReadKey();
            */
            /*
            List<string> persons = new List<string>();
            string mikkel = "07061993";
            string kevin = "19121999";
            string dude = "14092000";

            persons.Add(mikkel);
            persons.Add(kevin);
            persons.Add(dude);

            foreach (string person in persons)
            {
                Console.WriteLine(YearsAndDays(person));
            }
            */
            //inputMethod1();
            //inputMethod2();
            /*
            string birthDate = "07061993";
            DateTime today = DateTime.Today;
            DateTime birthDateTime = DateTime.ParseExact(birthDate, "ddMMyyyy", null);

            int daysInBetween = -(today.DayOfYear - birthDateTime.DayOfYear);

            string years = (today.Year - 1 - birthDateTime.Year).ToString();
            string days = (365 - daysInBetween).ToString();

            string[] age = new string[2];
            age[0] = years;
            age[1] = days;

            Console.WriteLine($"Age: {years} Years & {days} Days");
            // Correct result = 21 Years & 269 Days
            */

            /*
            string folder = "HealthClinic";
            string file = "patient";
            Directory.CreateDirectory(folder);
            FileStream patientFile = new FileStream($"{folder}\\{file}.txt", FileMode.CreateNew);
            StreamWriter writer = new StreamWriter(patientFile);

            writer.WriteLine("Hej");

            writer.Close();
            */
        }

        static string YearsAndDays(string birthDate)
        {
            DateTime birth = DateTime.ParseExact(birthDate, "ddMMyyyy", null);
            DateTime today = DateTime.Now;
            DateTime thisBDay = new DateTime(today.Year, birth.Month, birth.Day);

            // Default: Birthday has already happened.
            int years = today.Year - birth.Year;
            int days = today.DayOfYear - thisBDay.DayOfYear;

            // If birthday hasn't happened yet, don't count this year, and reverse amount of days.
            if (DateTime.Compare(today.Date, thisBDay.Date) < 0) 
            {
                years -= 1;
                days = 365 + days;
            }

            return $"{years} Years & {days} Days";
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

    // A way to lock the Console to one size, and disable resizing.
    // Reference: Carlo Mercuri
    class Display
    {

        // Calling this library:
        // using System.Runtime.InteropServices;

        // Console size hack, makes it so you cannot resize it
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        /// <summary>
        /// Makes it so you cannot resize or maximize it
        /// </summary>
        public static void LockConsole()
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }
        }
    }
}
