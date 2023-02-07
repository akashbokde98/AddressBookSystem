using System;
using System.Collections.Generic;
using System.Text;

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
            //people.Add(person);

            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine().ToUpper();
            //people.Add(person);

            Console.WriteLine("Enter Address: ");
            person.Address = Console.ReadLine().ToUpper();
            //people.Add(person);

            Console.WriteLine("Enter City: ");
            person.City = Console.ReadLine().ToUpper();
            //people.Add(person);

            Console.WriteLine("Enter State: ");
            person.State = Console.ReadLine().ToUpper();
            //people.Add(person);

            Console.WriteLine("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            //people.Add(person);

            Console.WriteLine("Enter E-mail: ");
            person.Email = Console.ReadLine().ToUpper();
            //people.Add(person);

            Console.WriteLine("Enter Zip Code: ");
            person.ZipCode = Console.ReadLine();

            ContactList.Add(person);
            Console.WriteLine("Added Successfully!");
        }
    }
}
