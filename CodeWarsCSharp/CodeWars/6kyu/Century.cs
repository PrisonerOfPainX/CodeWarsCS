using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp.CodeWars._6kyu {
    public class Century {
        public static string Check( ref int detectCentury ) {

            switch (detectCentury % 100) {
                case 11: return "th";
                case 12: return "th";
                case 13: return "th";
                default:
                    switch (detectCentury % 10) {
                        case 1: return "st";
                        case 2: return "nd";
                        case 3: return "rd";
                        default: return "th";
                    }
            }
        }
        public static string WhatCentury( string year ) {
            int century = (((int.Parse(year)) / 100)); // 1999 / 100 => 19
            int detectCentury = ((int.Parse(year) % 100) > 0) ? century + 1 : century;
            return detectCentury.ToString() + Check(ref detectCentury);
        }
    }
}
