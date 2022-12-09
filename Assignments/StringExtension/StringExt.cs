using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
   public static class StringExt
    {
        public static void myspecial(this string str)
        {
            int count = 0;
            int a;
            String sp = "!#$%&/()=?»«@£§€{}.-;'<>_,";
            for (a = 0; a < str.Length; a++)
            {
                if (sp.Contains(str[a]))
                {
                    count++;
                }
            }
            Console.WriteLine($"Total number of special characters are:{count}");
        }
        public static void mywords(this string str1)
        {
            int count = 0;
            int a;
            for (a = 0; a < str1.Length - 1; a++)
            {
                if (str1[a] == '.' && str1[a + 1] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Total number of statement are:{count}");
        }
        public static void mydigitplace(this string str1)
        {
            
            int a;
            String num = "1234567890";
            for (a = 0; a <str1.Length; a++)
            {
                if (num.Contains(str1[a]))
                {
                    Console.WriteLine($"Digit {str1[a]} at index number:{a}");
                }
            }
        }
        public static void myupchar(this string str1)
        {
            int a;
            Console.WriteLine("Capitlized first word result: ");
            char[] arr = str1.ToCharArray();
            for (a = 1; a < arr.Length; a++)
            {
                if (arr[a - 1] == ' ' && char.IsLower(arr[a]))
                {
                    arr[a] = char.ToUpper(arr[a]);
                }
            }
            foreach (char c in arr)
            {
                Console.Write(c);
            }
        }


    }
}
