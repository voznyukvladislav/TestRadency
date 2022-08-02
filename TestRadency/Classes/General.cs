using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRadency.Classes;

namespace TestRadency.Classes
{
    public static class General
    {
        public static List<string> DivideString(string str)
        {
            List<string> list = new List<string>();
            string newListItem = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    if (newListItem != "") list.Add(newListItem);
                    newListItem = "";
                }
                else newListItem += str[i];
            }
            if (newListItem != "") list.Add(newListItem);
            return list;
        }
        public static List<int> DivideNum(string value)
        {
            List<int> digits = new List<int>();

            int numSize = value.Length;
            for(int i = 0; i < numSize; i++)
            {
                digits.Add(Convert.ToInt32(value[i].ToString()));
            }

            return digits;
        }
        public static int GetSum(List<int> list)
        {
            int sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
        public static bool CheckValue(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsDigit(value[i])) return false;
            }
            return true;
        }
    }
}