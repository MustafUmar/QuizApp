using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public static class StringExtensions
    {
        public static string ToFirstCharUpper(this string input)
        {
            switch(input.Trim())
            {
                case null: return "";
                case "": return "";
                default: return input.First().ToString().ToUpper() + input.Substring(1).ToLower();
            }
        }
    }
}
