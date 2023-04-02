using System;
using System.Linq;
namespace FinalExamPrep2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] info = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = info[0];
                if (action == "InsertSpace")
                {
                    int index = int.Parse(info[1]);
                    text = text.Insert(index, " ");
                    Console.WriteLine(text);
                }
                else if (action == "Reverse")
                {
                    string reversedSubstring = info[1];
                    if (text.Contains(reversedSubstring))
                    {
                        int index = text.IndexOf(reversedSubstring);
                        text = text.Remove(index, reversedSubstring.Length);
                        string reversed = new string(reversedSubstring.Reverse().ToArray());
                        text += reversed;
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = info[1];
                    string replacement = info[2];
                    text = text.Replace(substring, replacement);
                    Console.WriteLine(text);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
