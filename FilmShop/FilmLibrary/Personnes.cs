using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary
{
    public class Personnes
    {
        private int idPersonne;
        private string nomPersonne;
        private string prenomPersonne;
        private DateTime dateNaissancePersonne;
        private string adressePersonne;
        private string villePersonne;
        private string codePostal;
        private int taillePersonne;
        private int poidPersonne;

        public Personnes()
        {
        }

        public Personnes(string nomPersonne, string prenomPersonne, DateTime dateNaissancePersonne, string adressePersonne, string villePersonne, string codePostal)
        {
            NomPersonne = nomPersonne;
            PrenomPersonne = prenomPersonne;
            DateNaissancePersonne = dateNaissancePersonne;
            AdressePersonne = adressePersonne;
            VillePersonne = villePersonne;
            CodePostal = codePostal;
        }

        public Personnes(int idPersonne, string nomPersonne, string prenomPersonne, DateTime dateNaissancePersonne, string adressePersonne, string villePersonne, string codePostal, int taillePersonne, int poidPersonne)
        {
            IdPersonne = idPersonne;
            NomPersonne = nomPersonne;
            PrenomPersonne = prenomPersonne;
            DateNaissancePersonne = dateNaissancePersonne;
            AdressePersonne = adressePersonne;
            VillePersonne = villePersonne;
            CodePostal = codePostal;
            TaillePersonne = taillePersonne;
            PoidPersonne = poidPersonne;
        }

        public int IdPersonne { get => idPersonne; set => idPersonne = value; }
        public string NomPersonne { get => nomPersonne; set => nomPersonne = value; }
        public string PrenomPersonne { get => prenomPersonne; set => prenomPersonne = value; }
        public DateTime DateNaissancePersonne { get => dateNaissancePersonne; set => dateNaissancePersonne = value; }
        public string AdressePersonne { get => adressePersonne; set => adressePersonne = value; }
        public string VillePersonne { get => villePersonne; set => villePersonne = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public int TaillePersonne { get => taillePersonne; set => taillePersonne = value; }
        public int PoidPersonne { get => poidPersonne; set => poidPersonne = value; }

        public int Age
        {
            get
            {

                int age = DateTime.Now.Year - DateNaissancePersonne.Year;
                DateTime dateAnniversaire =
                    new DateTime(
                        DateTime.Now.Year,
                        DateNaissancePersonne.Month,
                        DateNaissancePersonne.Day);

                if (dateAnniversaire >= DateTime.Now)
                {
                    age--;
                }

                return age;
            }
        }

        public string NomComplet { get => NomPersonne + " " + PrenomPersonne; }

        public string SePresenter()
        {
            string presentation = "Bonjour je m'appelle " + NomComplet + ". J'ai " + Age + " ans. J'habite à " + VillePersonne;

            return presentation;
        }
    }
}
