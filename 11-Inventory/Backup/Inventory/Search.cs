using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    class Search
    {
        public Search()
        {

        }


        public static int Linear(string[] a, string key, int u)
        {
            for (int i = 1; i <= u; i++)
            {
                if (a[i] != null)
                {
                    if (a[i] == key)
                        return i;
                }
            }
            return -1;
        }



    }
}
