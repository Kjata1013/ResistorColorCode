using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorCode
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] bandColor = new string [10] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "gray", "white" };
			int[] multiplier = new int[8];
			string ohm = "Ω";
			int sum = 1;
			multiplier[0] = 1;

			for (int i = 1; i < multiplier.Length; i++)
			{
				sum = sum * 10;
				multiplier[i] = (int)sum;
			}

			Console.Write("Please enter the first color: ");
			string firstColor = Console.ReadLine();

			Console.Write("Please enter the second color: ");
			string secondColor = Console.ReadLine();

			Console.Write("Please enter the color of the multiplier: ");
			string thridColor = Console.ReadLine();

			int multColorIndex = Array.IndexOf(bandColor, thridColor);
			int multColorElement = multiplier[multColorIndex];

			Console.WriteLine($"The resistance is {(((Array.IndexOf(bandColor, firstColor))* 10) + Array.IndexOf(bandColor,secondColor)) * multColorElement} {ohm}");

		}
	}
}
