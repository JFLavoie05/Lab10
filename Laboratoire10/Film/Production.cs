using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Production
    {
        static void Main(string[] args)
        {
            //FILM 1

            Catalogue catalogue1 = new Catalogue();
            List<string> acteursFilm1 = new List<string>();
            List<string> genresFilm1 = new List<string>();
            acteursFilm1.Add("Harrisond Ford");
            acteursFilm1.Add("Mark Hamill");
            acteursFilm1.Add("Carrie Fisher");
            genresFilm1.Add("Sci-Fi");
            genresFilm1.Add("Love");
            genresFilm1.Add("Space");

            Film film1 = new Film("Star Wars", "George Lucas", "1977", acteursFilm1, "Une guerre dans les étoiles", genresFilm1);
            catalogue1.AjouterFilm(film1);

            //FILM 2

            List<string> acteursFilm2 = new List<string>();
            List<string> genresFilm2 = new List<string>();
            acteursFilm2.Add("Leonardo DiCaprio");
            acteursFilm2.Add("Tom Hardy");
            acteursFilm2.Add("Cillian Murphy");
            genresFilm2.Add("Action");
            genresFilm2.Add("Braquage");
            genresFilm2.Add("Drame");

            Film film2 = new Film("Inception", "Christopher Nolan", "2010", acteursFilm2, "Time heist", genresFilm2);
            catalogue1.AjouterFilm(film2);

            catalogue1.AfficherFilm();
        }

        
    }
}
