using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
namespace TP2_SIM.Generadores.Uniforme
{
    public class DistribucionUnirme
    {
        public int N { get; set; }
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public int CantidadIntervalos { get; set; }        
        public Chart Grafico { get; set; }        
        public List<double> NumerosUniformes { get; set; }

        private Random rnd = new Random();

        public DistribucionUnirme()
        {
            this.NumerosUniformes = new List<double>();
        }

        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }

        public void GenerarDistribucionUniforme()
        {
            if(Desde < Hasta)
            {
                for(int i = 0; i < N; i++) 
                {
                    double rnd = GenerarAleatorio();
                    double rndUniforme = GenerarDistribucionUniforme(Desde, Hasta, rnd);
                    double filtroRndUniforme = Math.Truncate(rndUniforme * 100000) / 100000;

                    NumerosUniformes.Add(filtroRndUniforme);
                }
            }
            else
            {
                MessageBox.Show("El valor Desde debe ser mayor al valor de Hasta", "Distribución Uniforme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double GenerarDistribucionUniforme(double A, double B, double RND)
        {
            return A + RND * (B-A);
        }

        public List<(string etiqueta, int frecuencia)> GenerarGrafico(int nuevaCantidadIntervalos)
        {
            Grafico.Series.Clear();

            double limInferior = 0;
            double limSuperior= 0;
            CantidadIntervalos = nuevaCantidadIntervalos;


            double valorMaximo = NumerosUniformes.Max();
            double valorMinimo= NumerosUniformes.Min();

            double anchoDeIntervalo = ((valorMaximo - valorMinimo) / CantidadIntervalos);

            var datosGrafico = new List<(string etiqueta, int frecuencia)>();
            for (int i = 0; i < CantidadIntervalos; i++)
            {
                double limiteInferior = valorMinimo + (i * anchoDeIntervalo);
                double limiteSuperior = limiteInferior + anchoDeIntervalo;
                string etiquetaIntervalo = $"{limiteInferior:0.0000} - {limiteSuperior:0.0000}";

                int frecuenciaObservada = DeterminarFrecuenciaObservada(NumerosUniformes, limiteInferior, limiteSuperior);
                datosGrafico.Add((etiquetaIntervalo, frecuenciaObservada));

                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY(etiquetaIntervalo, frecuenciaObservada);
            }

            return datosGrafico;

        }
        public int DeterminarFrecuenciaObservada(List<double> ListaDatos, double limite_inferior, double limite_superior)
        {
            int frecuenciaObservada = 0;

            foreach (double valor in ListaDatos)
            {
                if (limite_inferior <= valor && valor < limite_superior)
                {
                    frecuenciaObservada++;
                }
            }

            return frecuenciaObservada;
        }
        public void ActualizarGrafico(int nuevaCantidadIntervalos)
        {
            CantidadIntervalos = nuevaCantidadIntervalos;
            Grafico.Series.Clear();
            GenerarGrafico(CantidadIntervalos);
        }
    }
}

