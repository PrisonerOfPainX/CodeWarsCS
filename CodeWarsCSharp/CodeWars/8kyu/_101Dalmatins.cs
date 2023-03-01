using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Dalmatins
    {
        public static string HowManyDalmatians(int number)
        {
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };

            return number <= 10 ? dogs[0] : number <= 50 ? dogs[1] : number == 101 ? dogs[3] : dogs[2];
        }
    }
}
