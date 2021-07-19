using System;
using System.Text;

namespace LDC
{
    public static class StringExtension
    {
        public static string ReplaceDuplicateChars(this string str)
        {
            StringBuilder sb = new StringBuilder();
            char c = str[0];
            for(int i = 1; i<str.Length; i++)
            {
                if (c == str[i]) continue;
                sb.Append(c);
                c = str[i];
            }
            sb.Append(c);
            return sb.ToString();
        }

        public static string RemoveChar(this string str, char c)
        {
            if (string.IsNullOrWhiteSpace(str)) throw new System.ArgumentException("String is empty");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c) continue;
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        public static string TrimToLength(this string str, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(str)) throw new System.ArgumentException("String is empty");
            return str.Substring(0, Math.Min(str.Length, maxLength));

        }
    }
}
