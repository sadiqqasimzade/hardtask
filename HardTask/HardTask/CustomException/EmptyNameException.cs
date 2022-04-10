using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.CustomException
{
    internal class EmptyNameException:Exception
    {
        public EmptyNameException(string message):base(message)
        {

        }
    }
}
