using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HardTask.Models
{
    static class Call
    {
        public static void CallNumber(this Person caller, Person destination)//contact //destination number
        {
            if (caller.CheckBalance())
                if (destination.Number.NumberIsInContacts(caller.contacts.GetContacts())) Console.WriteLine();

        }



        static void Wait() //await mesqul olanda
        {
            Thread.Sleep(10000);
        }

        static void temp(Person caller)//threading ile acamq
        {
            while (true)
            {
                if (caller.Balnce < 0.3) throw new Exception("Balans yoxdu");
                caller.Balnce -= 0.3;
                Thread.Sleep(10000);
            }
        }

        //chain pattern

        static bool CheckBalance(this Person caller)
        {
            if (caller.Balnce > 0.3) return true;
            return false;
        }

        static public bool NumberIsInContacts(this string number, SortedDictionary<string, string> contacts)
        {
            if (contacts.ContainsValue(number)) return true;
            return false;
        }
    }
}
