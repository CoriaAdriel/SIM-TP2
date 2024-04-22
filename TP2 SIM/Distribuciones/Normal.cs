using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP2_SIM.Distribuciones
{
    public class Normal
    {
        // Atributos de la clase
        public int CantidadMuestra { get; set; }
        public double Desviacion { get; set; }
        public double Media { get; set; }
        public int CantidadIntervalos { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView PruebaChi { get; set; }
        public DataGridView PruebaKS { get; set; }
        public DataGridView Grilla { get; set; }

        private List<double> Datos = new List<double>();

        private Random rnd = new Random();


        /// Nos permite generar números randoms entre RND[0,1)
        public double GenerarAleatorio()
        {
            //Genera numeros aleatorios entre 0 y 1 sin llegar a 1
            return rnd.NextDouble();
        }

        /// Nos permite generar la distribución utilizando el método de Box-Muller
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
            CalcularKS();
            //Agregamos la lista de variables generadas al DataGridView para poder visualizarlos
            CargarGrillaDatos(Datos);

        }

        /// Nos permite representar los datos generados de forma Normal en la grilla de muestra.
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

        /// Nos permite generar el Gráfico de la Normal.
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

        /// Nos permite calcular el valor de K-S
        public void CalcularKS()
        {
            PruebaKS.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double amplitud = ((valorMaximo - valorMinimo) / CantidadIntervalos) + precision;
            double marcaClase = 0;

            double frecuenciaObservada = 0;
            double frecuenciaEsperada = 0;
            double probabilidadObservada = 0;
            double probabilidadObservadaAcumulada = 0;
            double probabilidadEsperada = 0;
            double probabilidadEsperadaAcumulada = 0;
            double calcKS = 0;
            double maxKSAnterior = 0;
            double maxXS = 0;

            for (int i = 0; i < CantidadIntervalos; i++)
            {
                //Calculamos el primer Intervalo y apartir de este generamos el resto

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + amplitud;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase);

                    probabilidadObservada = (frecuenciaObservada / CantidadMuestra);
                    probabilidadObservadaAcumulada = probabilidadObservada;
                    probabilidadEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior, marcaClase);
                    probabilidadEsperadaAcumulada = probabilidadEsperada;
                    calcKS = Math.Abs(probabilidadObservadaAcumulada - probabilidadEsperadaAcumulada);
                    maxXS = calcKS;

                    maxKSAnterior = maxXS;
                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + amplitud;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase);

                    probabilidadObservada = frecuenciaObservada / CantidadMuestra;
                    probabilidadObservadaAcumulada += probabilidadObservada;
                    probabilidadEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior, marcaClase);
                    probabilidadEsperadaAcumulada += probabilidadEsperada;
                    calcKS = Math.Abs(probabilidadObservadaAcumulada - probabilidadEsperadaAcumulada);
                    maxXS = Math.Max(maxKSAnterior, calcKS);

                    maxKSAnterior = maxXS;
                }

                //Hacemos que los valores sean de 4 decimales antes de agregarlos a la grilla
                limiteInferior = Math.Truncate(limiteInferior * 10000) / 10000;
                limiteSuperior = Math.Truncate(limiteSuperior * 10000) / 10000;
                frecuenciaObservada = Math.Truncate(frecuenciaObservada * 10000) / 10000;
                frecuenciaEsperada = Math.Truncate(frecuenciaEsperada * 10000) / 10000;
                probabilidadObservadaAcumulada = Math.Truncate(probabilidadObservadaAcumulada * 10000) / 10000;
                probabilidadEsperadaAcumulada = Math.Truncate(probabilidadEsperadaAcumulada * 10000) / 10000;
                calcKS = Math.Truncate(calcKS * 10000) / 10000;
                maxXS = Math.Truncate(maxXS * 10000) / 10000;

                PruebaKS.Rows.Add(limiteInferior, limiteSuperior, frecuenciaObservada, frecuenciaEsperada, probabilidadObservadaAcumulada, probabilidadEsperadaAcumulada, calcKS, maxXS);
            }
            //Resalta el valor de KS final calculado
            PruebaKS.Rows[(PruebaKS.RowCount - 1)].Cells[(PruebaKS.ColumnCount - 1)].Style.BackColor = Color.Coral;
        }

        /// Nos permite calcular las frecuencia observadas.
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

        /// Nos permite calcular la frecuencia esperada.
        public double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior, double marcaClase)
        {
            double frecuenciaEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior, marcaClase)* CantidadMuestra;
            return frecuenciaEsperada;
        }

        /// Nos permite calcular la función de acumulación de la Normal(Utilizando Marca de clase).
        public double CalcularProbabilidadEsperada(double limiteInferior, double limiteSuperior, double marcaClase)
        {
            //Usamos el calculo de la densidad para distribucion Normal
            double probabilidadEsperada = ((Math.Exp(-0.5 * (Math.Pow(((marcaClase - Media) / Desviacion), 2)))) / (Desviacion * Math.Sqrt(2 * Math.PI))) * (limiteSuperior - limiteInferior);
            return probabilidadEsperada;
        }

    }

}
