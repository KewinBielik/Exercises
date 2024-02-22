using System;
class Program
{
    static void PrintStrings(string[] strings)
    {
        foreach (string str in strings) { Console.WriteLine(str); }
    }


    static void Main(string[] args)
    {
        string[] strings = { "this", "is", "the", "array", "of", "strings" };
        PrintStrings(strings);
    }
}
