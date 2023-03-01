using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp.CodeWars._6kyu {
    class BigNumber {
        public static bool Narcissistic( int value ) {

            int[] intArray = value.ToString().Select(x => (int)x - 48).ToArray();
            double[] N = new double[intArray.Length];
            for (int i = 0; i < intArray.Length; i++) {
                N[i] = Pow(intArray[i], intArray.Length);
            }

            return (N.Sum() == value) ? true : false;
        }
    }
}
