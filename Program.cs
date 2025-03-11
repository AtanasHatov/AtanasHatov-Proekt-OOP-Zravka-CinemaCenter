using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCinemaCenterOOP
{
    internal class Program
    {
        static List<Studio> studios = new List<Studio>();
        static List<Director> directors = new List<Director>();
        static List<Film> films = new List<Film>();
        static List<Actor> actors = new List<Actor>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1 - Изход");
                Console.WriteLine("2 - Добави студио");
                Console.WriteLine("3 - Добави режисьор");
                Console.WriteLine("4 - Добави филм");
                Console.WriteLine("5 - Добави актьор");
                Console.WriteLine("6 - Добави филм на режисьора");
                Console.WriteLine("7 - Добави филм на студиото");
                Console.WriteLine("8 - Всички студиа");
                Console.WriteLine("9 - Всички режисьори");
                Console.WriteLine("10 - Всички филми");
                Console.WriteLine("11 - Всички актьори");
                Console.WriteLine("12 - Всички филми на даден режисьор");
                Console.WriteLine("13 - Всички филми на даденo studio");
                Console.WriteLine("14 - Студиото с най-много филми");

                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    case 2:
                        AddStudio();
                        break;
                    case 3:
                        AddDirector();
                        break;
                    case 4:
                        AddFilm();
                        break;
                    case 5:
                        AddActor();
                        break;
                    case 6:
                        AddFilmInDirector();
                        break;
                    case 7:
                        AddFilmInStudio();
                        break;
                        case 8:
                            AllStudios();
                        break;
                        case 9:
                            AllDirector();
                        break;
                        case 10:
                            AllFilms();
                        break;
                        case 11:
                            AllActors();
                        break;
                        case 12:
                            FilmsNaDirector(); 
                        break;
                        case 13:
                            FilmsNaStudio();
                        break;
                        case 14:
                            TheBestStudio(); 
                        break;
                    default:
                        Console.WriteLine("Няма такава опция в менюто!!!!!");
                        break;
                }
                if (num == 1)
                {
                    break;
                }

            }
        }

        static void AddStudio()
        {
            Console.WriteLine("Въведете име на студиото:");
            string name = Console.ReadLine();

            Console.WriteLine("Въведете адрес на студиото:");
            string address = Console.ReadLine();

            Console.WriteLine("Въведете телефон за контакт на студиото:");
            string contact = Console.ReadLine();

            Console.WriteLine("Въведете имейл на студиото:");
            string email = Console.ReadLine();

            Console.WriteLine("Брой филми в студиото");
            int br = int.Parse(Console.ReadLine());

            List<Film> filmiNaStudioto = new List<Film>();

            Studio studio = new Studio(name, address, contact, email, filmiNaStudioto, br);
            studios.Add(studio);
        }

        static void AddDirector()
        {
            Console.WriteLine("Въведете име на режисьора:");
            string name = Console.ReadLine();

            Console.WriteLine("Въведете фамилия на режисьора:");
            string surname = Console.ReadLine();

            Console.WriteLine("Въведете трудов стаж (в години) на режисьора:");
            int yearswork = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете телефон за контакт на режисьора:");
            string phone = Console.ReadLine();

            Console.WriteLine("Въведете имейл на режисьора:");
            string email = Console.ReadLine();

            List<Film> filmsOtDirector = new List<Film>();
            Director director = new Director(name, surname, yearswork, phone, email, filmsOtDirector);
            directors.Add(director);
        }

        static void AddFilm()
        {
            Console.WriteLine("Въведете името на студиото на филма от тези, които са в Studios:");
            string nameStudio = Console.ReadLine();
            Studio studioPoIme = studios.FirstOrDefault(s => s.Name == nameStudio);

            Console.WriteLine("Въведете името на режисьора на филма от тези, които са в Directors:");
            string nameDirector = Console.ReadLine();
            Director directorPoIme = directors.FirstOrDefault(s => s.Name == nameDirector);

            Console.WriteLine("Въведете заглавие на филма:");
            string title = Console.ReadLine();

            Console.WriteLine("Въведете сценарист на филма:");
            string author = Console.ReadLine();

            Console.WriteLine("Въведете година на излизане на филма:");
            int year_published = int.Parse(Console.ReadLine());

            Film film = new Film(studioPoIme, directorPoIme, title, author, year_published);
            films.Add(film);
        }

        static void AddActor()
        {
            Console.WriteLine("Въведете име на актьора:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Въведете фамилия на актьора:");
            string surnamename = Console.ReadLine();

            Console.WriteLine("Въведете трудов стаж (в години) на актьора:");
            int yearswork = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете телефон за контакт на актьора:");
            string phone = Console.ReadLine();

            Console.WriteLine("Въведете имейл на актьора:");
            string email = Console.ReadLine();

            Actor actor = new Actor(firstname, surnamename, yearswork, phone, email);
            actors.Add(actor);
        }

        static void AddFilmInDirector()
        {
            Console.WriteLine("Въведете името на режисьора на филма от тези, които са в Directors:");
            string nameDirector = Console.ReadLine();
            Director directorPoIme = directors.FirstOrDefault(s => s.Name == nameDirector);

            Console.WriteLine("Въведете името на филма от тези, които са в Films:");
            string nameFilm = Console.ReadLine();
            Film filmPoIme = films.FirstOrDefault(s => s.Title == nameFilm);

            directorPoIme.AddFilm(filmPoIme);
        }

        static void AddFilmInStudio()
        {
            Console.WriteLine("Въведете името на студиото на филма от тези, които са в Studios:");
            string nameStudio = Console.ReadLine();
            Studio studioPoIme = studios.FirstOrDefault(s => s.Name == nameStudio);

            Console.WriteLine("Въведете името на филма от тези, които са в Films:");
            string nameFilm = Console.ReadLine();
            Film filmPoIme = films.FirstOrDefault(s => s.Title == nameFilm);
            studioPoIme.AddFil(filmPoIme);
        }

        static void AllStudios()
        {
            foreach (var studio in studios)
            {
                Console.WriteLine(studio.Name);
            }
        }

        static void AllDirector()
        {
            foreach(var director in directors)
            {
                Console.WriteLine(director.Name);
            }
        }

        static void AllFilms() 
        {
            foreach (var item in films)
            {
                Console.WriteLine(item.Title);
            }
        }

        static void AllActors()
        {
            foreach (var item in actors)
            {
                Console.WriteLine(item.Name);
            }
        }

        static void FilmsNaDirector()
        {
            Console.WriteLine("Въведете името на режисьора на филма от тези, които са в Directors:");
            string nameDirector = Console.ReadLine();
            Director directorPoIme = directors.FirstOrDefault(s => s.Name == nameDirector);
            foreach (var film in directorPoIme.Films)
            {
                Console.WriteLine(film.Title);
            }
        }

        static void FilmsNaStudio()
        {
            Console.WriteLine("Въведете името на студиото на филма от тези, които са в Studios:");
            string nameStudio = Console.ReadLine();
            Studio studioPoIme = studios.FirstOrDefault(s => s.Name == nameStudio);

            foreach (var item in studioPoIme.Films)
            {
                Console.WriteLine(item.Title);
            }
        }

        static void TheBestStudio()
        {
            Studio studio=studios.OrderByDescending(s => s.BrFilmi).First();
            Console.WriteLine(studio.Name);
        }
    }
}
