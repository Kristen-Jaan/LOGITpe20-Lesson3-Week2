using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What's Your Name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            Console.WriteLine("How Old Are You?");
            string Userinput;
            Userinput = Console.ReadLine();
            int Age;
            //parsing string to interger (number)
            Age = Int32.Parse(Userinput);
            int YearOfBirth = 2020 - Age;
            Console.WriteLine("You were born in" + YearOfBirth);


        }
    }
}
