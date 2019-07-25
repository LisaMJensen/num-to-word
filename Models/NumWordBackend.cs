using System;
using System.Collections.Generic;

namespace NumWord
{
    public class Counter
    {
        public static Dictionary<int, string> ones = new Dictionary<int, string>() {
        { 1, "one" },
        { 2, "two" },
        { 3, "three" },
        { 4, "four" },
        { 5, "five" },
        { 6, "six" },
        { 7, "seven" },
        { 8, "eight" },
        { 9, "nine" } };
        public static Dictionary<int, string> teens = new Dictionary<int, string>() {
            { 11, "eleven"},
            { 12, "twelve"},
            { 13, "thirteen"},
            { 14, "fourteen"},
            { 15, "fifteen"},
            { 16, "sixteen"},
            { 17, "seventeen"},
            { 18, "eighteen"},
            { 19, "nineteen"} };
        public static Dictionary<int, string> tens = new Dictionary<int, string>() {
            { 10, "ten" },
            { 20, "twenty"},
            { 30, "thirty"},
            { 40, "fourty"},
            { 50, "fifty" },
            { 60, "sixty" },
            { 70, "seventy"},
            { 80, "eighty"},
            { 90, "ninety"} };

        string Ones()
        {
            string output = ones[num];
            return output;
        }
        string Teens()
        {
            string output = teens[num];
            return output;
        }
        string Tens()
        {
            string output = tens[num];
            return output;
        }

        public static inputCheck()
        {
            if (num > 0 && num < 10)
            {
                Ones(num);
            }
            else if (num > 10 && num < 20)
            {
                Teens(num);
            }
            else if (num == 10 || num > 19 && num < 100)
            {
                int remainder = num % 10; // 32 gives 2
                int tendig = num / 10; // 32 gives 3
                Tens(tendig);
                Ones(remainder);
            }
            else if (num > 99)
            {
                int remainder = num % 100;
                int hundig = num / 100;
                Ones(hundig);
                inputCHeck(remainder);
            }
        }
        // TrillianEquations()
        // {
        //     int inputNumber % 100000000000000 = fifteenDigit
        // }


        // int digits = int GetIntegerDigitCount(int inputNumber)
        // {

        // }
    }
}