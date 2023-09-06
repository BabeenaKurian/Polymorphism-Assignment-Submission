using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable NewEmployee = new employee();

            ((employee)NewEmployee).firstName = "Kitty";
            ((employee)NewEmployee).lastName = "Katz";

            NewEmployee.Quit(NewEmployee); // 
        }
    }
}
