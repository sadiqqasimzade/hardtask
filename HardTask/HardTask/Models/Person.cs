using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    class Person
    {
        public string  Name { get; set; }
        public string Number { get; set; }
        public double Balnce { get; set; } //balans artirmaq

        public PhoneBook contacts;

        public CallHistory callHistory;
        public Person(string name , string number)
        {
            Name = name;
            Number = number;
            contacts = new PhoneBook();
            callHistory = new CallHistory();
        }


    }
}
