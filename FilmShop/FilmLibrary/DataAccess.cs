using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FilmLibrary
{
    public class DataAccess
    {
        public const string CHEMINBDD = "SERVER=127.0.0.1; DATABASE=bdd_boutique; UID=root; PASSWORD=;";
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
    }
}
