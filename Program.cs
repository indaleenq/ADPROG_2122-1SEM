using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please type your name: ");
            //string name; // variable declaration
            string name = Console.ReadLine(); // variable initialization
            Console.WriteLine($"Welcome {name}");

            Console.Write("Now, please enter your age: ");
            //string age = Console.ReadLine();
            //int ageNumber = Convert.ToInt32(age);
            var age = Convert.ToInt32(Console.ReadLine());

            var newAge = age - 2;
            Console.WriteLine($"your new age is {newAge}");
        }
    }
}