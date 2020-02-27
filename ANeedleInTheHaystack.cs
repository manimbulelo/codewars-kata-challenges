using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
  //Code goes here!
  int index = 0;

  for (int i = 0; i <= haystack.Length - 1; ++i)
      {
        if (haystack[i] != null && haystack[i].Equals("needle"))
            {
              index = i;
            }
      }
  return "found the needle at position "+ index;
  }
}