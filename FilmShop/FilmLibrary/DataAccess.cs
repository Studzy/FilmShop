using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FilmLibrary
{
    public class DataAccess
    {
        public const string CHEMINBDD = "SERVER=127.0.0.1; DATABASE=controle_film_shop; UID=root; PASSWORD=;";

        #region Test connexion BDD
        public static bool TestConnexionBDD(string CheminBDD)
        {
            bool resultat = false;
            try
            {
                using (MySqlConnection db =
                new MySqlConnection(CheminBDD))
                {
                    db.Open();
                    resultat = true;
                }
                return resultat;
            }

            catch (Exception)
            {
                return resultat;
            }


        }
        #endregion

        #region AddFilm
        public static void AddFilm(Films films)
        {
            try
            {
                using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
                {
                    db.Open();
                    MySqlCommand insertCommand = new MySqlCommand();
                    insertCommand.Connection = db;
                    insertCommand.CommandText = ("INSERT INTO film (titre_film, realisateur_film, date_sortie_film, resume_film, genre_film, duree_film) VALUES (@titre, @realisateur, @dateSortie, @resume, @genre, @duree)");
                    insertCommand.Parameters.AddWithValue("@Nom_Produit", films.TitreFilm);
                    insertCommand.Parameters.AddWithValue("@TVA", films.RealisateurFilm);
                    insertCommand.Parameters.AddWithValue("@Prix_Produit", films.DateSortieFilm);
                    insertCommand.Parameters.AddWithValue("@Remise_Produit", films.ResumeFilm);
                    insertCommand.Parameters.AddWithValue("@Description_Produit", films.GenreFilm);
                    insertCommand.Parameters.AddWithValue("@ValNutrition_Produit", films.DureeFilm);
                    insertCommand.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
        #endregion

        #region AddPersonnes

        public static void AddPersonnes(Personnes personnes)
        {
            try
            {
                using (MySqlConnection db = new MySqlConnection(CHEMINBDD))
                {
                    db.Open();
                    MySqlCommand insertCommand = new MySqlCommand();
                    insertCommand.Connection = db;
                    insertCommand.CommandText = ("INSERT INTO personne (nom_personne, prenom_personne, date_naissance_personne, adresse_personne, ville_personne, cp_personne, taille_personne, poids_personne) VALUES (@nom, @prenom, @dateNaissance, @adresse, @ville, @cp, @taille, @poids)");
                    insertCommand.Parameters.AddWithValue("@nom", personnes.NomPersonne);
                    insertCommand.Parameters.AddWithValue("@prenom", personnes.PrenomPersonne);
                    insertCommand.Parameters.AddWithValue("@dateNaissance", personnes.DateNaissancePersonne);
                    insertCommand.Parameters.AddWithValue("@adresse", personnes.AdressePersonne);
                    insertCommand.Parameters.AddWithValue("@ville", personnes.VillePersonne);
                    insertCommand.Parameters.AddWithValue("@cp", personnes.CodePostal);
                    insertCommand.Parameters.AddWithValue("@taille", personnes.TaillePersonne);
                    insertCommand.Parameters.AddWithValue("@poids", personnes.PoidPersonne);
                    insertCommand.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
        #endregion

        #region GetAllfilms
        public static List<Films> GetAllFilms()
        {
            List<Films> entries = new List<Films>();
            try
            {
                using (MySqlConnection db =
                new MySqlConnection(CHEMINBDD))
                {
                    db.Open();
                    MySqlCommand selectCommand = new MySqlCommand
                        ("SELECT * FROM film", db);

                    MySqlDataReader query = selectCommand.ExecuteReader();

                    while (query.Read())
                    {
                        Films films = new Films();
                        films.IdFilm = query.GetInt32(0);
                        films.TitreFilm = query.GetString(1);
                        films.RealisateurFilm = query.GetString(2);
                        films.DateSortieFilm = query.GetDateTime(3);
                        films.ResumeFilm = query.GetString(4);
                        films.GenreFilm = query.GetString(5);
                        films.DureeFilm = query.GetInt32(6);
                        entries.Add(films);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            return entries;
        }
        #endregion

        public static List<Personnes> GetAllPersonnes()
        {
            List<Personnes> entries = new List<Personnes>();
            try
            {
                using (MySqlConnection db =
                new MySqlConnection(CHEMINBDD))
                {
                    db.Open();
                    MySqlCommand selectCommand = new MySqlCommand
                        ("SELECT * FROM personne", db);

                    MySqlDataReader query = selectCommand.ExecuteReader();

                    while (query.Read())
                    {
                        Personnes personnes = new Personnes();
                        personnes.IdPersonne = query.GetInt32(0);
                        personnes.NomPersonne = query.GetString(1);
                        personnes.PrenomPersonne = query.GetString(2);
                        personnes.DateNaissancePersonne = query.GetDateTime(3);
                        personnes.AdressePersonne = query.GetString(4);
                        personnes.VillePersonne = query.GetString(5);
                        personnes.CodePostal = query.GetString(6);
                        if (!DBNull.Value.Equals(query.GetValue(7)))
                        {
                            personnes.TaillePersonne = query.GetInt32(7);
                        }
                        else
                        {
                            personnes.TaillePersonne = 0;
                        }
                        if (!DBNull.Value.Equals(query.GetValue(8)))
                        {
                            personnes.PoidPersonne = query.GetInt32(8);
                        }
                        else
                        {
                            personnes.PoidPersonne = 0;
                        }
                        entries.Add(personnes);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            return entries;
        }
    }
}
