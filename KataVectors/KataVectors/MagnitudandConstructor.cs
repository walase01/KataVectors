using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataVectors
{
    public class MagnitudandConstructor
    {
        public MagnitudandConstructor()
        {

        }

        public double DetMagnitud(double[] vect1)
        {

            double multiplicacion = 0;
            double sumatoria = 0;

            for(int i = 0; i < vect1.Length; i++)
            {
                multiplicacion = vect1[i] * vect1[i];
                sumatoria += multiplicacion;
            }
            return Math.Round(Math.Sqrt(sumatoria),3);
        }
    }
}
