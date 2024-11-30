using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutithreadingInner
{
    internal class LengthException:Exception
    {
        private string UserExceptionMessage;
        public LengthException(string errorMessage)
        {
            UserExceptionMessage = errorMessage;
        }
        public void showMessageException()
        {
            Console.WriteLine("UserExceptionMessage : "+UserExceptionMessage);
        }
    }
}
