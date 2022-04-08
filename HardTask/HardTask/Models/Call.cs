using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HardTask.Models
{
    static class Call
    {
        public static string CallNumber(this Person caller, Person destination)//contact //destination number
        {
            if (caller.CheckBalance())
            {
                if (destination.Number.NumberIsInContacts(caller.contacts.GetContacts())) 
                {
                    if (destination.isAvailabe)
                        return "zeng getdi";
                }
            }
            return "zeng getmedi";
        }



        static void Wait() //await mesqul olanda
        {
            Thread.Sleep(10000);
        }

        static void temp(Person caller)//threading ile acamq
        {
            while (true)
            {
                if (caller.Balance < 0.3) throw new Exception("Balans yoxdu");
                caller.Balance -= 0.3;
                Thread.Sleep(10000);
            }
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
