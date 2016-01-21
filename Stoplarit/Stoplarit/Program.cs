using System;
using System.Collections.Generic;

/* Verkefnalýsing: http://www.ru.is/media/td-forritunarkeppni/fk_2015_sinus_fyrir_hadegi.pdf */

namespace Stoplarit
{
	class Program
	{
		static void Main(string[] args)
		{
			bool done = false;
			List<string> input = new List<string>();

			do
			{
				string tmp = Console.ReadLine();
				input.Add(tmp);

				if (tmp[0] != ' ' && tmp[0] != '|')
					done = true;
			} while (!done);

			int[] outcome = new int[input[0].Length];

			for (int i = 0; i < input.Count; i++)
				for (int j = 0; j < outcome.Length; j++)
					if (input[i][j] == '|')
						outcome[j]++;

			for (int i = 0; i < outcome.Length; i++)
				Console.WriteLine(input[input.Count - 1][i] + ": " + outcome[i]);

			Console.ReadKey();
		}
	}
}