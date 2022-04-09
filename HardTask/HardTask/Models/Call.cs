using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HardTask.Models
{
    static class Call
    {
        public static async void CallNumber(this Person caller, Person destination)//contact //destination number
        {
            if (caller.CheckBalance())
            {
                if (destination.Number.NumberIsInContacts(caller.contacts.GetContacts())) 
                {
                    if (destination.isAvailabe)
                    {
                        caller.isAvailabe = false;
                        destination.isAvailabe = false;
                        DateTime start = DateTime.Now;

                        Task decreaseBalance = new Task(() =>DecreaseBalance(caller));
                        Task waitingKey = new Task(() => WaitingKey());

                        waitingKey.Start();
                        decreaseBalance.Start();
                        Task.WhenAny(waitingKey,decreaseBalance).Wait();

                        //decreaseBalance.Dispose();
                        //waitingKey.Dispose();

                        DateTime end = DateTime.Now;
                        TimeSpan total=end.Subtract(start);
                        caller.isAvailabe = true;
                        destination.isAvailabe = true;
                        Console.WriteLine($"Call Ended,Call Length  {total.Hours} Hours,{total.Minutes} Minutes,{total.Seconds} Seconds");
                    }
                }
            }
        }



        static void Wait() //await mesqul olanda
        {
            Thread.Sleep(10000);
        }

        static async Task DecreaseBalance(Person caller)//threading ile acamq
        {
            while (true)
            {
                Console.WriteLine("Balance:"+caller.Balance);
                Thread.Sleep(10000);
                caller.Balance -= 0.03;
                if (caller.Balance < 0.03) return;
            }
        }

        static async Task  WaitingKey()
        {
            while (Console.ReadKey().Key!=ConsoleKey.Enter)
            { 
            Console.Clear();
            }
            return;
        }

        static bool CheckBalance(this Person caller)
        {
            if (caller.Balance > 0.03) return true;
            return false;
        }

        static public bool NumberIsInContacts(this string number, SortedDictionary<string, string> contacts)
        {
            if (contacts.ContainsValue(number)) return true;  
            return false;
        }
    }
}
