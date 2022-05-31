﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{

    internal class AddressBook
    {

        List<string> addressBookName = new List<string>(); // Creating a list to maintain address book name
        Dictionary<string, List<PersonInput>> dict = new Dictionary<string, List<PersonInput>>(); // Creating dictionary to Maintain all the address book 
        public void CreateAddressBook(string n) // class method to create new address book and store it in dictionary
        {
            addressBookName.Add(n); // Add address book name which is provided by user  in address book list

            if (dict.Count == 0) // Checking that dictionary is empty or not
            {
                dict.Add(n, new List<PersonInput>()); // // creating key value pair where address book name is key and all the redord of address book as value
            }
            else
            {
                if (dict.ContainsKey(n)) // Checking that address book given by user is already present in dictionary or not
                {
                    Console.WriteLine("This AddressBook is also present");
                }
                else
                {
                    dict.Add(n, new List<PersonInput>()); // creating key value pair where address book name is key and all the redord of address book as value
                }

            }
        }
        public int temp = 0;
        public void DiplayListOfAddressBook() // Class method to display name Address book
        {
            if (addressBookName.Count == 0) // Checking that address book list is empty or not
            {
                Console.WriteLine("\nThere is no address book avilable");
                temp = 1;
            }
            else
            {
                foreach (string list in addressBookName) // Accessing all the names in address book
                {
                    Console.WriteLine("\n\nList of existing Address Book Are : ");
                    Console.WriteLine(list);
                    Console.WriteLine();
                }
            }
        }
        public void DisplayDictionary() // Class method to display all the records of all address book
        {
            foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
            {
                Console.WriteLine("\n\nAddress Book : " + content);
                int i = 1;
                foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                {
                    Console.WriteLine("\nRecord - " + i);
                    Console.WriteLine("First Name : " + value.fName);
                    Console.WriteLine("Last Name : " + value.lName);
                    Console.WriteLine("Address : " + value.address);
                    Console.WriteLine("City : " + value.city);
                    Console.WriteLine("State : " + value.state);
                    Console.WriteLine("Email : " + value.email);
                    Console.WriteLine("Zip code : " + value.zip);
                    Console.WriteLine("Phone Number : " + value.phoneNumber);
                    i++;
                }
            }
        }
        public void AddRecords(string name) // Creating class method to add Person Record in List
        {
            PersonInput input = new PersonInput(); // Creating a object of PersonInput Class
            // Getting all the details from user and store it in PersonInput Class variales through object                                              
            Console.WriteLine("\nEnter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();
            foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
            {
                if (content == name) // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    if (dict[content].Count == 0)
                    {
                        dict[name].Add(input);// Adding person record in Address book 
                        Console.WriteLine("\nRecord Added successfully in Address Book");
                    }
                    else
                    {
                        foreach (var value in dict[content].ToList()) // Accessing all the record of address book by dictionary key
                        {
                            if (value.phoneNumber != input.phoneNumber) // Checking that phone number provided by user is matching with Existing Reord or not
                            {
                                dict[name].Add(input);// Adding person record in Address book 
                                Console.WriteLine("\nRecord Added successfully in Address Book");
                            }
                            else
                            {
                                Console.WriteLine($"\nThis Record is already present in {content} Address Book");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\n{content} Address Book not found");
                }

            }

        }
        string fn, ln;
        public void UpdateRecords(string ab) // Creating class method to update record which takes first name and last name as parameter
        {
            foreach (var content in dict.Keys)  // Accessing all the record of address book by dictionary key
            {
                if (content == ab) // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine(); // Store the user lastname in variable
                    foreach (var value in dict[content].ToList())
                    {
                        if (value.fName == fn && value.lName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\n\nWhich field you want to update : ");
                            Console.WriteLine("\n1:First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n7.Zip Code\n8.PhoneNumber\n9.Exit");
                            Console.WriteLine("\nEnter your Choice : ");
                            int ch = Convert.ToInt32(Console.ReadLine()); // Store the user choice which want to update 
                            switch (ch)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter new first name : ");
                                    string f = Console.ReadLine();
                                    value.fName = f; // Update the first name of record in address book
                                    Console.WriteLine("\nFirst Name Updated Successfully");
                                    break;
                                case 2:
                                    Console.WriteLine("\nEnter new last name : ");
                                    string l = Console.ReadLine();
                                    value.lName = l;  // Update the last name of record in address book
                                    Console.WriteLine("\nLast Name Updated Successfully");
                                    break;
                                case 3:
                                    Console.WriteLine("\nEnter new address : ");
                                    string a = Console.ReadLine();
                                    value.address = a; // Update the address of record in address book
                                    Console.WriteLine("\nAddress Updated Successfully");
                                    break;
                                case 4:
                                    Console.WriteLine("\nEnter new city name : ");
                                    string c = Console.ReadLine();
                                    value.city = c; // Update the city name of record in address book
                                    Console.WriteLine("\nCity Name Updated Successfully");
                                    break;
                                case 5:
                                    Console.WriteLine("\nEnter new state : ");
                                    string s = Console.ReadLine();
                                    value.state = s; // Update the state name of record in address book
                                    Console.WriteLine("\nState Name Updated Successfully");
                                    break;
                                case 6:
                                    Console.WriteLine("\nEnter new email : ");
                                    string e = Console.ReadLine();
                                    value.email = e; // Update the email name of record in address book
                                    Console.WriteLine("\nEmail Updated Successfully");
                                    break;
                                case 7:
                                    Console.WriteLine("\nEnter new Zip Code : ");
                                    int z = Convert.ToInt32(Console.ReadLine());
                                    value.zip = z; // Update the zipcode of record in address book
                                    Console.WriteLine("\nZip Code Updated Successfully");
                                    break;
                                case 8:
                                    Console.WriteLine("\nEnter new Phone Number : ");
                                    int p = Convert.ToInt32(Console.ReadLine());
                                    value.phoneNumber = p; // Update the phone number of record in address book
                                    Console.WriteLine("\nPhone Number Updated Successfully");
                                    break;
                                default:
                                    Console.WriteLine("\nEnter valid choice");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
        public void DeleteRecord(string ab)  // Creating class method to delete record which takes first name as parameter
        {
            foreach (var content in dict.Keys) // Accessing address book name by dictionary key
            {
                if (content == ab)  // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();
                    foreach (var value in dict[content].ToList())  // Accessing all the record of address book by dictionary key
                    {
                        if (value.fName == fn && value.lName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\nEnter your first name which you want to delete : ");
                            string f = Console.ReadLine(); // Store the user firstname in variable
                            dict[content].Remove(value); // Deleting all the details of one user in Address Book
                            Console.WriteLine("\nRecord Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
    }
}
