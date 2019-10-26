using System;

namespace string_massiiv
{
	class Program
	{
		static void Main(string[] args)
		{
			//string on üks klass
			/*string[] myFirstStringArray;
			myFirstStringArray = new string[5] { "one", "two", "three", "four", "five" };

			for (int i = 0; i < myFirstStringArray.Length; i++)
			{
				Console.WriteLine(myFirstStringArray[i]);
			}

			for (int i = myFirstStringArray.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(myFirstStringArray[i]);
			}*/

			//hakkame salvestama massiivi sisse andmeid, mida annab meile kasutaja

			string[] fruits = new string [5]; //viis sõna, küsib 5 korda mis on tema lemmikpuuvili, ei pea olema sama puuvili/

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Name some fruit: "); //kui kasutaja selle fruiti annab, sis ta salvestab ülesse massiivi sisse
				fruits[i] = Console.ReadLine();
			}

			foreach (string fruit in fruits)
			{
				Console.WriteLine($"You have entered: {fruit}");
			}

			Console.ReadLine();
			
		}
	}
}
