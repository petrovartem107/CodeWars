using System;
using System.Collections.Generic;

namespace list_lat_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //foreach (var item in ReverseSeq(x))
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(Remove("Hi!"));
            Console.WriteLine(Remove("Hi!!!"));
            Console.WriteLine(Remove("!Hi"));
            Console.WriteLine(Remove("!Hi!"));

        }
        public static List<int> ReverseList(List<int> list)
        {
            var result = new List<int>(list);
            result.Reverse();
            return result;
        }
        public static List<int> AddExtra(List<int> listOfNumbers)
        {

            List<int> result = new List<int>();
            result.Add(3);
            return result;
        }
        public static string StringsSum(string s1, string s2)
        {
            string result = "";
            if (s1 == "")
            {
                s1 = "0";
            }
            if (s2 == "")
            {
                s2 = "0";
            }
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            int c = a + b;
            result = Convert.ToString(c);


            return result;
        }
        public static string Remoe(string s)
        {
            string result = "";
            s = s.Replace("!", "");
            result = s + "!";
            return result;
        }
        public static int[] ReverseSeq(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[result.Length - i - 1] = i + 1;
            }

            return result;
        }
        public static long[] Digitize(long n)
        {
            string temp = n.ToString();
            int lenght = temp.Length;

            long[] result = new long[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result[lenght - i - 1] = long.Parse(temp[i].ToString());
            }
            return result;
        }
        public static string Remove(string s)
        {
            string result = s;
            while (true)
            {
                if (result[result.Length - 1].ToString() == "!")
                {
                    result = result.Remove(result.Length - 1);
                }
                else
                {
                    break;
                }
            }

            return result;
        }
        public static string Shortcut(string input)
        {
            string result = "";
            result = input;
            result = result.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

            return result;
        }
        public static int UniTotal(string str)
        {
            int result = 0;
            foreach (var item in str)
            {
                result += (int)item;
            }
            return result;
        }
    }
}
