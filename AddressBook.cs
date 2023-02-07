using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AddressBookSystem2
{
    internal class AddressBook
    {
        public List<Person> ContactList = new List<Person>();
        public void AddPerson()
        {
            Person person = new Person();

            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter Address: ");
            person.Address = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter City: ");
            person.City = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter State: ");
            person.State = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
 
            Console.WriteLine("Enter E-mail: ");
            person.Email = Console.ReadLine().ToUpper();
 
            Console.WriteLine("Enter Zip Code: ");
            person.ZipCode = Console.ReadLine();

            ContactList.Add(person);
            Console.WriteLine("Added Successfully!");
        }
        public void EditPerson()
        {
            Person person = new Person();

            Console.WriteLine("Enter First Name Of Person Which You Want To Edit- ");
            string fname = Console.ReadLine().ToUpper();
            foreach (Person p in ContactList)
            {
                if (fname.Equals(p.FirstName))
                {
                    Console.WriteLine("Enter 'N' to Edit Name-\nEnter 'A' to Edit Address-\nEnter 'C' to Edit City-\nEnter 'S' to Edit State-\nEnter 'P' to Edit Phone Number-\nEnter 'E' to Edit Email-\nEnter 'Z' to Edit Zip Code-");
                    char input = char.Parse(Console.ReadLine().ToUpper());

                    if (input.Equals('N') && fname.Equals(p.FirstName))
                    {
                        Console.WriteLine("Enter New First Name-");
                        p.FirstName = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }
                    else if (input.Equals('A') && fname.Equals(p.Address))
                    {
                        Console.WriteLine("Enter New Address-");
                        p.Address = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }
                    else if (input.Equals('C') && fname.Equals(p.City))
                    {
                        Console.WriteLine("Enter New City-");
                        p.City = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }
                    else if (input.Equals('S') && fname.Equals(p.State))
                    {
                        Console.WriteLine("Enter New State-");
                        p.State = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }
                    else if (input.Equals('E') && fname.Equals(p.Email))
                    {
                        Console.WriteLine("Enter New Email-");
                        p.Email = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }
                    else if (input.Equals('P') && fname.Equals(p.PhoneNumber))
                    {
                        Console.WriteLine("Enter New Phone Number-");
                        p.PhoneNumber = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }
                    else if (input.Equals('Z') && fname.Equals(p.ZipCode))
                    { 
                        Console.WriteLine("Enter New Zip Code-");
                        p.ZipCode = Console.ReadLine().ToUpper();
                        ContactList.Add(person);
                        Console.WriteLine("Edited Successfully!");
                        break;
                    }

                }
            }
            Console.WriteLine("Person Not Found!");
        }
        public void DeletePerson()
        {
            Console.WriteLine("Enter First Name- ");
            string input = Console.ReadLine().ToUpper();

            foreach(Person p in ContactList)
            {
                if (input.Equals(p.FirstName))
                {
                    ContactList.Remove(p);
                    Console.WriteLine("Deleted Successfully!");
                    return;
                }
            }
            Console.WriteLine("Person Not Found!");
        }
    }
}
