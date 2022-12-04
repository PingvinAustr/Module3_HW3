using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW3
{
    public class Class2
    {
        private static int _powResult;
        public static ResultHandler Calc(PowHandler handler, int a, int b)
        {
            ResultHandler result = Result;

            if (handler != null)
            {
                _powResult = handler.Invoke(a, b);
            }

            return result;
        }

        public static bool Result(int number)
        {
            int remainder = _powResult % number;
            if (remainder == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
