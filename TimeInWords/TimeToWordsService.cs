using System.Collections.Generic;

namespace TimeInWords
{
    public class TimeToWordsService
    {
        private static readonly string OCLOCK = " o' clock";
        private static readonly string MINUTES = " minutes";
        private static readonly string MINUTE = " minute";
        private static readonly string TO = " to ";
        private static readonly string PAST = " past ";

        private static readonly Dictionary<int, string> Clocks = new Dictionary<int, string>
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "quarter"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "half"}
        };

        public string ConvertTime(int h, int m)
        {
            //YOU HAVE TO IMPLEMENT THIS FUNCTION AT THE DOJO!
            return "";
        }
    }
}