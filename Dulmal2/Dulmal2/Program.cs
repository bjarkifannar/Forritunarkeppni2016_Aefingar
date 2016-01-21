using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Verkefnalýsing: http://www.ru.is/media/td-forritunarkeppni/fk_2015_sinus_fyrir_hadegi.pdf */

namespace Dulmal2
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] stafir = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			Random rand = new Random();
			int stokk = Convert.ToInt32(Console.ReadLine());
			string input = Console.ReadLine();
			string output = null;

			for (int i = 0; i < input.Length; i++)
			{
				output += input[i];

				if (i < input.Length - 1)
				{
					for (int j = 0; j < stokk - 1; j++)
					{
						output += stafir[rand.Next(0, stafir.Length)];
					}
				}
			}

			Console.WriteLine(output);
			Console.ReadKey();
		}
	}
}