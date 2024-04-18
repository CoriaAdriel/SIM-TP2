using System;
using System.Collections.Generic;
namespace TP2_SIM.Generadores.Uniforme
{
    public class DistribucionUnirme
    {
        // Atributo de la Clase
        private static Random random = new Random();

        public static List<double> GenerarNumeroUniforme(int cantidad, int a, int b)
        {
            List<double> numerosUniformes = new List<double>();

            for(int i = 0; i< cantidad; i++)
            {
                double rnd = random.NextDouble(); // Nos permite generar un número entre [0,1)
                double x = AplicarFormulaUniforme(rnd, a, b);
                numerosUniformes.Add(x);
            }
            return numerosUniformes;
        }

        private static double AplicarFormulaUniforme(double rnd, int a, int b)
        {
            return a + rnd * (b - a);
        }

    }
}
