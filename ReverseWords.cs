using System.Text;
using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
		//Write your code here
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        str = str + " ";
        string reverse = "";
        string[] builder = new string[str.Length];

        for (int i = 0; i <= str.Length - 1; ++i)
        {
            if (!Char.IsWhiteSpace(str[i]))
            {
                builder[i] = Convert.ToString(str[i]);
            }
            else
            {
                Array.Reverse(builder);
                foreach (string c in builder)
                {
                    reverse += c;
                }
                reverse = reverse + " ";                                       
                Array.Clear(builder, 0, builder.Length);
            }
        }

        return reverse.Substring(0, reverse.Length - 1);
  }
}
