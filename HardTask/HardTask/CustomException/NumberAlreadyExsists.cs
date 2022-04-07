using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.CustomException
{
    internal class NumberAlreadyExsists:Exception
    {
        public NumberAlreadyExsists(string message):base(message)
        {

        }
    }
}
