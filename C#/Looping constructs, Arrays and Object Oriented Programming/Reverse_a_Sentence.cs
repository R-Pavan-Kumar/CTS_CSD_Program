using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string"); 
        string sentence = Console.ReadLine();

        string reversed = Reverse (sentence); 
        Console.WriteLine(reversed);
    }
    public static string Reverse (string sentence)
    {
        string[] words = sentence.Split(' '); 
        Array.Reverse(words); 
        return string.Join(" ", words);
    }
}