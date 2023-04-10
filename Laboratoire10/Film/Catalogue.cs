using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    partial class Catalogue
    {
        List<Film> films = new List<Film>();



        public void AjouterFilm(Film film)
        {
            films.Add(film);
        }

        public void SupprimerFilm(Film film)
        {
            films.Remove(film);
        }

        public void AfficherFilm()
        {
            for (int i = 0; i < films.Count; i++)
            {
                Console.WriteLine($"Titre : {films[i].Titre} \nDirecteur : {films[i].Directeur} \nAnnée : {films[i].Annee} \nSynopsis : {films[i].Synopsis} \nActeurs :");
                for (int j = 0; j < films[i].Acteurs.Count; j++)
                {
                    Console.WriteLine($"            {films[i].Acteurs[j]}");
                }
                Console.WriteLine("Genres :");
                for (int k = 0; k < films[i].Genres.Count; k++)
                {
                    Console.WriteLine($"            {films[i].Genres[k]}");
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
