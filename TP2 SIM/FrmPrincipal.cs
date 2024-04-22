﻿using System;
using System.Windows.Forms;
using TP2_SIM.Distribuciones;

namespace TP2_SIM
{
    public partial class Principal : Form
    {
        /// <summary>
        /// Constructor de la clase Principal
        /// </summary>
        public Principal()
        {
            InitializeComponent();

            OcultarDatos();
        }
        /// <summary>
        /// Método que nos permite ocultar todos los datos visuales.
        /// </summary>
        private void OcultarDatos()
        {            
            lblIngreseDatos.Hide();
            chartDistribucion.Hide();
            dgvMuestra.Hide();

            gbUniforme.Visible = false;
            gbExponencial.Visible = false;
            gbNormal.Visible = false;
            gbChi.Visible = false;
            gbKS.Visible = false;
        }
        /// <summary>
        /// Método que nos permite mostrar todos los datos visuales.
        /// </summary>
        private void MostrarDatos()
        {
            chartDistribucion.Show();
            dgvMuestra.Show();
            gbChi.Visible = true;
            gbKS.Visible = true;
        }
        /// <summary>
        /// Método que no permite limpíar todos los campos requeridos.
        /// </summary>
        private void LimpiarCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtDesviacion.Clear();
            txtMedia.Clear();
            txtLambda.Clear();
        }
        /// <summary>
        /// Método que nos permite cargar la distribución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDistribucion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Selecciona Uniforme = 0
            //Selecciona Exponencial = 1
            //Selecciona Normal = 2
            if (cbDistribucion.SelectedIndex == 0)
            {
                OcultarDatos();
                btnGenerar.Show();
                lblIngreseDatos.Show();
                LimpiarCampos();

                gbUniforme.Visible = true;
                gbExponencial.Visible = false;
                gbNormal.Visible = false;
            }
            else if (cbDistribucion.SelectedIndex == 1)
            {
                OcultarDatos();
                btnGenerar.Show();
                lblIngreseDatos.Show();
                LimpiarCampos();

                gbExponencial.Visible = true;
                gbUniforme.Visible = false;
                gbNormal.Visible = false;
            }
            else
            {
                OcultarDatos();
                btnGenerar.Show();
                lblIngreseDatos.Show();
                LimpiarCampos();

                gbNormal.Visible = true;
                gbUniforme.Visible = false;
                gbExponencial.Visible = false;

            }
        }
        /// <summary>
        /// Método que nos permite realizar la ejecución completa de cada una de las distribuciones
        /// utilizando el evento del botón: btnGenerar_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ActivarGeneracion();
            MostrarDatos();         
        }
        /// <summary>
        /// Método que nos permite activar la generación de cada una de las distribuciones.
        /// </summary>
        public void ActivarGeneracion()
        {
            try
            {
                if (cbDistribucion.SelectedIndex == 0)
                {

                    Uniforme uniforme = new Uniforme();

                    uniforme.CantidadMuestra = Convert.ToDouble(txtN.Text.Trim());
                    uniforme.A = Convert.ToDouble(txtA.Text.Trim());
                    uniforme.B = Convert.ToDouble(txtB.Text.Trim());
                    uniforme.CantidadIntervalos = Convert.ToInt32(cbIntervalos.Text.Trim());
                    uniforme.Grafico = chartDistribucion;
                    uniforme.Grilla = dgvMuestra;
                    uniforme.PruebaChi = dgvChi;
                    uniforme.PruebaKS = dgvKS;


                    if (uniforme.A == 0 || uniforme.B == 0 || uniforme.CantidadIntervalos == 0 || uniforme.CantidadMuestra == 0)
                    {
                        MessageBox.Show("Error: Complete los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        uniforme.GenerarDistribucion();
                    }

                }

                if (cbDistribucion.SelectedIndex == 1)
                {
                    ExponencialNegativa exponencialNegativa = new ExponencialNegativa();

                    exponencialNegativa.CantidadMuestra = Convert.ToInt32(txtN.Text.Trim());
                    exponencialNegativa.CantidadIntervalos = Convert.ToInt32(cbIntervalos.Text.Trim());
                    exponencialNegativa.Lambda = Convert.ToDouble(txtLambda.Text.Trim());
                    exponencialNegativa.Grafico = chartDistribucion;
                    exponencialNegativa.Grilla = dgvMuestra;
                    exponencialNegativa.PruebaChi = dgvChi;
                    exponencialNegativa.PruebaKS = dgvKS;

                    if (exponencialNegativa.Lambda == 0 || exponencialNegativa.CantidadIntervalos == 0 || exponencialNegativa.CantidadMuestra == 0)
                    {
                        MessageBox.Show("Error: Complete los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exponencialNegativa.GenerarDistribucion();
                    }

                }

                if (cbDistribucion.SelectedIndex == 2)
                {
                    Normal normal = new Normal();

                    normal.CantidadMuestra = Convert.ToInt32(txtN.Text.Trim());
                    normal.CantidadIntervalos = Convert.ToInt32(cbIntervalos.Text.Trim());
                    normal.Desviacion = Convert.ToDouble(txtDesviacion.Text.Trim());
                    normal.Media = Convert.ToDouble(txtMedia.Text.Trim());
                    normal.Grafico = chartDistribucion;
                    normal.Grilla = dgvMuestra;
                    normal.PruebaChi = dgvChi;
                    normal.PruebaKS = dgvKS;

                    if (normal.Desviacion == 0 || normal.Media == 0 || normal.CantidadMuestra == 0 || normal.CantidadIntervalos == 0)
                    {
                        MessageBox.Show("Error: Complete los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        normal.GenerarDistribucion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Programa generador de numeros aleatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        /// <summary>
        /// Nos permite validar que todos los campos esten cargados
        /// </summary>
        /// <returns></returns>
        //private bool ValidarCamposFormularios()
        //{
        //    bool tieneTxtN = false;
        //    bool tieneCmbDistribucion = false;
        //    bool tieneIntervalos = false;
        //    bool tieneTodo = false;
        //    if (txtN.Text.Equals(""))
        //    {
        //        MessageBox.Show("Porfavor ingrese la cantidad de elementos a generar", "Programa generador de numeros aleatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtN.Focus();
        //    }
        //    else
        //    {
        //        tieneTxtN = true;
        //    }
        //    if (cbIntervalos.Items.Count > 0)
        //    {
        //        MessageBox.Show("Porfavor seleccione la cantidad de intervalos a generar", "Programa generador de numeros aleatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cbDistribucion.Focus();
        //    }
        //    else
        //    {
        //        tieneIntervalos = true;
        //    }

        //    if (cbDistribucion.Items.Count > 0)
        //    {
        //        MessageBox.Show("Porfavor ingrese la cantidad de elementos a generar", "Programa generador de numeros aleatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cbDistribucion.Focus();
        //    }
        //    else
        //    {
        //        tieneCmbDistribucion = true;
        //    }
        //    if (tieneTxtN && tieneCmbDistribucion && tieneIntervalos)
        //        tieneTodo = true;
            
        //    return tieneTodo;
        //}

    }
}
