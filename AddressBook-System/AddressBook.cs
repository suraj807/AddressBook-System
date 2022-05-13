﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    internal class AddressBook
    {
        List<PersonInput> addressbook = new List<PersonInput>(); // Creating List having PersonInput Class Object Datatype
        public void AddRecords()
        {
            PersonInput input = new PersonInput();

           
            Console.WriteLine("Enter your First Name : ");
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

            //Console.WriteLine("\nyour name :"+firstName + middleName + lastName+ "\nyour address :"+address+"\n your city :"+city+"\nyour state :"+state+"\nyour phone number :"+phoneNumber+"\nyour emailid :"+email) ;
            //Console.ReadLine();
        }
        public void PrintRecords() // Creating a class method to just display all the records of list
        {
           int i = 1;
            foreach (var record in addressbook) // Accessing all the records of list one by one using foreach loop
            {
                Console.WriteLine("\n\nRecord - " + i);
                Console.WriteLine("First Name : " + record.fName);
                Console.WriteLine("Last Name : " + record.lName);
                Console.WriteLine("Address : " + record.address);
                Console.WriteLine("City : " + record.city);
                Console.WriteLine("State : " + record.state);
                Console.WriteLine("Email : " + record.email);
                Console.WriteLine("Zip code : " + record.zip);
                Console.WriteLine("Phone Number : " + record.phoneNumber);
               // i++;
            }



        }
    }
}
