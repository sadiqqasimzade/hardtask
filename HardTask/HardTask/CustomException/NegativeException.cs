using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.CustomException
{
    internal class NegativeException:Exception
    {
        public NegativeException(string message):base(message)
        {

        }
    }
}
