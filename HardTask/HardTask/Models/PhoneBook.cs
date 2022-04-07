using System;
using System.Collections.Generic;
using System.Text;
using HardTask.CustomException;

namespace HardTask.Models
{
    class PhoneBook  
    {
        SortedDictionary<string, string> contacts = new SortedDictionary<string, string>();
        public void ShowContacts()
        {
            foreach (var number in contacts)
                Console.WriteLine(number.Value);
        }

        public void AddContact(string fullname, string number) //Sorted list avtomatik Key-gore sort olur.
        {                                                      //Ad sirasi ile duzsek Key-e fullname vermeliyik o da ust-uste dusur islemir.stuct ile yoxlamaq olar
            if (number.NumberIsInContacts(contacts))throw new NumberAlreadyExsists("Number already exsist");
            contacts.Add(fullname, number);
        }

        public void RemoveContact(string name)
        {
            contacts.Remove(name);
        }

        public SortedDictionary<string,string> GetContacts()
        {
            return contacts;
        }
    }
}
