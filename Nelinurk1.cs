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
		//string ümber;
		//Tüüp tüüp;

		public Nelinurk1() { }//пустой конструктор
		public Nelinurk1(int kõrgus, int laius)
		{
			kõrgus = Kõrgus;
			laius = Laius;
		}
		public int Kõrgus {
			set { kõrgus = value; }
			get { return kõrgus; }
		}
		public int Laius {
			set { laius = value; }
			get { return laius; }
		}
		public double Ümber()
		{
			double ümber=kõrgus * 2 + laius * 2;
			return ümber ;
		}
		public double Pindala()
		{
			double pindala = kõrgus * laius; ;
			return pindala;
		}
		public void Info ()
		{ 
			Console.WriteLine("Tere");
			Console.WriteLine("Minu kõrgus on {0} . Minu laius on {1} . Minu  ümber {2}", kõrgus, laius, pindala);
		}
	}
}
