using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"@#+(?<name>[A-Za-z0-9]{4,}[A-Z])@#+";
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Match match = Regex.Match(input, pattern);
            //    if (match.Success)
            //    {
            //        string name = match.Groups["name"].Value;
            //        char[] charArray = new char[name.Length];

            //        for (int j = 0; j < name.Length; j++)
            //        {
            //            charArray[j] = name[j];

            //        }
            //        int[] intArray = charArray.Where(c => char.IsDigit(c)).Select(c => int.Parse(c.ToString())).ToArray();
            //        string defaultGroup = "0";
            //        if (intArray.Length == 0)
            //        {
            //            defaultGroup += "0";
            //        }
            //        else if (intArray.Length == 1)
            //        {
            //            int number = intArray[0];
            //            defaultGroup = number.ToString();
            //        }
            //        else if (intArray.Length == 2)
            //        {
            //            int number = intArray[0];
            //            int second = intArray[1];
            //            defaultGroup = number.ToString();
            //            defaultGroup += second.ToString();
            //        }

            //        Console.WriteLine($"Product group: {defaultGroup}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid barcode");
            //    }

            //}

        }
    }
}
