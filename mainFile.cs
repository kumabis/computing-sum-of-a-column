using System;
using System.Collections.Generic;					
public class Program
{	
	public static void Main()
	{
		List<List<string>> myList = new List<List<string>>()
										{
											new List<string>{"b", "2"},
											new List<string>{"a","1"}
										};		
		int res = 0;
		for(int i=0; i < 2; i++)
		{
			bool flagN = true;
			int sum = 0;
			foreach(var item in myList)
			{
				var flag = int.TryParse(item[i], out res);
				flagN= flag;
				if(!flag)
				{
					break;
				}				
				sum = sum+ Convert.ToInt32(item[i]);
			}
			if(!flagN)
			{
				continue;
			}				
			Console.WriteLine(sum);
		}
	}
}
