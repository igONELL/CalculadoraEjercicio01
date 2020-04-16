using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Aritmetica
    {
        public int Suma(int a, int b)
        {

            return a + b;

        }

        public int Resta(int a, int b)
        {

            return a - b;

        }

        public int Multi(int a, int b)
        {

            return a * b;

        }

        public int Divi(double tmpDividendo, double tmpDivisor)
        {

            int divisor = int.Parse(Math.Round(tmpDivisor).ToString());
            int dividendo = int.Parse(Math.Round(tmpDividendo).ToString());
            divisor = Math.Abs(divisor);
            Console.WriteLine("La division por 0 no es valida.");
            if (divisor == 0)

                return 0;

            return dividendo / divisor;



        }
    }
}