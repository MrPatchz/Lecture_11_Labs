using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool runProgram = true;
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            
            do
            {
                string name = "";
                string phoneNumber = "";
                int choice = 0;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("       Welcome to Phon Book PhoneBook!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Would you like to");
                Console.WriteLine("1) Add phone number");
                Console.WriteLine("2) Delete phone number");
                Console.WriteLine("3) Find Phone number");
                Console.WriteLine("3) Exit");
                Console.Write("Please enter the number: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        phoneNumber = Console.ReadLine();
                        phoneBook.Add(name, phoneNumber);
                        break;
                    case 2:
                        Console.Write("Enter name to be removed: ");
                        name = Console.ReadLine();
                        if (phoneBook.ContainsKey(name))
                        {
                            phoneBook.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine("Name not found!");
                        }
                        
                        break;
                    case 3:
                        Console.Write("Enter name to get number: ");
                        name = Console.ReadLine();
                        if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine(phoneBook.GetValueOrDefault(name));
                        }
                        else
                        {
                            Console.WriteLine("Name not found!");
                        }
                        break;
                    case 4:
                        runProgram = false;
                        Console.WriteLine("Exiting Program");
                        break;
                    default:
                        Console.WriteLine("Unrecognized command");
                        break;
                }
                Console.WriteLine();

            } while (runProgram);
        }
    }
}
