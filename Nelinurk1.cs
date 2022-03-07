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
		Tüüp tüüp;
		int nurg;
		string staatus;

		public Nelinurk1() { }//пустой конструктор
		public Nelinurk1(int kõrgus, int laius)
		{
			kõrgus = Kõrgus;
			laius = Laius;
			this.tüüp = tüüp;
			staatus = Staatus;

		}
		public string Tüüp 
		{
			set {
				if (kõrgus == laius && laius == kõrgus)
				{
					staatus = "ruut";
				}
			}

			get { return tüüp; }	
		}
		public string Staatus 
		{	
			get{
			var staatus=""; 
			if(kõrgus==laius && laius==kõrgus)
			{
				staatus = "ruut";
			}
			return staatus;
			}
		}		

		public int Kõrgus {
			set { kõrgus = value; }
			get { return kõrgus; }
		}
		public int Laius {
			set { laius = value; }
			get { return laius; }
		}
		public int Nurg 
		{
			set { nurg = value; }
			get { return nurg; }
		}
		public double Ümber()
		{
			double ümber = (kõrgus + laius) * 2;
			return ümber;
		}
		public double Pindala()
		{
			double pindala = kõrgus * laius; ;
			return pindala;
		}
		public void Info()
		{
			Console.WriteLine("Minu kõrgus on {0} . Minu laius on {1} .", kõrgus, laius);
		}
		//второй вариант info нужно доделать
		//{
		//	//if (kõrgus!=null && laius!=null)
		//	//{
		//	//	Console.WriteLine("Minu kõrgus on {0} . Minu laius on {1} .", kõrgus, laius);
		//	//}
		//	//else if (pindala!=null && ümber!=null)
		//	//{
		//	//	Console.WriteLine("Minu pindla on {0} . Minu  ümber {1}", pindala, ümber);
		//	//}
		//}
	}
}
