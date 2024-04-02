using System;

class DecimalToBinaryConverter
{
	static void Main(string[] args)
	{
		Console.WriteLine("Podaj liczbę dziesiętną do przekonwertowania na binarną:");
		int decimalNumber = Convert.ToInt32(Console.ReadLine());

		string binaryNumber = DecimalToBinary(decimalNumber);

		Console.WriteLine($"Liczba binarna dla {decimalNumber} to: {binaryNumber}");
	}

	static string DecimalToBinary(int decimalNumber)
	{
		string binary = "";

		while (decimalNumber > 0)
		{
			int remainder = decimalNumber % 2;
			binary = remainder + binary;
			decimalNumber /= 2;
		}

		return binary;
	}
}