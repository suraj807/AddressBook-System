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
            Console.WriteLine("welcome to Address Book System\n");

            CreateContacts createContacts = new CreateContacts();
            createContacts.Addressbook();
        }
    }
}
