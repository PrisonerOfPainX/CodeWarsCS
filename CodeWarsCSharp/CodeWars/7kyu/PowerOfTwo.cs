using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp.CodeWars._7kyu {
    class _PowerOfTwo {
        public static bool PowerOfTwo( int v ) => v == 0 ? false : (bool)((v & (v - 1)) == 0);
    }
}
