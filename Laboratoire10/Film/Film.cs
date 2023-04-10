using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    partial class Film
    {
        public string Titre { get; set; }
        public string Directeur { get; set; }
        public string Annee { get; set; }
        public List<string> Acteurs { get; set; }

        public Film(string titre, string directeur, string annee, List<string> acteurs, string synopsis, List<string> genres )
        {
            Titre = titre;
            Directeur = directeur;
            Annee = annee;
            Acteurs = acteurs;
            Synopsis = synopsis;
            Genres = genres;
        }

        
        
    }
}
