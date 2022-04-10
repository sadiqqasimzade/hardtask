using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    internal class CallHistory
    {
        //dateTimelari string kimi oturmek olar tolongstring
        List<ScallHistory> callHistorys = new List<ScallHistory>();
        struct ScallHistory //1)liste rahat yigilir 2)instance lazim deyil 3)rahat deyismek olar
        {
            public string destinationName;
            public DateTime talkingTimeStart;
            public DateTime talkingTimeEnd;
            public string total;
        }
        
        public void AddFinishedCall(DateTime start, DateTime end, string destinationname)
        {
            callHistorys.Add(new ScallHistory { talkingTimeStart = start, talkingTimeEnd = end, total = end.Subtract(start).ToString(@"hh\:mm\:ss"), destinationName = destinationname });
        }

        public void ClearHistory()
        {
            Console.WriteLine(callHistorys.Count + ":Calls deleted");
            callHistorys.Clear();
        }

        public void ShowHistory() 
        {
            callHistorys.ForEach((x) =>
            {
                foreach (var field in x.GetType().GetFields())
                    Console.WriteLine(field.GetValue(x));
                Console.WriteLine("-------------------");
            }
            );
        }
    }
}
