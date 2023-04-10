using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    partial class Vaisseau
    {

        public void Decollage(int coordonne, string dateDepart)
        {
            if (Orbite == true)
            {
                throw new Exception("Le vaisseau est déja en orbite");
            }
            else
            {
                Orbite = false;
                Console.WriteLine("Le vaisseau est dans l'espace");
            }
        }

        public void ChangerVitesse(int nouvelleVitesse)
        {
            if (nouvelleVitesse > VitesseMax)
            {
                throw new Exception("La vitesse demandé dépasse la vitesse maximale du vaisseau");
            }
            else
            {
                VitesseActuelle = nouvelleVitesse;
            }    
        }
    }
}
