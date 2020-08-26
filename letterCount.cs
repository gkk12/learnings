using System;		
using System.Collections.Generic; 
public class Program
{
	public static void Main()
	{
		string input;
		Console.WriteLine("Enter a string:");
		input = Console.ReadLine();
		int len = input.Length;
		
		char[] inputarray;
		inputarray = new char[len];
		inputarray = input.ToCharArray();
		
		Dictionary<char, int> LetterDictionary = new Dictionary<char, int>();
		
		for(char c = 'a'; c <= 'z'; c++) 
		{
    		LetterDictionary.Add(c,0);
		}
		
		for(int i=0;i<len;i++)
		{
			LetterDictionary[input[i]] = LetterDictionary[input[i]] + 1; 
		}
		
		foreach(KeyValuePair<char,int> letter in LetterDictionary) 
        { 
			if(letter.Value > 0)
			{
              Console.WriteLine("{0} and {1}",letter.Key,letter.Value); 
			}
        } 
	}
}
