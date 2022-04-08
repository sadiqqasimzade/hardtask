using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    internal class CallHistory
    {
        //dateTimelari string kimi oturmek olar tolongstring
        List<callHistory> callHistorys = new List<callHistory>();
        struct callHistory
        {
            double talkingTimeTotal;
            DateTime talkingTimeStart ;
            DateTime talkingTimeEnd;
        }

        public void AddFinishedCall (double totaltime,DateTime start,DateTime end)
        {
            callHistory callHistory = new callHistory { }; 
           
        }
    }
}
