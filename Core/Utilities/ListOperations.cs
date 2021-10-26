using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public static class ListOperations
    {
        public static List<List<string>> Split(List<string> list, string expression) // eg. List<string> text = new List<string>() {"Halil İbrahim"} --> Split(text, " ") will return Halil:List, İbrahim:List
        {
            List<List<string>> splitedList = new List<List<string>>();
            List<string> temp = new List<string>();

            foreach (var item in list)
            {
                if (item == expression)
                {
                    splitedList.Add(temp);
                    temp.Clear();
                    continue;
                }

                temp.Add(item);
            }

            return splitedList;
        }
    }
}
