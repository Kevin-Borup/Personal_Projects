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

            Person Jacob = new Person();

            Jacob.job.Add(new Doctor());

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
