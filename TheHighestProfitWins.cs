using System;
using System.Collections.Generic;
using System.Linq;

public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {
        // your code
        
            HashSet<int> listNumbers = new HashSet<int>();
            int[] maxMin = new int[2];
            for (int i = 0; i <= lst.Length - 1; ++i)
            {
                listNumbers.Add(lst[i]);         
            }

            maxMin[0] = listNumbers.Min();
            maxMin[1] = listNumbers.Max();
            return maxMin;
    }
}