using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp.CodeWars._6kyu {
    class Kata {
        public static int[] ArrayDiff(int[] a, int[] b) {
            HashSet<int> c = new HashSet<int>(b);

            return a.Where(x => !c.Contains(x)).ToArray();
        }
    }
}
