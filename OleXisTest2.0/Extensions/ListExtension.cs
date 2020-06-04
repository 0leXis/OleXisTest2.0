using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public static class ListExtension
    {
        private static Random rnd = new Random();
        public static List<T> GetRandomizedList<T>(this List<T> list)
        {
            var randomizedList = new List<T>();
            var usedNumbers = new HashSet<int>();
            while(usedNumbers.Count != list.Count)
            {
                var index = rnd.Next(0, list.Count);
                if (!usedNumbers.Contains(index))
                {
                    usedNumbers.Add(index);
                    randomizedList.Add(list[index]);
                }
            }
            return randomizedList;
        }
    }
}
