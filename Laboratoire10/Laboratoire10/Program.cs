using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire10
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            Calculatrice calcul1 = new Calculatrice();

            Console.WriteLine($"Entrez le premier entier");
            nb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Entrez le deuxième entier");
            nb2 = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                Console.WriteLine($"La réponse est : {calcul1.Diviser(nb1, nb2)}");
                Console.WriteLine($"La réponse est : {calcul1.Multiplier(nb1, nb2)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }
            
        }
    }
}
