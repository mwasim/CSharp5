using System;

namespace CSharp.Strings
{
    public class StringDemo
    {
        public static void DisplayOutput()
        {
            Console.WriteLine("Please enter a string:");
            var str = Console.ReadLine();

            Console.WriteLine("Character wise display of the string {0} is", str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("{0}", str[i]);
                Console.WriteLine("{0}", str.Substring(i, 1));
            }
        }

        public static void StringCompareDemo()
        {
            Console.WriteLine("Please enter two strings:");
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            var n = str1.CompareTo(str2);

            if (n == 0) Console.WriteLine("{0} and {1} are equal", str1, str2);
            if (n < 0) Console.WriteLine("{0} is smaller than {1}", str1, str2);
            if (n > 0) Console.WriteLine("{0} is greater than {1}", str1, str2);

        }

        public static void SearchString()
        {
            Console.WriteLine("Please enter the first string:");
            var s1 = Console.ReadLine();

            Console.WriteLine("Please enter the string to search:");
            var s2 = Console.ReadLine();

            var index = s1.IndexOf(s2);
            if (index != -1)
            {
                Console.WriteLine("'{0}' is found in the strng '{1}' at location {2}", s2, s1, index + 1);
            }
            else
            {
                Console.WriteLine("'{0}' is not found in the strng '{1}'", s2, s1);
            }
        }

        public static void CountVowels()
        {
            Console.Write("Please enter a string: ");
            var str = Console.ReadLine();

            int count = 0;
            foreach (char ch in str)
            {
                switch (ch)
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        count++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("The number of vowels in the string {0} are = {1}", str, count);
        }

        public static void IsPalindrome()
        {
            Console.Write("Please enter a string: ");
            var str = Console.ReadLine();

            var p = true;
            var length = str.Length;
            var e = length - 1;
            for (int i = 0; i < length; i++)
            {
                if (str[i] != str[e])
                {
                    Console.WriteLine("The string {0} is not a palindrome.", str);
                    p = false;
                    break;
                }

                e--;
            }

            if (p)
            {
                Console.WriteLine("The string {0} is a Palindrome", str);
            }
        }


        public static void StringFunctions()
        {
            var str = "Hello";
            if (str.StartsWith("H"))
                Console.WriteLine("The string {0} starts with H", str);
            if (str.StartsWith("Hell"))
                Console.WriteLine("The string {0} starts with Hell", str);
            if (str.StartsWith("hell"))
                Console.WriteLine("The string {0} starts with hell", str);
            else
                Console.WriteLine("The string {0} does not start with hell", str);

            if (str.EndsWith("o"))
                Console.WriteLine("The string {0} ends with o", str);
            if (str.Contains("Hell"))
                Console.WriteLine("The string {0} contains 'Hell'", str);
            if (str.StartsWith("hell"))
                Console.WriteLine("The string {0} contains 'hell'", str);
            else
                Console.WriteLine("The string {0} does not contain 'hell'", str);

            Console.WriteLine("The string {0} appears in lower case as '{1}'", str, str.ToLower());
            Console.WriteLine("The string {0} appears in upper case as '{1}'", str, str.ToUpper());
            Console.WriteLine("The string {0} appears after padding on its left '{1}'", str, str.PadLeft(10));
            Console.WriteLine("The string {0} appears after padding on its right '{1}'", str, str.PadRight(10));
        }

        public static void StringFunctions2()
        {
            var str = "Hello";
            var str2 = str.Replace("l", "w");

            Console.WriteLine("The string {0} after replacing 'l' with 'w' is '{1}'", str, str2);

            str2 = str.Insert(5, " World!");
            Console.WriteLine("The string {0} after inserting a word 'World!' is '{1}'", str, str2);

            str2 = str2.Replace("World", "John");
            Console.WriteLine("The string {0} after replacing the word 'World!' with 'John!' is '{1}'", str, str2);

            var str3 = " Hello ";
            Console.WriteLine("The string {0} appears after removing leading spaces as '{1}'", str3, str3.TrimStart());
            Console.WriteLine("The string {0} appears after removing trailing tabs as '{1}'", str3, str3.TrimEnd('\t'));
            Console.WriteLine("The string {0} appears after removing leading and trailing spaces as '{1}'", str3, str3.Trim());

            var str4 = "You are welcome";
            var arr = str4.Split(' ');
            Console.WriteLine("After spliting the string {0} into words as below,", str4);
            foreach (var s in arr)
            {
                Console.Write("{0}\n", s);
            }

            var str5 = string.Join(",", arr);
            Console.WriteLine("After joining the splitted words by comman, it becomes '{0}'", str5);
        }

        public static void StringArray()
        {
            string[] fruits = new string[5];
            Console.Write("Please enter names of the fruits: ");

            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] = Console.ReadLine();
            }

            Console.WriteLine("The elements in the string array are:");
            foreach (var item in fruits)
            {
                Console.Write("{0}\n", item);
            }

            Console.WriteLine();
            string[] fruits2 = { "Apple", "Banana", "Mango", "Orange", "Grapes"};
            foreach (var item in fruits2)
            {
                Console.Write("{0}\n", item);
            }
        }
    }
}
