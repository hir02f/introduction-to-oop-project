using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public class Calculate
    {
        string[] romanNumerals1to10 = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public string[] validRomanNumbers()
        {
            return romanNumerals1to10;
        }

        public int getNumber(string Input)
        {
           // string[] romanNumerals1to10 = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

            return Array.IndexOf(romanNumerals1to10, Input) + 1;
        }
    }
}
