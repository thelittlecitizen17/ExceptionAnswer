using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionQuestion
{
    public class IScubaException : Exception
    {
        public IScubaException(string message):base(message+"!\nThe user name is:"+ Environment.UserName)
        {

        }
    }
}
