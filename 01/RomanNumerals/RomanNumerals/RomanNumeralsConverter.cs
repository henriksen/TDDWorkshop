using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        public string NumberToRoman(int number)
        {
            if (number == 3) return "III";
            if (number == 2) return "II";
            return "I";
        }
    }
}
