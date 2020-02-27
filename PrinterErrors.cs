using System;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        // your code
            int checkLength = s.Length;
            int numErrors = 0;

            foreach (char c in s)
            {
                if (c < 'a' || c > 'm')
                    numErrors++;
            }
            return numErrors.ToString() + "/" + checkLength.ToString();
    }
}