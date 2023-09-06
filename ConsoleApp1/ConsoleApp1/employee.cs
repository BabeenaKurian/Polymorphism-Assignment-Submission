using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class employee : IQuittable // inheritance
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

       public void Quit(IQuittable Quitter) // Implementing method from interface
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " has quit.");

        }
    }
}

