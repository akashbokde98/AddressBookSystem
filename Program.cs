﻿using System;
using System.Collections.Generic;

namespace AddressBookSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program.");

            AddressBook contact = new AddressBook();

            string input = "";
            while (input != "EXIT")
            {
                Console.WriteLine("Enter 'ADD' To Add New Contact-\nEnter 'EDIT' To Edit Contact-\nEnter 'EXIT' To Exit Address Book-");
                input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "ADD":
                        contact.AddPerson();
                        break;

                    case "EDIT":
                        contact.EditPerson();
                        break;

                    case "EXIT":
                        break;
                }
            }
            
        }
    }
}
