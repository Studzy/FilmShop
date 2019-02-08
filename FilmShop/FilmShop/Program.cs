using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary;

namespace FilmShop
{
    class Program
    {
        static void Main(string[] args)
        {
            AddFilm();
        }

        #region Affiche les films
        public static void AfficheLesFilms()
        {
            List<Films> films = DataAccess.GetAllFilms();
            Console.WriteLine("Nous avons {0} film(s) :", films.Count);
            foreach (var film in films)
            {
                Console.WriteLine("ID = " + film.IdFilm + "\n Titre = " + film.TitreFilm + "\n Realisateur = " + film.RealisateurFilm + "\n Date sortie = " + film.DateSortieFilm + "\n Resume = " + film.ResumeFilm + "\n Genre = " + film.GenreFilm + "\n Durée = " + film.DureeFilm + "\n\n");
            }
        }
        #endregion

        #region Affiche les personnes
        public static void AfficheLesPersonnes()
        {
            List<Personnes> personnes = DataAccess.GetAllPersonnes();
            Console.WriteLine("Nous avons {0} personne(s) :", personnes.Count);
            foreach (var personne in personnes)
            {
                Console.WriteLine("ID = " + personne.IdPersonne + "\n Nom = " + personne.NomPersonne + "\n Prenom = " + personne.PrenomPersonne + "\n Date de naissance = " + personne.DateNaissancePersonne + "\n Adresse = " + personne.AdressePersonne + "\n ville = " + personne.VillePersonne + "\n Code Postal = " + personne.CodePostal + "\n Taille = " + personne.TaillePersonne + "\n Poids = " + personne.PoidPersonne + "\n\n");
            }
        }
        #endregion



        #region Add film
        public static void AddFilm()
        {
            Films films = new Films();
            Console.Write("Titre : ");
            films.TitreFilm = Console.ReadLine();
            Console.Write("Realisateur : ");
            films.RealisateurFilm = Console.ReadLine();
            Console.Write("Date sortie (YYYY/MM/DD): ");
            string Date = Console.ReadLine();
            films.DateSortieFilm = Convert.ToDateTime(Date);
            Console.Write("Resumé : ");
            films.ResumeFilm = Console.ReadLine();
            Console.Write("Genre : ");
            films.GenreFilm = Console.ReadLine();
            Console.Write("Durée : ");
            films.DureeFilm = Convert.ToInt32(Console.ReadLine());

            DataAccess.AddPersonnes(films);
        }
        #endregion

        #region Add personne

        public static void AddPersonne()
        {
            Console.WriteLine("Creer une personne : \n");
            Personnes personnes = new Personnes();
            Console.Write("Nom : ");
            personnes.NomPersonne = Console.ReadLine();
            Console.Write("Prenom : ");
            personnes.PrenomPersonne = Console.ReadLine();
            Console.Write("Date de naissance (YYYY/MM/DD): ");
            string Date = Console.ReadLine();
            personnes.DateNaissancePersonne = Convert.ToDateTime(Date);
            Console.Write("Adresse (n° rue + nom de rue): ");
            personnes.AdressePersonne = Console.ReadLine();
            Console.Write("Ville : ");
            personnes.VillePersonne = Console.ReadLine();
            Console.Write("Code postal : ");
            personnes.CodePostal = Console.ReadLine();
            Console.Write("taille : ");
            personnes.TaillePersonne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Poids : ");
            personnes.PoidPersonne = Convert.ToInt32(Console.ReadLine());

            DataAccess.AddPersonnes(personnes);
        }

        #endregion

        #region InitProgramme
        public static void InitProgramme()
        {
            AddFilm();
            AddPersonne();
        }
        #endregion


    }
}
