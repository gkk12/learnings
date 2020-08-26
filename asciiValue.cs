using System;
using System.Collections.Generic; 
					
public class AsciiGenerator
{
	public static void Main()
	{
		Dictionary< char, int> AsciiDictionary = new Dictionary< char, int>();
		
		for(int i = 0; i < 52; i++)
		{
			if(i >= 26)
			{
				AsciiDictionary.Add((char)(i + 71), i + 71);	
			}
			else
			{
    			AsciiDictionary.Add((char)(i + 65), i + 65);
			}
		}
		
		foreach(KeyValuePair<char,int> letter in AsciiDictionary) 
        { 
              Console.WriteLine("{0}:{1}", letter.Key, letter.Value); 
        } 
		
		string input;
		Console.WriteLine("Enter a string");
		input = Console.ReadLine();
		
		foreach(char c in input)
		{
			Console.WriteLine((int)c);	
		}
	}
}
