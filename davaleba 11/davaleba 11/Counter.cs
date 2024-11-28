using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_11
{
    internal class Counter
    {
        private static int Count = 0;
        public Counter()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }

        public static void ResetCount()
        {
            Count = 0;
        }
    }
}
