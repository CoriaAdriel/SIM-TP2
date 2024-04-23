using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP2_SIM.Distribuciones
{
    public class ExponencialNegativa
    {
        // Atributos de la clase
        public double CantidadMuestra { get; set; }
        public int CantidadIntervalos { get; set; }
        public double Lambda { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView PruebaChi { get; set; }
        public DataGridView PruebaKS { get; set; }

        private List<double> Datos = new List<double>();
        public DataGridView Grilla { get; set; }

        private Random rnd = new Random();


        /// Nos permite realizar la generación de número aleatorio RND[0,1).
        public double GenerarAleatorio()
        {
            //Genera numeros aleatorios entre 0 y 1 sin llegar a 1
            return rnd.NextDouble();
        }

        /// Nos permite genera los RND de variables aleatorias exponenciales, generar el histograma, calculo de K-S y carga de grilla.
        public void GenerarDistribucion()
        {
            //Generamos la distibucion Exponencial Negativa con el metodo de la transformada inversa
            for (int i = 0; i < CantidadMuestra; i++)
            {
                double random = GenerarAleatorio();
                double variableAleatoria = (-1 / Lambda) * (Math.Log(1 - random));
                double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;

                Datos.Add(variableAleatoriaTruncada);

            }

            GenerarHistograma();
            CalcularChi();
            CalcularKS();

            //Agregamos la lista de variables generadas al DataGridView para poder visualizarlos
            CargarGrillaDatos(Datos);
        }

        /// Nos permite cargar los RND(Exponencial) en la grilla de muestra
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

        /// Nos permite realizar la generación del histograma.
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

            for (int i = 0; i < CantidadIntervalos; i++)
            {
                //Calculamos el primer Intervalo del Histograma y apartir de este generamos el resto
                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + amplitud;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada = frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    frecuenciaEsperadaAcumulada = frecuenciaEsperada;
                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + amplitud;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada += frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
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

        public void CalcularChi()
        {
            PruebaChi.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double amplitud = ((valorMaximo - valorMinimo) / CantidadIntervalos) + precision;

            double frecuenciaObservada = 0;
            double frecuenciaEsperada = 0;
            double chiCuadrado = 0;
            double chiCuadradoAcumulado = 0;

            double frecuenciaEsperadaAcumulada = 0;
            double frecuenciaObservadaAcumulada = 0;
            


            List<double> limitesInferiores = new List<double>();
            List<double> limitesSuperiores = new List<double>();
            List<double> frecuenciasObservadas = new List<double>();
            List<double> frecuenciasEsperadas = new List<double>();



            for (int i = 0; i < CantidadIntervalos; i++)
            {
                //Calculamos el primer Intervalo y apartir de este generamos el resto

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + amplitud;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    chiCuadrado = (Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2)) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;
                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + amplitud;
                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    chiCuadrado = (Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2)) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;
                }

                //Hacemos que los valores sean de 4 decimales antes de agregarlos a la grilla
                limiteInferior = Math.Truncate(limiteInferior * 10000) / 10000;
                limiteSuperior = Math.Truncate(limiteSuperior * 10000) / 10000;
                frecuenciaObservada = Math.Truncate(frecuenciaObservada * 10000) / 10000;
                frecuenciaEsperada = Math.Truncate(frecuenciaEsperada * 10000) / 10000;

                chiCuadrado = Math.Truncate(chiCuadrado * 10000) / 10000;

                limitesInferiores.Add(limiteInferior);
                limitesSuperiores.Add(limiteSuperior);
                frecuenciasObservadas.Add(frecuenciaObservada);
                frecuenciasEsperadas.Add(frecuenciaEsperada);


                if (CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior) >= 5)
                {
                    PruebaChi.Rows.Add(limiteInferior, limiteSuperior, frecuenciaObservada, frecuenciaEsperada, chiCuadrado, chiCuadradoAcumulado);
                }
                else
                {

                    if (frecuenciaEsperadaAcumulada == 0)
                    {
                        limiteInferior = limitesInferiores[i];
                    }

                    frecuenciaEsperadaAcumulada += frecuenciasEsperadas[i];
                    frecuenciaObservadaAcumulada += frecuenciasObservadas[i];

                    if (frecuenciaEsperadaAcumulada >= 5)
                    {
                         limiteSuperior = limitesSuperiores[i];
                         chiCuadrado = (Math.Pow(frecuenciaObservadaAcumulada - frecuenciaEsperadaAcumulada, 2)) / frecuenciaEsperadaAcumulada;
                         chiCuadradoAcumulado += chiCuadrado;


                         chiCuadrado = Math.Truncate(chiCuadrado * 10000) / 10000;
                         chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 1000) / 1000;

                         PruebaChi.Rows.Add(limiteInferior, limiteSuperior, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada, chiCuadrado, chiCuadradoAcumulado);
                         frecuenciaEsperadaAcumulada = 0;
                         frecuenciaObservadaAcumulada = 0;
                         limiteInferior = 0;
                    }
                    
                    if (frecuenciaObservadaAcumulada < 5 && i == CantidadIntervalos - 1)
                    {
                         double ultimaFrecuenciaObservada = Convert.ToDouble(PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[2].Value);
                         double ultimaFrecuenciaEsperada = Convert.ToDouble(PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[3].Value);

                         double nuevaFrecuenciaObservada = ultimaFrecuenciaObservada + frecuenciaObservadaAcumulada;
                         double nuevaFrecuenciaEsperada = ultimaFrecuenciaEsperada + frecuenciaEsperadaAcumulada;

                         chiCuadrado = (Math.Pow(nuevaFrecuenciaObservada - nuevaFrecuenciaEsperada, 2)) / nuevaFrecuenciaEsperada;

                         double penultimoChiAcumulado = Convert.ToDouble(PruebaChi.Rows[PruebaChi.Rows.Count - 2].Cells[5].Value);

                         chiCuadradoAcumulado = penultimoChiAcumulado + chiCuadrado;

                         chiCuadrado = Math.Truncate(chiCuadrado * 10000) / 10000;
                         chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 1000) / 1000;

                         PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[1].Value = limitesSuperiores[i];
                         PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[2].Value = nuevaFrecuenciaObservada;
                         PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[3].Value = nuevaFrecuenciaEsperada;
                         PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[4].Value = chiCuadrado;
                         PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[5].Value = chiCuadradoAcumulado;
                    }
                }
            }

                //Resalta el valor de Chi final calculado;;
                PruebaChi.Rows[(PruebaChi.RowCount - 1)].Cells[(PruebaChi.ColumnCount - 1)].Style.BackColor = Color.Coral;

            }


            /*if (CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior) < 5)
            {
                chiCuadradoAcumulado = 0;
                frecuenciaEsperadaAcumulada = 0;
                frecuenciaObservadaAcumulada = 0;


                for (int i = 0; i < CantidadIntervalos; i++)
                {
                    if (frecuenciaEsperadaAcumulada == 0)
                    {
                        limiteInferior = limitesInferiores[i];
                    }

                    frecuenciaEsperadaAcumulada += frecuenciasEsperadas[i];
                    frecuenciaObservadaAcumulada += frecuenciasObservadas[i];

                    if (frecuenciaEsperadaAcumulada >= 5)
                    {
                        limiteSuperior = limitesSuperiores[i];
                        chiCuadrado = (Math.Pow(frecuenciaObservadaAcumulada - frecuenciaEsperadaAcumulada, 2)) / frecuenciaEsperadaAcumulada;
                        chiCuadradoAcumulado += chiCuadrado;


                        chiCuadrado = Math.Truncate(chiCuadrado * 10000) / 10000;
                        chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 1000) / 1000;

                        PruebaChi.Rows.Add(limiteInferior, limiteSuperior, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada, chiCuadrado, chiCuadradoAcumulado);
                        frecuenciaEsperadaAcumulada = 0;
                        frecuenciaObservadaAcumulada = 0;
                        limiteInferior = 0;
                    }

                    if (frecuenciaObservadaAcumulada < 5 && i == CantidadIntervalos - 1)
                    {
                        double ultimaFrecuenciaObservada = Convert.ToDouble(PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[2].Value);
                        double ultimaFrecuenciaEsperada = Convert.ToDouble(PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[3].Value);

                        double nuevaFrecuenciaObservada = ultimaFrecuenciaObservada + frecuenciaObservadaAcumulada;
                        double nuevaFrecuenciaEsperada = ultimaFrecuenciaEsperada + frecuenciaEsperadaAcumulada;

                        chiCuadrado = (Math.Pow(nuevaFrecuenciaObservada - nuevaFrecuenciaEsperada, 2)) / nuevaFrecuenciaEsperada;

                        double penultimoChiAcumulado = Convert.ToDouble(PruebaChi.Rows[PruebaChi.Rows.Count - 2].Cells[5].Value);

                        chiCuadradoAcumulado = penultimoChiAcumulado + chiCuadrado;

                        chiCuadrado = Math.Truncate(chiCuadrado * 10000) / 10000;
                        chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 1000) / 1000;

                        PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[1].Value = limitesSuperiores[i];
                        PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[2].Value = nuevaFrecuenciaObservada;
                        PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[3].Value = nuevaFrecuenciaEsperada;
                        PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[4].Value = chiCuadrado;
                        PruebaChi.Rows[PruebaChi.Rows.Count - 1].Cells[5].Value = chiCuadradoAcumulado;
                    }
                }
            }

            //Resalta el valor de Chi final calculado;;
            PruebaChi.Rows[(PruebaChi.RowCount - 1)].Cells[(PruebaChi.ColumnCount - 1)].Style.BackColor = Color.Coral;

        }*/


        /// Nos permite calcular el valor de K-S.
        public void CalcularKS()
        {
            PruebaKS.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double amplitud = ((valorMaximo - valorMinimo) / CantidadIntervalos) + precision;

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

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);

                    probabilidadObservada = (frecuenciaObservada / CantidadMuestra);
                    probabilidadObservadaAcumulada = probabilidadObservada;
                    probabilidadEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior);
                    probabilidadEsperadaAcumulada = probabilidadEsperada;
                    calcKS = Math.Abs(probabilidadObservadaAcumulada - probabilidadEsperadaAcumulada);
                    maxXS = calcKS;

                    maxKSAnterior = maxXS;
                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + amplitud;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);

                    probabilidadObservada = frecuenciaObservada / CantidadMuestra;
                    probabilidadObservadaAcumulada += probabilidadObservada;
                    probabilidadEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior);
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




        /// Nos permite realizar la frecuencia observada.
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

        /// Nos permite calcular la frecuencia esparada.
        public double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior)
        {
            double frecuenciaEsperada = CalcularProbabilidadEsperada(limiteInferior, limiteSuperior) * CantidadMuestra;
            return frecuenciaEsperada;
        }


        /// Nos permite calcular probabilidad esperada
        public double CalcularProbabilidadEsperada(double limiteInferior, double limiteSuperior)
        {
            //Usamos la formula de la acumulada para distibuciones exponencial negativa
            double ProbabilidadEsperada = ((1 - Math.Exp((-Lambda) * limiteSuperior)) - (1 - Math.Exp((-Lambda) * limiteInferior)));

            return ProbabilidadEsperada;
        }

    }
}
