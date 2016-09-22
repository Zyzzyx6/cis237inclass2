using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 for factorial or 2 for Towers of Hanoi");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {//Do Factorial
                //The Dawn way
                Factorial factorial = new Factorial();
            }
            else
            {
                //Do Towers of Hanoi
                //The Dawn Way Again!!!
                TowersOfHanoi tower = new TowersOfHanoi();

            }

        }
    }
}
