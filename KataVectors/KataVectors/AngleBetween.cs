using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataVectors
{
    public static class AngleBetween
    {
        public static double angle_between(double[] vect1, double[] vect2)
        {
            MagnitudandConstructor magnitud = new MagnitudandConstructor();

            double multiplicacion = 0;
            double sumatoria = 0;

            double respuesta = 0;

            for(int i = 0; i < 3; i++)
            {
                multiplicacion = vect1[i] * vect2[i];
                sumatoria += multiplicacion;
            }

            multiplicacion = magnitud.DetMagnitud(vect1) * magnitud.DetMagnitud(vect2);

            respuesta = sumatoria / multiplicacion;

            return Math.Round(respuesta,3);
        }
    }
}
