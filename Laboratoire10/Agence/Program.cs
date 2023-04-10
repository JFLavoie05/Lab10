using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaisseau vaisseau1 = new Vaisseau("Pogba", 5, 10, 15, false);

            vaisseau1.Decollage(2, "2020-02-10");
        }
    }
}
