﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_4_Interpolation
{
    class Approximator
    {
        //Points and function values
        readonly double[] _p;
        readonly double[] _fp;

        //Coefficients for Lagrange polynomial
        readonly double[] _l;

        //Delegates for needed parameters
        public delegate double Function(double x);
        delegate double Operation(int x);

        //Constructor
        public Approximator(double begin, double incr, int number, Function func)
        {
            _p = new double[number];
            _fp = new double[number];
            _l = new double[number];
            for (int i = 0; i < number; i++)
            {
                _p[i] = begin + incr * i;
                _fp[i] = func(_p[i]);
            }
            for (int i = 0; i < number; i++)
                _l[i] = _fp[i] / Product(Enumerable.Range(0, _p.Length).
                  Where(j => j != i), j => _p[i] - _p[j]);
        }

        //Lagrange's formula
        public double Lp(double x)
        {
            return Enumerable.Range(0, _p.Length).Sum(i => _l[i]
             * Product(Enumerable.Range(0, _p.Length).
             Where(j => j != i), j => x - _p[j]));
        }

        //Auxiliary functions
        static double Product(IEnumerable<int> values, Operation oper)
        {
            return values.Aggregate(1D, (current, v) => current * oper(v));
        }
    }
}
