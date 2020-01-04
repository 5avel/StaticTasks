using System;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".CustomSubSting(2, 5));
            Console.WriteLine("Hello World!".CustomIndexOf("Work"));

            Console.WriteLine("Hello World!".CustomReplace("World", "Work"));
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static string CustomSubSting(this string value, int startIndex, int length)
        {
            if (value == null) throw new ArgumentNullException("value");
            if ((value.Length == 0) && (startIndex == 0) && (value.Length >= length)) return string.Empty;
            if ((startIndex < 0) || (startIndex >= value.Length)) throw new ArgumentOutOfRangeException("startIndex");
            if ((length < 0) || (length > value.Length) || (startIndex + length > value.Length)) throw new ArgumentOutOfRangeException("length");
            var sb = new StringBuilder();
            for (int i = startIndex; i < startIndex+length; i++)
            {
                sb.Append(value[i]);
            }
            return sb.ToString();
        }

        public static int CustomIndexOf(this string str, string substr)
        {
            int len = str.Length;
            int sublen = substr.Length;
            int count = 0;
            if (sublen > len)
            {
                return -1;
            }
            for (int i = 0; i < len - sublen + 1; i++)
            {
                for (int j = 0; j < sublen; j++)
                {
                    if (str[j + i] == substr[j])
                    {
                        count++;
                        if (count == sublen)
                        {
                            return i;
                        }
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }
            return -1;
        }

        public static String CustomReplace(this string str, String strFind, String strReplace)
        {
            int iPos = str.IndexOf(strFind);
            String strReturn = "";

            while (iPos != -1)
            {
                strReturn += str.Substring(0, iPos) + strReplace;
                str = str.Substring(iPos + strFind.Length);
                iPos = str.IndexOf(strFind);
            }

            if (str.Length > 0)
                strReturn += str;
            return strReturn;
        }
    }
}
