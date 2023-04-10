using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    class Planete
    {
        public string Nom { get; set; }
        public int Taille { get; set; }
        public int DistanceTerre { get; set; }
        public bool AtmosphereViable { get; set; }
        public bool Explore { get; set; }

        public Planete(string nom, int taille, int distanceTerre, bool atmosphereViable)
        {
            Nom = nom;
            Taille = taille;
            DistanceTerre = distanceTerre;
            AtmosphereViable = atmosphereViable;
        }

        public void VerifierPlanete()
        {
            if(Explore == true)
            {
                throw new Exception("Cette planête a déja été exploré");
            }
            else
            {
                Console.WriteLine("Cette planête est maintenant exploré");
            }
        }
    }
}
