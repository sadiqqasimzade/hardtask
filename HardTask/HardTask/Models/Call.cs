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
                    if (CallingYourself(caller, destination))
                    {
                        if (destination.IsAvailabe)
                        {
                            caller.Ringtone.Invoke(null, null);
                            Wait(destination);

                            caller.IsAvailabe = false;
                            destination.IsAvailabe = false;
                            double startbalance = caller.Balance;
                            DateTime start = DateTime.Now;

                            double tarif = caller.phoneOperator.Tarif;
                            if (!caller.phoneOperator.OperatorName.Equals(destination.phoneOperator.OperatorName)) tarif *= 2;

                            Task decreaseBalance = new Task(() => DecreaseBalance(caller, tarif));
                            Task waitingKey = new Task(() => WaitingKey(caller));

                            waitingKey.Start();
                            decreaseBalance.Start();
                            Task.WhenAny(waitingKey, decreaseBalance).Wait();

                            DateTime end = DateTime.Now;
                            caller.IsAvailabe = true;
                            destination.IsAvailabe = true;
                            caller.callHistory.AddFinishedCall(start, end, destination.Name);
                            Console.WriteLine($"Call Ended,Call Length:{end.Subtract(start):hh\\:mm\\:ss},Money used:{startbalance - caller.Balance},Money left:{Math.Round(caller.Balance, 3)}");
                        }
                    }
                }
            }
        }



        static void Wait(Person destination)
        {
            Console.WriteLine("Waiting " + destination.Name + " to answer");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(destination.Name + " Is on Phone");
        }

        static void DecreaseBalance(Person caller, double tarif)//threading ile acamq
        {
            while (true)
            {
                caller.Balance -= tarif;
                Thread.Sleep(10000);
                if (caller.Balance < tarif || caller.IsAvailabe) { caller.IsAvailabe = true; return; }
            }
        }


        static void WaitingKey(Person caller)//threadin ile acmaq
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter || caller.IsAvailabe)
            {
                Console.Clear();
            }
            caller.IsAvailabe = true;
            return;
        }
        static bool CallingYourself(Person caller, Person destination)
        {
            if (!caller.Number.Equals(destination.Number)) return true;
            else return false;
        }

        static bool CheckBalance(Person caller)
        {
            if (caller.Balance > caller.phoneOperator.Tarif*2)
                return true;
            else
            {
                Console.WriteLine("You dont have enough money");
                return false;
            }
        }

        static public bool NumberIsInContacts(string number, SortedDictionary<string, string> contacts)
        {
            if (contacts.ContainsValue(number))
                return true;
            return false;
        }
    }
}
