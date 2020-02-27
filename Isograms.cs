using System;
using System.Collections.Generic;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    // Code on you crazy diamond!
            string toLowerStr = str.ToLower();
            var set = new HashSet<char>();
            for (int i = 0; i < str.Length; i++)
                if (!set.Add(toLowerStr[i]))
                    return false;
            return true;
  }
}