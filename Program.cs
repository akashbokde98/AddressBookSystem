using System;
using System.Collections.Generic;

namespace AddressBookSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program.");

            AddressBook contact = new AddressBook();

            Console.WriteLine("Enter 'ADD' To Add Contact-\nEnter 'EXIT' To Exit Address Book-");
            string input = Console.ReadLine().ToUpper();
            switch(input)
            {
                case "ADD":
                    contact.AddPerson();
                    break;

                case "EXIT":
                    break;
            }
            
        }
    }
}
