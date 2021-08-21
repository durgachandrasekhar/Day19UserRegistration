using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The User Registration Problem");
            Registration user = new Registration();
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            user.Check(firstName);
        }
    }
}
