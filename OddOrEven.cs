public class Kata
{
  public static string OddOrEven(int[] array)
  {
    //enter code here
    int total = 0;
        foreach (int c in array)
        {
            total += c;
        }

        if (total % 2 == 0 || total == 0)
        {
            return "even";
        }else
        {
            return "odd";
        }
  }
}