using System;

namespace _24._10_funktsioonid_massiivid
{
	class Program
	{
		static void Main(string[] args)
		{
			//arvuti küsib kasutajalt sünniaasta ja arvutab vanust ja tagastab selle vanuse ja siis saab seda vanust hiljem kasutada

			int yearOfBirth;
			int age; //deklareerin siin, aga väärtust saan funktsioonis

			Console.WriteLine("Enter Your year of birth: ");
			yearOfBirth = Int32.Parse(Console.ReadLine());

			age = CalculateAge(yearOfBirth, 2019);
			Console.WriteLine($"You are {age} years old!");

			int ageNextYear = CalculateNextYear(age);			
			Console.WriteLine($"Next year you are {ageNextYear}");

			CalculateDifference(yearOfBirth);

			Console.ReadLine();

		}
		public static int CalculateAge(int yearOfBirth, int currentYear)
		{
			//int result = currentYear - yearOfBirth;   // see on pikem versioon, allolev on lühem versioon
			//return result;
			return currentYear - yearOfBirth;
		}
		
		public static int CalculateNextYear(int userAge) //userAge ei ole muutuja, tal väärtust ei ole, 
		{
			return userAge + 1;
		}

		public static void CalculateDifference(int yearOfBirth)
		{
			if(yearOfBirth > 1926 )
			{
				Console.WriteLine($"you are {yearOfBirth - 1926} year(s) younger than the Queen!");
						//Math.abs toob positiivse numbri//
			}
			else if (yearOfBirth < 1926)
			{
				Console.WriteLine($"you are { 1926 - yearOfBirth} year(s) older than the Queen!");
			}
			else
			{
				Console.WriteLine("Are you the Queen?");
			}
		}

		}
	}

