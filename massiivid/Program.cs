using System;

namespace massiivid
{
	class Program
	{
		static void Main(string[] args)
		{
			//massiiv on andmete kogum. Meil on int, double, string, char, bool. Arvuti annab ruumi valmis ja ta teab
			//tüüpi andmeid ma hakkan sinna salvestama. Massiiv võib sisaldada ainult 1 tüüpi, nt kui panen valmis sõna, siis
			//panengi valmis sõna. Massiivid on vajalikud, et protsessor teaks kust ta neid andmeid võtab

			//peab teadma, mitu elementi on massiivi sees, kui tea, siis massiivi kasutada ei saa

			int[] myFirstArray = new int[5] { 1, 2, 3, 4, 5};
			// see 5 on pikkus ehk indeksid, nurksulud tähendab massiivi, numbrid 1-5 on mingid väärtused
			/*Console.WriteLine(myFirstArray);-- see on pikem versioon, mida mitte kasutada
			Console.WriteLine(myFirstArray[0]);
			Console.WriteLine(myFirstArray[1]);
			Console.WriteLine(myFirstArray[2]);
			Console.WriteLine(myFirstArray[3]);
			Console.WriteLine(myFirstArray[4]);*/

			for (int i = 0; i<myFirstArray.Length; i++) //me ei tea massiivi pikkust
			{
				Console.WriteLine(myFirstArray[i]);
			}

			for (int i = myFirstArray.Length -1; i >= 0; i--)
			{
				Console.WriteLine(myFirstArray[i]);
			}

			//overwriting array values

			//muudame viimase elemendi 5-st 500-ni

			myFirstArray[4] = myFirstArray[4] * 100;
			myFirstArray[0] = myFirstArray[1] * 100;

			for (int i = 0; i < myFirstArray.Length; i++)
			{
				Console.WriteLine(myFirstArray[i]);
			}

			//esimene nr on 100, teine on 200 jne//
			for (int i = 0; i < myFirstArray.Length; i++)
			{
				myFirstArray[i] = myFirstArray[i] * 100;
				Console.WriteLine(myFirstArray[i]);
			}
			Console.ReadLine();
		}
	}
}
