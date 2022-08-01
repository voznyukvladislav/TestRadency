using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRadency.Classes;

namespace TestRadency.Classes
{
    class Element
    {
        public string Value { get; set; }
        public int Weight { get; private set; }

        public Element(string value)
        {
            this.Value = value;
            CalcWeight(value);
        }

        private void CalcWeight(string value)
        {
            List<int> digits = General.DivideNum(value);
            this.Weight = General.GetSum(digits);
        }        
        public static void Sort(ref List<Element> list)
        {
            Element temp;

            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].Weight > list[j + 1].Weight)
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    } else if(list[j].Weight == list[j + 1].Weight)
                    {
                        if(String.Compare(list[j].Value, list[j + 1].Value) > 0)
                        {
                            temp = list[j + 1];
                            list[j + 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
            }
        }
        public static void Output(List<Element> list)
        {
            Console.Write("Elements: ");
            foreach (Element element in list)
            {
                Console.Write($"{element.Value} ");
            }
            Console.WriteLine();

            Console.Write("Elements weights: ");
            foreach (Element element in list)
            {
                Console.Write($"{element.Weight} ");
            }
            Console.WriteLine();
        }
        public static string ToString(List<Element> list)
        {
            string str = "";
            for(int i = 0; i < list.Count; i++)
            {
                str += list[i].Value;
                str += " ";
            }

            return str;
        }
    } 
}