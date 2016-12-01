using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_4_Interpolation
{
    static class LP
    {
        private static double __fraction(double x, int i, double[] __x, double[] __y) 
        {
            double num = 1, denum = 1;
            for (int k = 0; k < __x.Length ; k++)
                if (k != i) num *= (x - __x[k]);

            for (int k = 0; k < __x.Length; k++)
                if (k != i) denum *= (__x[i] - __x[k]);

            return num / denum;
        }

        public static double fi(double X,double[] x,double[] y)
        {
            double sum = 0;
            for( int i = 0; i < y.Length ; i++ )
            sum += y[i] * __fraction(X, i, x, y);
            return sum;
        }
    }
}
