using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl3
{
	public class Articles
	{
		public string NameArticles {  get; set; }
		public int NumberOfCharacters {  get; set; }
		public string AnnouncementOfTheArticle {  get; set; }

		public Articles() { }

		public Articles(string nameArticles, int numberOfCharacters, string announcementOfTheArticle)
		{
			NameArticles = nameArticles;
			NumberOfCharacters = numberOfCharacters;
			AnnouncementOfTheArticle = announcementOfTheArticle;
		}

		public override string ToString()
		{
			return $"\nName articles: {NameArticles}," +
				$"\nNumber Of Characters: {NumberOfCharacters}," +
				$"\nAnnouncement Of The Article: {AnnouncementOfTheArticle}";
		}
	}
}
