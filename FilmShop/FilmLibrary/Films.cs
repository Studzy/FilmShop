using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary
{
    public class Films
    {
        private int idFilm;
        private string titreFilm;
        private string realisateurFilm;
        private DateTime dateSortieFilm;
        private string resumeFilm;
        private string genreFilm;
        private int dureeFilm;
        private List<string> listeActeurs = new List<string>();

        public Films()
        {
        }

        public Films(string titreFilm, string realisateurFilm, DateTime dateSortieFilm, string resumeFilm, string genreFilm, int dureeFilm)
        {
            TitreFilm = titreFilm;
            RealisateurFilm = realisateurFilm;
            DateSortieFilm = dateSortieFilm;
            ResumeFilm = resumeFilm;
            GenreFilm = genreFilm;
            DureeFilm = dureeFilm;
        }

        public Films(int idFilm, string titreFilm, string realisateurFilm, DateTime dateSortieFilm, string resumeFilm, string genreFilm, int dureeFilm)
        {
            IdFilm = idFilm;
            TitreFilm = titreFilm;
            RealisateurFilm = realisateurFilm;
            DateSortieFilm = dateSortieFilm;
            ResumeFilm = resumeFilm;
            GenreFilm = genreFilm;
            DureeFilm = dureeFilm;
        }

        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string TitreFilm { get => titreFilm; set => titreFilm = value; }
        public string RealisateurFilm { get => realisateurFilm; set => realisateurFilm = value; }
        public DateTime DateSortieFilm { get => dateSortieFilm; set => dateSortieFilm = value; }
        public string ResumeFilm { get => resumeFilm; set => resumeFilm = value; }
        public string GenreFilm { get => genreFilm; set => genreFilm = value; }
        public int DureeFilm { get => dureeFilm; set => dureeFilm = value; }

    }
}
