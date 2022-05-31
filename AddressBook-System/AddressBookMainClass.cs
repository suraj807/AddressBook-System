﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    namespace AddressBookSystem
    {
        internal class AddressBookMainClass
        {
            static void Main(string[] args)
            {
                AddressBook records = new AddressBook(); // Creating a object of AddressBook class
                string ab;
            Again:
                while (true)
                {
                    Console.WriteLine("\n\nWelcome to Address Book System");
                    Console.WriteLine("1. Add a new Record");
                    Console.WriteLine("2. Update a Record");
                    Console.WriteLine("3. Delete a Record");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("\nEnter your choice : ");

                    int ch = Convert.ToInt32(Console.ReadLine());// Storing a user choice in variable
                    switch (ch)
                    {
                        case 1:
                            string n;
                            Console.WriteLine("\nDo you want to add records in new Address Book ? If yes then press 1 : ");
                            string c = Console.ReadLine(); // Storing a user choice in variable
                            if (c == "1")
                            {
                                Console.WriteLine("\nEnter name of address book which you want to create : ");
                                n = Console.ReadLine(); // Storing a address book name which is provided by user
                                records.CreateAddressBook(n); // Calling a method to Create a new Address Book 
                                records.AddRecords(n); // Calling a method of AddressBook class to add a new record to Address Book
                                records.DisplayDictionary(); // Displaying all records of All Address book

                            }
                            else
                            {
                                records.DiplayListOfAddressBook();// Displaying existing address book name
                                if (records.temp == 1) //Checking that address book is empty or not
                                {
                                    Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                                    goto Again;
                                }
                                else
                                {
                                    Console.WriteLine("\nSelect any one address book from above list : ");
                                    ab = Console.ReadLine(); // Storing a address book name which is provided by user
                                    records.AddRecords(ab); // Calling a method of AddressBook class to add a new record to Address Book
                                    records.DisplayDictionary(); // Displaying all records of All Address book
                                }
                            }
                            break;
                        case 2:
                            records.DiplayListOfAddressBook();// Displaying existing address book name
                            if (records.temp == 1)//Checking that address book is empty or not
                            {
                                Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                                goto Again;
                            }
                            else
                            {
                                Console.WriteLine("\nSelect any one address book from above list : ");
                                ab = Console.ReadLine();// Storing a address book name which is provided by user
                                records.UpdateRecords(ab); // Calling a method of AddressBook class to update record to Address Book
                                records.DisplayDictionary(); // Displaying all records of All Address book
                            }
                            break;
                        case 3:
                            records.DiplayListOfAddressBook(); // Displaying existing address book name
                            if (records.temp == 1) //Checking that address book is empty or not
                            {
                                Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                                goto Again;
                            }
                            else
                            {
                                Console.WriteLine("\nSelect any one address book from above list : ");
                                ab = Console.ReadLine(); // Storing a address book name which is provided by user                  
                                records.DeleteRecord(ab);// Calling a method of AddressBook class to delete record of address book
                                records.DisplayDictionary(); // Displaying all records of All Address book
                            }
                            break;
                        case 4:
                            System.Environment.Exit(0); // Exit
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
