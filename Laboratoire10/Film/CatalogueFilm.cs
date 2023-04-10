using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    partial class Catalogue
    {

        public Film RechercherParTitre(string titre)
        {
            for (int i = 0; i < films.Count; i++)
            {
                if (titre == films[i].Titre)
                {
                    return films[i];
                }
            }
            return films[16];
        }

        public Film RechercherParActeur(string acteur)
        {
            for (int i = 0; i < films.Count; i++)
            {
                for (int j = 0; j > films[i].Acteurs.Count; j++)
                {
                    if (acteur == films[i].Acteurs[j])
                    {
                        return films[i];
                    }
                }
                
            }
            return films[16];
        }
    }
}
