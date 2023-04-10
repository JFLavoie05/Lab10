using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    partial class Vaisseau
    {
        public string Nom { get; set; }
        public int Capacite { get; set; }
        public int VitesseActuelle { get; set; }
        public int VitesseMax { get; set; }
        public bool Orbite { get; set; }

        public Vaisseau(string nom, int capacite, int vitesseActuelle, int vitesseMax, bool orbite)
        {
            Nom = nom;
            Capacite = capacite;
            VitesseActuelle = vitesseActuelle;
            VitesseMax = vitesseMax;
            Orbite = orbite;
        }
    }
}
