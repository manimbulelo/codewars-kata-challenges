using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
        string cntNumToStrng = (string)Convert.ToString(num);
        string rvsdNum = "";
        int reverse = 0, remainder;
        int[] rem =  new int[cntNumToStrng.Length];
        int index = 0;

        while (num != 0)
        {
            remainder = Convert.ToInt32(num % 10);
            rem[index] = remainder;
            reverse = reverse * 10 + remainder;
            num /= 10;
            index++;
        }

        Array.Sort(rem);
        Array.Reverse(rem);

        foreach (int c in rem)
        {
            rvsdNum += c;
        }

        return Convert.ToInt32(rvsdNum);
    }
  
}