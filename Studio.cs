using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCinemaCenterOOP
{
    public class Studio
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { this.name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { this.address = value; }
		}

		private string contact;

		public string Contact
		{
			get { return contact; }
			set { this.contact = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { this.email = value; }
		}

		private List<Film> films;

		public List<Film> Films
		{
			get { return films; }
			set { this.films = value; }
		}
		private int brFilmi;

		public int BrFilmi
		{
			get { return brFilmi; }
			set { this.brFilmi = value; }
		}


		public Studio(string name, string address, string contact, string email, List<Film> films, int brFilmi)
        {
            Name = name;
            Address = address;
            Contact = contact;
            Email = email;
            Films = new List<Film>();
			BrFilmi = brFilmi;
        }

		public void AddFil(Film film)
		{
			films.Add(film);
			BrFilmi++;
		}
    }
}
