using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWarsCSharp.CodeWars._6kyu {
    public class L33TGreekCase {

      static Dictionary<char, char> leetGreek = new Dictionary<char, char>() {
          { 'a' , 'α' }, { 'b' , 'β' },
          { 'd',  'δ' }, { 'e' , 'ε' },
          { 'i',  'ι' }, { 'k',  'κ' },
          { 'n',  'η' }, { 'o',  'θ' },
          { 'p',  'ρ' }, { 'r',  'π' },
          { 't',  'τ' }, { 'u',  'μ' },
          { 'v',  'υ' }, { 'w',  'ω' },
          { 'x',  'χ' }, { 'y',  'γ' },
   };
        public static string Converter( string str ) {
            string output = String.Empty;

            foreach (var item in str.ToLower()) {

                if (leetGreek.ContainsKey(item)) {
                    output += leetGreek[item];
                }
                else {
                    leetGreek.Add(item, item);
                    output += leetGreek[item];
                }
            }
            return output;
        }
        public static string GreekL33t( string str ) {
            return Converter(str);
        }

    }
}
