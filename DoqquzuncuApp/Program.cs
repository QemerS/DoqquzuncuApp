using System;

namespace DoqquzuncuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# program that takes userId and password as input (type string). 
            After 3 wrong attempts,user will be rejected
             */
            string id = "00000";
            string password = "12345";
            

            for (int x = 3; x>0; x--)
            {
                Console.WriteLine("Enter you id:"); string userId = Console.ReadLine();
                Console.WriteLine("Enter your password"); string userPassword = Console.ReadLine();
                if (id != userId && password != userPassword)
                {
                    Console.WriteLine("Wrong");
                }
                else
                {
                    Console.WriteLine("Welcome");
                    break;
                }
            }

        }
    }
}
