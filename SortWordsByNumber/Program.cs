using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWordsByNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            SortWordBynum(2);
        }

        public static void SortWordBynum(int num)
        {
            int[] num2 = { 9, 7, 6 };
            string words = "";
            string wordsb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] wsb = wordsb.ToCharArray();
            foreach (int i in num2)
            {
                switch (i)
                {
                    case 1:
                        words += "ABC";
                        break;
                    case 2:
                        words += "DEF";
                        break;
                    case 3:
                        words += "GHI";
                        break;
                    case 4:
                        words += "JKL";
                        break;
                    case 5:
                        words += "MNO";
                        break;
                    case 6:
                        words += "PQR";
                        break;
                    case 7:
                        words += "STU";
                        break;
                    case 8:
                        words += "VWX";
                        break;
                    case 9:
                        words += "YZA";
                        break;
                    case 0:
                        words += "BCD";
                        break;
                }
            }
            char[] ws = words.ToCharArray();
            foreach (char i in ws)
            {
                Console.WriteLine(i);
            }
            sortwords("", words);
        }
        private static void sortwords(string result, string now)
        {
            if (now == "")
            {
                Console.WriteLine(result);
            }
            else
            {
                for (int i = 0; i < now.Length; i++)
                {
                    sortwords(result + now[i], now.Substring(0, i) + now.Substring(i + 1));
                }
            }
        }
    }
}
