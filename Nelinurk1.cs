using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
	public class Nelinurk1
	{
		int kõrgus;
		int laius;
		string ümbermõõt;

		public Nelinurk1() { }//пустой конструктор
		public Nelinurk1(int kõrgus, int laius)
		{
			kõrgus = Kõrgus;
			laius = Laius;
			ümbermõõt = Ümbermõõt;
		}
		public int Kõrgus {
			set { kõrgus = value; }
			get { return kõrgus; }
		}
		public int Laius {
			set { laius = value; }
			get { return laius; }
		}
		public int Ümbermõõt { 	
			set { ümbermõõt = value; }
			get { return ümbermõõt; }
		}
		public double Ümber()
		{
			double ümber = 0;
			ümber = (kõrgus+laius)*2;
			return ümber ;
		}
			public void Info ()
		{ 
			Console.WriteLine("Tere");
			Console.WriteLine("Minu kõrgus on {0} . Minu laius on {1} . Minu ", kõrgus, laius);
		}
	}
}
