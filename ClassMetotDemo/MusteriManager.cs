using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMetotDemo;

namespace ClassMetotDemo
{
	public class MusteriManager
	{
		public void MusteriEkle(Musteri musteri)
		{
			Console.WriteLine(musteri.Id + " " + "ID numaralı müşterimiz" + " " + musteri.Ad + " " + musteri.Soyad +" eklenmiştir.");
		}

		public void MusteriListele(Musteri musteri)
		{
			Console.WriteLine(musteri.Id+" " + "ID numaralı müşterimiz"+ " " +musteri.Ad+ " " + musteri.Soyad+ " " +"listeye eklenmiştir.");
		}

		public void MusteriSil(Musteri musteri)
		{
			Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "isimli müşterimizin talepleri doğrultusunda silinmiştir.");
		}
	}
}

