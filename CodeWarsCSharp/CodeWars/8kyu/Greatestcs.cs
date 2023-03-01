using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    static class Greatestcs
    {
        public static string Maior(this int primeiroValor, int segundoValor)
            => primeiroValor > segundoValor ? $"{primeiroValor} é maior" : primeiroValor == segundoValor ? "Nenhum é maior" : $"{segundoValor} é maior";
    }
}
