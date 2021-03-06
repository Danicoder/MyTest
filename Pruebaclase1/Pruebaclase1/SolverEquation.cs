﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebaclase1
{
    class SolverEquation
    {
        public static double SolverEquation2(double a, double b, double c)
        {
            double aux, aux2, x;

            aux = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux);
            x = (-b + aux2) / (2.0 * a);
            return x;
        }
        public static double SolverEquation1(double a, double b)
        {
            return -b / a;
        }
    }
}
