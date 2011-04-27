using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        Dictionary<int, string> _lookup = new Dictionary<int, string>
                                              {
                                                  {1000, "M"}, 
                                                  {900, "CM"}, 
                                                  {500, "D"}, 
                                                  {400, "CD"}, 
                                                  {100, "C"}, 
                                                  {90, "XC"}, 
                                                  {50, "L"}, 
                                                  {40, "IL"},
                                                  {10, "X"},
                                                  {9, "IX"},
                                                  {5, "V"},
                                                  {4, "IV"},
                                                  {1, "I"},
                                              };

        public string NumberToRoman(int number)
        {
            if (number > 3999) throw new ArgumentOutOfRangeException();
            string roman = "";
            int myNumber = number;
            foreach (var item in _lookup)
            {
                while (myNumber >= item.Key)
                {
                    roman += item.Value;
                    myNumber -= item.Key;
                }
            }
            return roman;
         
        }
    }
}
