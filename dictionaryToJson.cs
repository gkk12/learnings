using System;
using System.Collections.Generic;
using System.Linq;
					
public class FriendInfoRetriever
{
	public static void Main()
	{
		Dictionary<string,List<string>> infoDictionary = new Dictionary<string,List<string>>();
		string movieNames;
		
		infoDictionary.Add("Gautham",new List<string>(){"Parasite", "Benjamin Button"});
		infoDictionary.Add("Kam",new List<string>(){"Dark Knight","Avengers"});
		
		movieNames = FriendInfoRetriever.ConvertToJson(infoDictionary);							
		Console.WriteLine(movieNames);
		
	}
	
	public static string ConvertToJson(Dictionary<string, List<string>> infoDictionary)  
	{
    	var dictionaryEntries = infoDictionary.Select(d => string.Format("\"{0}\": [{1}]", d.Key, string.Join(", ", d.Value)));
    	string jsonFormat = "{" + string.Join(",\n\n", dictionaryEntries) + "}";
		
		return jsonFormat;
	}
}
