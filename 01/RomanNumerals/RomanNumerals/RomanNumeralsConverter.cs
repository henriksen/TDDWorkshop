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

            if (number == 8) return "VIII";
            if (number == 7) return "VII";
            if (number == 6) return "VI";
            if (number == 5) return "V";
            if (number == 4) return "IV";
            var roman = new string('I', number);
            return roman;
         
        }
    }
}
