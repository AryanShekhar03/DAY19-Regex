using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Mobile Number ex : +91 8447831498 .");
            Console.Write("\n Enter Mobile Number : ");
            string name = Console.ReadLine();
            Pattern.MobileNumber(name);
        }
    }
}
