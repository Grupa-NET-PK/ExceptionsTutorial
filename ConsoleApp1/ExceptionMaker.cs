using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExceptionMaker
    {
        public static void ThrowException()
        {
            throw new ApplicationException("Randomowy wyjątek.");
        }
    }
}
