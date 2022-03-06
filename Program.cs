using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
	class Program
	{
		static void Main(string[] args)
		{
			Nelinurk1 kõr = new Nelinurk1();
			kõr = new Nelinurk1();
			Console.WriteLine("Kõrgus:");
			kõr.Kõrgus = int.Parse(Console.ReadLine());
			Console.WriteLine("Laius:");
			kõr.Laius = int.Parse(Console.ReadLine());
			double ümber = kõr.Ümber();
			kõr.Info();

			Console.ReadLine();

		}


	}
}
