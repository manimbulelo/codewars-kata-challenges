using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int countTails = 0;
        int countHeads = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 0)
            {
                countHeads++;
            }
            else
            {
                countTails++;
            }
        }
        
        int total_coins = countHeads + countTails;
        int ave = total_coins / 2;

        if (countHeads > countTails)
        {
            int remainder = countHeads - ave;
            return remainder;
        }
        else if (countTails > countHeads)
        {
            int remainder = countTails - ave;
            return remainder;
        }
        else
        {
            return ave;
        }
        
    }
}
