using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire10
{
    class Calculatrice
    {
        

        public int Diviser(int nb1, int nb2)
        {
            return nb1 / nb2;
        }

        public int Multiplier(int nb1, int nb2)
        {
            checked
            {
                return nb1 * nb2;
            }
        }
    }
}
