using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCinemaCenterOOP
{
    public class Film
    {
		private Studio studio;

		public Studio Studio
		{
			get { return studio; }
			set { this.studio = value; }
		}

		private Director director;

		public Director Director
		{
			get { return director; }
			set { this.director = value; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { this.title = value; }
		}

		private string author;

		public string Author
		{
			get { return author; }
			set { this.author = value; }
		}

		private int yearPublished;

		public int YearPublished
		{
			get { return yearPublished; }
			set { this.yearPublished = value; }
		}

        public Film(Studio studio, Director director, string title, string author, int yearPublished)
        {
            Studio = studio;
            Director = director;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }
    }
}
