using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    internal class CreateContacts
    {
        public void Addressbook()
        {
            string firstName, middleName, lastName, address, city, state, email;
            int zip;
            long phoneNumber;
            Console.WriteLine("Enter your First Name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Middle Name");
            middleName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            email = Console.ReadLine();

            Console.WriteLine("\nyour name :"+firstName + middleName + lastName+ "\nyour address :"+address+"\n your city :"+city+"\nyour state :"+state+"\nyour phone number :"+phoneNumber+"\nyour emailid :"+email) ;
            Console.ReadLine();
        }
        
    }
}
