using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            var age = Console.ReadLine();

            Console.WriteLine(name + ",Welcome to C#, your age is: " + age + ".");
            Console.WriteLine("{0},Welcome to C#, your age is: {1}.", name, age);   
        }
    }
}
