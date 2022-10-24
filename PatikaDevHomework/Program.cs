using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatikaDevHomework
{
	public class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run)
			{
				Console.WriteLine("\t[1] Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırma.");
				Console.WriteLine("\t[2] Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırma.");
				Console.WriteLine("\t[3] Kullanıcının girmiş olduğu kelimeleri sondan başa doğru console'a yazdırma.");
				Console.WriteLine("\t[4] Kullanıcının girmiş olduğu verilerdeki toplam kelime ve harf sayısı tespit.");
				Console.WriteLine("\t[5] Çıkış ");
				Console.Write("\tÇalıştıralacak Ödev: ");
				int n = int.Parse(Console.ReadLine());
				switch (n)
				{
					case 1:
						Console.WriteLine("-----------------------\n");
						Works.Homework1();
						break;
					case 2:
						Works.Homework2();
						break;
					case 3:
						Works.Homework3();
						break;
					case 4:
						Works.Homework4();
						break;
					case 5:
						Console.WriteLine("-----------------------\nÇıkış yapılıyor...\n-----------------------");
						string progress = "                                                   ";
						for (int i = 0; i < progress.Length; i++)
						{
							Thread.Sleep(25);
							progress = '#' + progress.Remove(i, 1);
							Console.WriteLine("\t\t[{0}] %{1}", progress, (i * 2));
							Console.SetCursorPosition(0, Console.CursorTop - 1);
						}
						run = false;
						break;
					default:
						Console.WriteLine("-----------------------\nGeçersiz seçim.\n-----------------------");
						Thread.Sleep(500);
						Console.Clear();
						continue;
				}
			}
		}
	}
}

