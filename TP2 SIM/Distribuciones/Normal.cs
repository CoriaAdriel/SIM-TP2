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
        public TextBox Resultados { get; set; }

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
            CalcularChi();
            CalcularKS();
            CalcularResultadoPruebas();
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

        //Calcular Chi-Cuadrado
        public void CalcularChi()
        {
            PruebaChi.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;
            double marcaClase = 0;

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
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase);
                    chiCuadrado = (Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2)) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;
                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + amplitud;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;
                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase);
                    chiCuadrado = (Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2)) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;
                }

                //Hacemos que los valores sean de 4 decimales antes de agregarlos a la grilla
                limiteInferior = Math.Truncate(limiteInferior * 10000) / 10000;
                limiteSuperior = Math.Truncate(limiteSuperior * 10000) / 10000;
                frecuenciaObservada = Math.Truncate(frecuenciaObservada * 10000) / 10000;
                frecuenciaEsperada = Math.Truncate(frecuenciaEsperada * 10000) / 10000;

                chiCuadrado = Math.Truncate(chiCuadrado * 10000) / 10000;
                chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 10000) / 10000;

                limitesInferiores.Add(limiteInferior);
                limitesSuperiores.Add(limiteSuperior);
                frecuenciasObservadas.Add(frecuenciaObservada);
                frecuenciasEsperadas.Add(frecuenciaEsperada);

                if (CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, marcaClase) >= 5)
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
                        chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 10000) / 10000;

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
                        chiCuadradoAcumulado = Math.Truncate(chiCuadradoAcumulado * 10000) / 10000;

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

        //Calculamos los resultados de las evaluaciones y lo agregamos al textbox de resultados
        public void CalcularResultadoPruebas()
        {
            Resultados.Clear();

            //V=k-1-m, en el caso de normal m = 2
            double gradosDeLibertad = CantidadIntervalos - 3;
            double valorChiCalculado = Convert.ToDouble(PruebaChi.Rows[(PruebaChi.RowCount - 1)].Cells[(PruebaChi.ColumnCount - 1)].Value);
            double valorKSCalculado = Convert.ToDouble(PruebaKS.Rows[(PruebaKS.RowCount - 1)].Cells[(PruebaKS.ColumnCount - 1)].Value);

            double[,] arrayChiTabuladoDeclarado = new double[4, 2];
            double[,] arrayChiTabulado = { { 7, 2.167 }, { 9, 3.325 }, { 13, 5.892 }, { 20, 10.851 } };

            double[] arrayKSTabuladoDeclarado = new double[35];
            double[] arrayKSTabulado = {0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300, 0.4092, 0.3912, 0.3754,
                0.3614, 0.3489, 0.3375, 0.3273, 0.3179, 0.3093, 0.3014, 0.2940, 0.2872, 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543,
                0.2499, 0.2457, 0.2417, 0.2378, 0.2342, 0.2307, 0.2274, 0.2242};

            Resultados.AppendText("Siendo la hipótesis que la distribución se aproxima a una Uniforme [a,b], si asumimos un nivel de significancia de alfa = 0.05: " + "\r\n");

            // Buscamos los grados de libertad en la matriz y devolvemos el valor correspondiente
            double valorChiTabulado = 0;

            for (int i = 0; i < arrayChiTabulado.GetLength(0); i++)
            {
                for (int j = 0; j < arrayChiTabulado.GetLength(1) - 1; j++)
                {
                    if (arrayChiTabulado[i, j] == gradosDeLibertad)
                    {
                        valorChiTabulado = arrayChiTabulado[i, j + 1];
                        break;
                    }
                }
            }

            //Buscamos en el array el valor correspondiente a la cantidad de muestras pedidas
            double valorKSTabulado = 0;

            if (CantidadMuestra <= arrayKSTabulado.Length)
            {
                valorKSTabulado = Convert.ToDouble(arrayKSTabulado[(int)CantidadMuestra - 1]); // -1 porque los índices de los arrays comienzan desde 0
            }
            else
            {
                valorKSTabulado = Math.Truncate((1.36 / (Math.Sqrt(CantidadMuestra))) * 10000) / 10000;
            }

            //Escribimos el resultado de Chi
            if (valorChiCalculado <= valorChiTabulado)
            {
                Resultados.Text += "\r\nLa hipotesis no se rechaza por Chi-Cuadrado:";
                Resultados.Text += "\r\nValor Calculado:" + valorChiCalculado + " < Valor Tabulado: " + valorChiTabulado;
            }
            else
            {
                Resultados.Text += "\r\nLa hipotesis se rechaza por Chi-Cuadrado:";
                Resultados.Text += "\r\nValor Calculado:" + valorChiCalculado + " > Valor Tabulado: " + valorChiTabulado;
            }

            //Escribimos el resultado de KS
            if (valorKSCalculado <= valorKSTabulado)
            {
                Resultados.Text += "\r\nLa hipotesis no se rechaza por K-S:";
                Resultados.Text += "\r\nValor Calculado:" + valorKSCalculado + " < Valor Tabulado: " + valorKSTabulado;
            }
            else
            {
                Resultados.Text += "\r\nLa hipotesis se rechaza por K-S:";
                Resultados.Text += "\r\nValor Calculado:" + valorKSCalculado + " > Valor Tabulado: " + valorKSTabulado;
            }

        }

    }
}