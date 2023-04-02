using System;
using System.Text.RegularExpressions;

namespace BarcodeScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    string productGroup = "";
                    string barcodeWithoutSurroundingSymbols = match.Groups[1].Value;

                    foreach (char ch in barcodeWithoutSurroundingSymbols)
                    {
                        if (Char.IsDigit(ch))
                        {
                            productGroup += ch;
                        }
                    }

                    if (productGroup == "")
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
