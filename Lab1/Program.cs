/// Lab No. 11 Exercise No.1
/// File Name:     Lab11.cs
/// @author:       Jacques Zwielich
/// Date:          Nov. 15, 2020
///
/// Problem Statement: Create  phone lookup program
///    
/// Overall Plan:
/// 1. Create a dictionary
/// 2. Print a menu giving 4 choices
/// 3. Take user input 
/// 4. compare that user input to the 4 choices 
/// 5. if its input 1 we get the name and number and add it to the dictionary
/// 6. if its input 2 we look for the number and remove it if it exists
/// 7. if its input 3 we print the number associated with the entered name, if it exists
/// 8. if its 4 we exit the program
///

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
