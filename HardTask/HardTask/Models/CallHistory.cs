using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    internal class CallHistory
    {
        double talkingTimeTotal;
        DateTime talkingTimeStart = new DateTime();
        DateTime talkingTimeEnd = new DateTime();


        SortedDictionary<string, object> callHistory = new SortedDictionary<string, object>();
    }
}
