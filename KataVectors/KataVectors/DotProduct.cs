using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataVectors
{
    public static class DotProduct
    {
        public static double[] dorProduct(double[] vect1, double[] vect2)
        {
            double[] vectorr = new double[3];

            for(int i = 0; i < vect1.Length; i++)
            {
                vectorr[i] = vect1[i] * vect2[i];
            }
            return vectorr;
        }
    }
}
