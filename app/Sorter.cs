using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{

    public class Sorter
    {
        public static List<int> Sort(List<int> list)
        {
            int n = list.Count;
            int change;

            while (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        change = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = change;
                    }
                }
                n--;
            }

            return list;
        }
    }
}
    