using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Wait
    {
        public static void Waiting(int length)
        {
            System.Threading.Thread.Sleep(length);
        }

        public static void RunWaiting(int length)
        {
            Waiting(length);
        }
    }
}
