using System;
using System.Collections.Generic;

namespace SpreadSheetNotationConversationLib
{
    public class SpreadSheetNotationConversation
    {
        public static string GetSpreadSheetNotation(long n)
        {
            string result = string.Empty;
            var row = (n % 702) > 0 ? ((n / 702) + 1) : (n / 702);
            var range = (n / 702) > 0 && (n % 702) == 0 ? n : (n % 702);
            var col1 = (range != 26) && (range % 27) == 26 ? (range / 27) : (range / 27) - 1;

            var col2 = (range % 26) > 0 ? (range % 26) - 1 : 25;
            char c1 = '\0';
            if (col1 >= 0) c1 = (char)(col1 + 65);

            char c2 = (char)(col2 + 65);

            if (c1 == '\0')
            {
                result = $"{row}{c2}";
            }
            else
            {
                result = $"{row}{c1}{c2}";
            }
            return result;
        }



        public static Dictionary<long, string> FinalResult()
        {

            Dictionary<long, string> dic = new Dictionary<long, string>();
            long n = 0;
            for (int row = 1; row <= 4; row++)
                for (int j = -1; j <= 25; j++)
                    for (int i = 0; i < 26; i++)
                    {
                        long key = ++n;

                        string value = string.Empty;
                        if (j == -1) value = ((char)(i + 65)).ToString();
                        else value = ((char)(j + 65)).ToString() + ((char)(i + 65)).ToString();

                        dic.Add(key, $"{row}{value}");
                    }
            return dic;
        }
    }
}
