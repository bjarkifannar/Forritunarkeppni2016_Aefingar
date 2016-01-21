using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Verkefnalýsing: http://www.ru.is/media/td-forritunarkeppni/fk_2015_sinus_fyrir_hadegi.pdf */
/* Hjálp við lausn: http://codereview.stackexchange.com/questions/40572/finding-prime-factors-of-a-number */

namespace MargfeldiTolustafa
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int numInput = Convert.ToInt32(input);
			string output = null;
			List<int> factors = new List<int>();

			while (numInput > 1)
			{
				int nextFactor = 2;

				if (numInput % nextFactor > 0)
				{
					nextFactor = 3;

					do
					{
						if (numInput % nextFactor == 0)
						{
							break;
						}

						nextFactor += 2;
					} while (nextFactor < numInput);
				}

				numInput /= nextFactor;
				factors.Add(nextFactor);
			}

			if (factors.Count == 1)
			{
				output = "-1";
			}
			else
			{
				for (int i = 0; i < factors.Count; i++)
				{
					output += factors[i] + "";
				}
			}

			Console.WriteLine(output);
			Console.ReadKey();
		}
	}
}