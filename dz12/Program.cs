using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cl1;
using System.IO;
using Newtonsoft.Json;
using cl2;
using cl3;


namespace dz12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			Завдання 1:
			//Створіть програму для роботи з масивом дробів(чисельник і
			//знаменник) з такою функціональністю:
			//+ 1.Введення масиву дробів з клавіатури.
			//+ 2.Серіалізація масиву дробів.
			//+ 3.Збереження серіалізованого масиву у файл.
			//+ 4.Завантаження серіалізованого масиву з файлу. Після
			//+завантаження потрібно виконати десеріалізацію.
			//Вибір певного формату серіалізації потрібно зробити вам.
			//Звертаємо вашу увагу, що вибір має бути обґрунтованим.

			//Fraction[] fraction = new Fraction[2];

			//Console.WriteLine("Enter elements for fractions: ");

			//for (int i = 0; i < fraction.Length; i++)
			//{
			//	Console.Write($"Enter numerator for fraction {i + 1}: ");
			//	int numerator = int.Parse(Console.ReadLine());

			//	Console.Write($"Enter denominator for fraction {i + 1}: ");
			//	int denominator = int.Parse(Console.ReadLine());

			//	fraction[i] = new Fraction(numerator, denominator);
			//}
			//Console.WriteLine("\nFractions:");
			//foreach (var fractionP in fraction)
			//{
			//	Console.WriteLine(fractionP);
			//}

			//try
			//{
			//	using (StreamWriter sw1 = new StreamWriter("zav1.txt", false))
			//	{
			//		string jSonP = JsonConvert.SerializeObject(fraction);
			//		sw1.WriteLine(jSonP);
			//	}
			//	if (File.Exists("zav1.txt"))
			//	{
			//		using (StreamReader st1 = new StreamReader("zav1.txt"))
			//		{
			//			string json = st1.ReadToEnd();
			//			fraction = JsonConvert.DeserializeObject<Fraction[]>(json);
			//		}
			//	}
			//}
			//catch (IOException ex)
			//{
			//	Console.WriteLine($"An error occurred while accessing the file: {ex.Message}");
			//}


			//			Завдання 2:
			//Створіть програму для роботи з інформацією про журнал, в якій
			//зберігатиметься таку інформація:
			//+1.Назва журналу.
			//+2.Назва видавництва.
			//+3.Дата видання.
			//+ 4.Кількість сторінок.
			//Програма має бути з такою функціональністю:
			//+ 1.Введення інформації про журнал.
			//+ 2.Виведення інформації про журнал.
			//+3.Серіалізація журналу.
			//+4.Збереження серіалізованого журналу у файл.
			//+ 5.Завантаження серіалізованого журналу з файлу. Після завантаження потрібно виконати десеріалізацію журналу.
			//Вибір певного формату серіалізації потрібно зробити вам.
			//Звертаємо вашу увагу, що вибір має бути обґрунтованим.

			Console.WriteLine("Enter name Jurnal:");
			string NameJurnal = Console.ReadLine();

			Console.Write("Name PublishingHouse: ");
			string NamePublishingHouse = Console.ReadLine();

			Console.Write("Number Of Pages: ");
			int NumberOfPages = int.Parse(Console.ReadLine());

			Console.Write("Date Publication (yyyy-mm-dd): ");
			DateTime DatePublication = DateTime.Parse(Console.ReadLine());

			Jurnal Burda = new Jurnal(NameJurnal, NamePublishingHouse, NumberOfPages, DatePublication);

			Console.WriteLine("Jurnal:\n");
			Console.WriteLine(Burda);

			using (StreamWriter sw2 = new StreamWriter("zav2.txt", false))
			{
				string jSon2 = JsonConvert.SerializeObject(Burda);
				sw2.WriteLine(jSon2);
				Console.WriteLine("ok");
			}
			using (StreamReader st2 = new StreamReader("zav2.txt"))
			{
				string jSon2R = st2.ReadToEnd();
				Burda = JsonConvert.DeserializeObject<Jurnal>(jSon2R);
				Console.WriteLine("ok");
			}
			Console.WriteLine("Deserialised Jurnal: \n");
			Console.WriteLine(Burda);

			//			Завдання 3:
			//Додайте до попереднього завдання список статей з журналу. 
			//Потрібно зберігати наступну інформацію про кожну статтю:
			//+ 1.Назва статті.
			//+ 2.Кількість символів.
			//+ 3.Анонс статті.
			//Змініть функціональність з попереднього завдання таким чином, 
			//щоб вона враховувала список статей.

			Articles articles1 = new Articles();
			articles1.NameArticles = "15 patterns of dresses and blouses with a square neckline";
			articles1.NumberOfCharacters = 300;
			articles1.AnnouncementOfTheArticle = "The square neckline in dresses and blouses, which is usually " +
				"more favored by older fashionistas, this season also attracted the attention of young people";

			Burda.AddArticles(articles1);

			using (StreamWriter sw3 = new StreamWriter("zav2.txt", true))
			{
				string jSonW = JsonConvert.SerializeObject(Burda);
				sw3.WriteLine(jSonW);
				Console.WriteLine("ok");
			}

			//			Завдання 4:
			//Додайте до попереднього завдання можливість створення
			//масиву журналів. 
			//Змініть функціональність з другого завдання таким чином, щоб
			//вона враховувала масив журналів.
			//Вибір певного формату серіалізації потрібно зробити вам.
			//Звертаємо вашу увагу, що вибір має бути обґрунтованим

			List<Jurnal> jurnalsAll = new List<Jurnal>();

			jurnalsAll.Add(Burda);

			Console.WriteLine("Enter name Jurnal:");
			string NameJurnalV = Console.ReadLine();

			Console.Write("Name PublishingHouse: ");
			string NamePublishingHouseV = Console.ReadLine();

			Console.Write("Number Of Pages: ");
			int NumberOfPagesV = int.Parse(Console.ReadLine());

			Console.Write("Date Publication (yyyy-mm-dd): ");
			DateTime DatePublicationV = DateTime.Parse(Console.ReadLine());

			Jurnal Vouge = new Jurnal(NameJurnalV, NamePublishingHouseV, NumberOfPagesV, DatePublicationV);
			Articles articles2 = new Articles();
			articles2.NameArticles = "Info";
			articles2.NumberOfCharacters = 100;
			articles2.AnnouncementOfTheArticle = "Including interviews with designers, curators, artists and patrons";
			Vouge.AddArticles(articles2);
			jurnalsAll.Add(Vouge);

			using (StreamWriter sw3 = new StreamWriter("zav2.txt", true))
			{
				string jSonW = JsonConvert.SerializeObject(jurnalsAll);
				sw3.WriteLine(jSonW);
				Console.WriteLine("ok");
			}



		}
	}
}
