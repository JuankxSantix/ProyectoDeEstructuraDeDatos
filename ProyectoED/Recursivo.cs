using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED
{
    public class Recursivo
    {
        public int Fac(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }
    }
}
