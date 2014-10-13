using System;

class Program
{
	static void Main()
	{
		Console.Write("N=");
		int number = Int32.Parse(Console.ReadLine());
		
		for (int i = 1; i <= number; i++)
		{

			for (int j = 1; j <= number; j++)
			{
				if (i == j)
					continue;

				Console.WriteLine("{0} {1}", i, j);
			}
		}
	}
}

