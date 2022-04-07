using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    class Person
    {
        public string  FullName { get; set; }
        public string Number { get; set; }
        public double Balnce { get; set; } //balans artirmaq

        public PhoneBook contacts;
        public Person(string fullName , string number)
        {
            FullName = fullName;
            Number = number;
            contacts = new PhoneBook();
        }


    }
}
