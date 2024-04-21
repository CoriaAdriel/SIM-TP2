using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Collections;

namespace TP2_SIM.Distribuciones
{
    internal class Normal
    {
        public int CantidadMuestra { get; set; }
        public double Desviacion { get; set; }
        public double Media { get; set; }
        public int CantidadIntervalos { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView Grilla { get; set; }

        private List<double> Datos = new List<double>();

        private Random rnd = new Random();

        public double GenerarAleatorio()
        {
            //Genera numeros aleatorios entre 0 y 1 sin llegar a 1
            return rnd.NextDouble();
        }

        public void GenerarDistribucion()
        {
            //Usamos el metodo de Box-Muller, por lo que necesitamos generar 2 randoms a la vez

            double random;
            double random2;
            double variableAleatoria1;
            double variableAleatoria2;

            for (int i = 0; i < CantidadMuestra; i += 2)
            {
                random = GenerarAleatorio();
                random2 = GenerarAleatorio();

               variableAleatoria1 = Media + ((Math.Sqrt(-2 * Math.Log(random)) * Math.Cos(2 * Math.PI * random2)) * Desviacion);
               variableAleatoria2 = Media + ((Math.Sqrt(-2 * Math.Log(random)) * Math.Sin(2 * Math.PI * random2)) * Desviacion);


                double variableAleatoriaTruncada1 = Math.Truncate(variableAleatoria1 * 10000) / 10000;
                Datos.Add(variableAleatoriaTruncada1);
                double variableAleatoriaTruncada2 = Math.Truncate(variableAleatoria2 * 10000) / 10000;
                Datos.Add(variableAleatoriaTruncada2);

            }

            GenerarHistograma();
            //Agregamos la lista de variables generadas al DataGridView para poder visualizarlos
            CargarGrillaDatos(Datos);

        }

        public void CargarGrillaDatos(List<double> Datos)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            Grilla.Columns.Add("ColumaVariablesGeneradas", "Variables Generadas");
            for (int i = 0; i < Datos.Count(); i++)
            {
                Grilla.Rows.Add(Datos[i]);
            }
        }

        public void GenerarHistograma()
        {

            Grafico.Series.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double amplitud = ((valorMaximo - valorMinimo) / CantidadIntervalos) + precision;

            int frecuenciaObservada = 0;
            double frecuenciaEsperada = 0;
            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;
            double marcaClase = 0;

            for (int i = 0; i < CantidadIntervalos; i++)
            {
                //Calculamos el primer Intervalo del Histograma y apartir de este generamos el resto

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + amplitud;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada = frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase);
                    frecuenciaEsperadaAcumulada = frecuenciaEsperada;

                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + amplitud;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada += frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase);
                    frecuenciaEsperadaAcumulada += frecuenciaEsperada;

                }

                //Generamos las etiquetas para el histograma
                string etiquetaInferiorIntervalo = (Math.Truncate(limiteInferior * 10000) / 10000).ToString();
                string etiquetaSuperiorIntervalo = (Math.Truncate(limiteSuperior * 10000) / 10000).ToString();
                string etiquetaIntervalo = etiquetaInferiorIntervalo + " - " + etiquetaSuperiorIntervalo;

                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY("Intervalos", frecuenciaObservada);

            }

        }

        public int DeterminarFrecuenciaObservada(List<double> ListaDatos, double limite_inferior, double limite_superior)
        {

            int frecuenciaObservada = 0;

            foreach (double valor in ListaDatos)
            {
                if (limite_inferior <= valor && valor <= limite_superior)
                {
                    frecuenciaObservada++;
                }
            }

            return frecuenciaObservada;
        }

        public double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior, double marcaClase)
        {
            double frecuenciaEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior, marcaClase)* CantidadMuestra;
            return frecuenciaEsperada;
        }

        public double CalcularProbabilidadEsperada(double limiteInferior, double limiteSuperior, double marcaClase)
        {
            //Usamos el calculo de la densidad para distribucion Normal
            double probabilidadEsperada = ((Math.Exp(-0.5 * (Math.Pow(((marcaClase - Media) / Desviacion), 2)))) / (Desviacion * Math.Sqrt(2 * Math.PI))) * (limiteSuperior - limiteInferior);
            return probabilidadEsperada;
        }

    }

}
