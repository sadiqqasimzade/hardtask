using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.CustomException
{
    internal class NumberLengthException:Exception
    {
        public NumberLengthException(string message):base(message)
        {

        }
    }
}
