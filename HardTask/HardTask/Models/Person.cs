using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using HardTask.CustomException;

namespace HardTask.Models
{
    class Person
    {
        private string _name;
        private double _balance;
        public string Name
        {
            get => _name; set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new EmptyNameException("Cant be Empty");
                else _name = value;
            }
        }
        public string Number{ get; set; }
        public double Balance
        {
            get => _balance; set
            {
                if (value >= 0) _balance = value;
                else throw new NegativeException("Cant be negative");
            }
        }
        public bool IsAvailabe { get; set; } = true;
        public MethodInfo Ringtone { get; set; } = typeof(Ringtones).GetMethod("Default");

        public PhoneBook contacts;

        public CallHistory callHistory;

        public Operator phoneOperator;
        public Person()
        {
            contacts = new PhoneBook();
            callHistory = new CallHistory();
            phoneOperator = new Operator("Azarcell", 0.03);
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
