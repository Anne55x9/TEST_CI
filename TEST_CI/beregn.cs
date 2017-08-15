using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_CI
{
    public static class Beregn
    {

        public static bool ErNulOgMindre(int a)
        {
            if (a <= 0)
                return true;
            else
                return false;
        }

        public static bool ErNul(int a)
        {
            return true;
        }

        public static bool ErIkkeNul(int a)
        {
            return false;
        }


    }
}
