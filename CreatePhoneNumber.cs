using System;

public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
            string storeNumber = "";
            if (numbers.Length == 10)
            {
                foreach (int s in numbers)
                {
                    storeNumber += s.ToString();
                }
            }
            string builder = "(" + storeNumber.Substring(0, 3) + ") " + storeNumber.Substring(3, 3) + "-" + storeNumber.Substring(6, 4);
            return builder;
  }
}