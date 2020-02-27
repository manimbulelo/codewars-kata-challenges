using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    //TODO
    
            int count = 0;
            foreach (bool num in sheeps)
            {
                if (num == true)
                {
                    count++;
                }
            }
            return count;
  }
}