using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevHomework
{
	public static class Works
	{

		public static void Homework1()
		{
			int n = 0;
			while (n < 1)
			{
				Console.Write("Pozitif bir Sayı Giriniz: ");
				var inpt = Console.ReadLine();
				if (inpt == null)
				{
					continue;
				}
				n = int.Parse(inpt);
			}
			Console.WriteLine(" {0} adet sayı girişi yapınız.", n);

			List<int> arr = new List<int>();

			for (int i = 0; i < n; i++)
			{

				Console.Write(" {0}. Sayı: ", (i + 1));
				int sayi = int.Parse(Console.ReadLine());
				arr.Add(sayi);
			}

			Console.Write("--------------------------\nGiriş yapılan çift sayılar:\n");
			foreach (var number in arr)
			{
				if (number % 2 == 0)
				{
					Console.Write("{0}\t", number);
				}
			}
			Console.WriteLine("\n-----------------------\n");
		}

		public static void Homework2()
		{
			Console.WriteLine("\n-----------------------\n");
			Console.WriteLine("2 sayı girişi yapınız");
			Console.Write("Sayı 1: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Sayı 2: ");
			int m = int.Parse(Console.ReadLine());
			Console.WriteLine("\n-----------------------\n");
			Console.WriteLine("lüften {0} tane daha sayı girişi yapınız", n);

			var nums = new List<int>();

			for (int i = 1; i < n + 1; i++)
			{

				Console.Write("Sayı {0}: ", i);
				var sayi = int.Parse(Console.ReadLine());
				nums.Add(sayi);
			}
			Console.WriteLine("\n-----------------------\n Sonuç :\n");
			foreach (var number in nums)
			{
				if (number == m)
				{
					Console.WriteLine("{0} sayısı m'e eşittir" , number);
				}
				else
				{
					for (int i = 1; i <= number; i++)
					{
						if (number % i ==0) {
							Console.WriteLine("{0} sayısını tam böleni : {1}" , number ,i);
						}
					}
				}
			}
			Console.WriteLine("\n-----------------------\n");

		}

		public static void Homework3()
		{
			Console.WriteLine("\n-----------------------\n");
			Console.Write("Giriş yapılacak kelime sayısı : ");
			int n = int.Parse(Console.ReadLine());

			var words = new List<string>();

			for (int i = 1; i <= n; i++)
			{
				Console.Write("Kelime {0}: " , i);
				var word = Console.ReadLine();
				words.Add(word);
			}
			Console.WriteLine("\n-----------------------\n Sonuç : \n");
			words.Reverse();

			words.ForEach(Console.WriteLine);
			Console.WriteLine("\n-----------------------\n");
		}

		public static void Homework4()
		{
			Console.WriteLine("\n-----------------------\n");
			Console.Write("Lütfen bir metin girişi yapın: ");
			string sentence = Console.ReadLine();
			sentence = sentence.ToLower();

			int numberofcharacters = sentence.Count();

			string letters = "abcçdefgğhıijklmnoöprsştuüvyzxwq";

			int numberofletters = 0;
			for (int i = 0; i < numberofcharacters; i++)
			{
				if (letters.Contains(sentence[i]))
				{
					numberofletters++;
				}
			}

			Console.WriteLine("Metindeki harf sayısı: " + numberofletters);


			string[] words = sentence.Split(' ');

			Console.WriteLine("Metindeki kelime sayısı: " + words.Length);

			Console.WriteLine("\n-----------------------\n");
		}
	}
}
