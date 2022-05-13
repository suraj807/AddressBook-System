using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    internal class AddressBookClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome to Address Book System\n");

            //AddressBook createContacts = new AddressBook();
            //createContacts.Addressbook();

            
                Console.WriteLine("Welcome to Address Book System");
                AddressBook records = new AddressBook(); // Creating a object of AddressBook class
                Console.WriteLine("1. Add a new Record");
                 // records.AddRecords();
                Console.WriteLine("Enter your choice : ");
                int ch = Convert.ToInt32(Console.ReadLine()); // Storing a user choice in variable
            
            
                switch (ch)
                {
                    case 1:
                        records.AddRecords(); // Calling a method of AddressBook class to add record in address book
                        records.PrintRecords(); // Calling a method of AddressBook class to display records of address book
                        Console.ReadLine();
                        break;
                }
           

        }
    }
}
