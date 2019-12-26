/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * 
 * How many numbers greater than 100 and less than 1 billion have, from left to right, ascending or consistent digits?
 * 
 * 123 is one of these numbers
 * 900 is not
 * 121 is not
 * 12333 is 
 * 1233444 is
 * 13567 is
 * Ignore leading zeroes
 * 
 * 48565
 */
using System;

namespace E012 {
    class E012 {
        public static int Solve() {
            int result = 0;
            for (int i = 100; i < 1000000000; i++) {
                if (CheckNumber(i)) {
                    result++;
                    //Console.WriteLine(i);
                }
            }
            return result;
        }

        private static Boolean CheckNumber(int num) {
            Boolean result = true;  // Assume the best
            String strNum = Convert.ToString(num);
            char prevChar = '0';
            foreach (Char c in strNum) {
                if (prevChar > c) { result = false; break; }
                prevChar = c;
            }
            return result;
        }
    }
}
