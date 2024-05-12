using cl3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl2
{
	public class Jurnal
	{
		public string NameJurnal { get; set; }
		public string NamePublishingHouse { get; set; }
		public int NumberOfPages { get; set; }
		public DateTime DatePublication { get; set; }

		public List<Articles> articles;
		public Jurnal() { }
		public Jurnal(string nameJurnal, string namePublishingHous, int numberOfPages, DateTime datePublication) 
		{
			NameJurnal = nameJurnal;
			NamePublishingHouse = namePublishingHous;
			NumberOfPages = numberOfPages;
			DatePublication = datePublication;
			articles = new List<Articles>();
		}

		public void AddArticles(Articles articlesP)
		{
			articles.Add(articlesP);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			if (articles != null && articles.Any())
			{
				sb.AppendLine("articles:");
				foreach (var articlesP in articles)
				{
					sb.AppendLine(articlesP.ToString());
				}
			}
			sb.AppendLine($"Name jurnal: {NameJurnal}," +
				$"\nName PublishingHouse: {NamePublishingHouse}," +
				$"\nNumber Of Pages: {NumberOfPages}," +
				$"\nDate Publication: {DatePublication}");
			return sb.ToString();
		}
	}
}
