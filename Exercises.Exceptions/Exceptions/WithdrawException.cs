using System;

namespace Exercises.Exception.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }
}
