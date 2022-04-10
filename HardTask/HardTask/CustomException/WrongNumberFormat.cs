using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.CustomException
{
    internal class WrongNumberFormat:Exception
    {
        public WrongNumberFormat(string message):base(message)
        {

        }
    }
}
