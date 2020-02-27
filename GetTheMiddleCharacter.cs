public class Kata
{
  public static string GetMiddle(string s)
  {
  //Code goes here!
            string middleString = "";
            int getLength = s.Length;
            if (getLength % 2 == 0)
            {
                int startIndex = getLength / 2 - 1;
                middleString = s.Substring(startIndex,2);
            }
            else
            {
                int startIndex = getLength / 2;
                middleString = s.Substring(startIndex, 1);
            }

         return middleString;
  }
}