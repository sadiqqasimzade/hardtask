using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; } //balans artirmaq
        public bool isAvailabe { get; set; } = true;


        public PhoneBook contacts;

        public CallHistory callHistory;
        public Person(string name, string number)
        {
            Name = name;
            Number = number;
            contacts = new PhoneBook();
            callHistory = new CallHistory();
        }

        public void AddBalance(double addedbalance)
        {
            if (addedbalance > 0)
                Balance += addedbalance;
            else throw new Exception("Cant be Negative");
        }
    }
}
