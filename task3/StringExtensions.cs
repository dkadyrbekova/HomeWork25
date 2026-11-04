//using System;

//public static class StringExtensions
//{
//    public static bool IsValidEmail(this string value)
//    {
//        if (value == null || value == "")
//        {
//            return false;
//        }


//     Количество слов
//    public static int CountWords(this string value)
//    {
//        if (value == null || value.Trim() == "")
//        {
//            return 0;
//        }

//        string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        return words.Length;
//    }

//    public static string RemoveDigits(this string value)
//    {
//        if (value == null)
//        {
//            return "";
//        }

//        string result = "";

//        foreach (char c in value)
//        {
//            if (!char.IsDigit(c))
//            {
//                result = result + c;
//            }
//        }

//        return result;
//    }
//}