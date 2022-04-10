using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HardTask.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; } 
        public bool IsAvailabe { get; set; } = true;
        public MethodInfo Ringtone { get; set; } = typeof(Ringtones).GetMethod("Default");

        public PhoneBook contacts;

        public CallHistory callHistory;

        public Operator phoneOperator;
        public Person()
        {
            contacts = new PhoneBook();
            callHistory = new CallHistory();
            phoneOperator = new Operator("Azarcell",0.03);
        }

        public void AddBalance(double addedbalance)
        {
            if (addedbalance > 0)
                Balance += addedbalance;
            else throw new Exception("Cant be Negative");
        }
        public override string ToString()
        {
            return $@"Full Name-{Name}
Number-{Number}";
        }
    }
}
