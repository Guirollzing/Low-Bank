﻿namespace LowBank.Windows.Infraestruction
{
    internal static class StringExtensions
    {
        internal static string OnlyDecimalChars(this string text)
        {
            List<char> charList = new List<char>();
            foreach (char caracter in text)
            {
                if (char.IsDigit(caracter) || caracter == ',' || caracter == '.' || caracter == '-')
                {
                    charList.Add(caracter);
                }
            }

            string decimalString = new string(charList.ToArray());

            return decimalString;
        }
    }
}
