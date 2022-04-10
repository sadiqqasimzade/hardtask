using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HardTask.Models
{
    abstract class Call
    {
        public static void CallNumber(Person caller, Person destination)
        {
            if (CheckBalance(caller))
            {
                if (NumberIsInContacts(destination.Number, caller.contacts.GetContacts()))
                {
                    if (destination.isAvailabe)
                    {
                        Wait(destination);

                        caller.isAvailabe = false;
                        destination.isAvailabe = false;
                        double startbalance = caller.Balance;
                        DateTime start = DateTime.Now;


                        Task decreaseBalance = new Task(() => DecreaseBalance(caller));
                        Task waitingKey = new Task(() => WaitingKey(caller));


                        waitingKey.Start();
                        decreaseBalance.Start();
                        Task.WhenAny(waitingKey, decreaseBalance).Wait();


                        DateTime end = DateTime.Now;
                        caller.isAvailabe = true;
                        destination.isAvailabe = true;
                        caller.callHistory.AddFinishedCall(start, end, destination.Name);
                        Console.WriteLine($"Call Ended,Call Length:{end.Subtract(start).ToString(@"hh\:mm\:ss")},Money used:{startbalance - caller.Balance},Money left:{Math.Round(caller.Balance, 3)}");
                    }
                }
            }
        }



        static void Wait(Person destination) 
        {
            Console.WriteLine("Waiting " + destination.Name + " to answer");
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine(destination.Name + " Is on Phone");
        }

        static void DecreaseBalance(Person caller)//threading ile acamq
        {
            while (true)
            {
                caller.Balance -= caller.phoneOperator.Tarif ;
                Thread.Sleep(10000);
                if (caller.Balance < 0.03 || caller.isAvailabe) { caller.isAvailabe = true; return; }
            }
        }

        static void WaitingKey(Person caller)//threadin ile acmaq
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter || caller.isAvailabe)
            {
                Console.Clear();
            }
            caller.isAvailabe = true;
            return;
        }

        static bool CheckBalance(Person caller)
        {
            if (caller.Balance > caller.phoneOperator.Tarif)
                return true;
            return false;
        }

        static public bool NumberIsInContacts(string number, SortedDictionary<string, string> contacts)
        {
            if (contacts.ContainsValue(number))
                return true;
            return false;
        }
    }
}
