using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class UefaEuro
    {
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            
            return $"At match {teams[0]} - {teams[1]}, {(scores[0] == scores[1] ? "teams played draw." : teams[scores[0] > scores[1] ? 0 : 1] + " won!")}";
        }
    }
}
