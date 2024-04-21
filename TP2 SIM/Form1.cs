using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using TP2_SIM.Distribuciones;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP2_SIM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            OcultarDatos();
        }

        private void OcultarDatos()
        {
            btnGenerar.Hide();
            lblIngreseDatos.Hide();
            chartDistribucion.Hide();
            dgvMuestra.Hide();

            gbUniforme.Visible = false;
            gbExponencial.Visible = false;
            gbNormal.Visible = false;
            gbChi.Visible = false;
            gbKS.Visible = false;
        }

        private void MostrarDatos()
        {
            chartDistribucion.Show();
            dgvMuestra.Show();
            gbChi.Visible = true;
            gbKS.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtDesviacion.Clear();
            txtMedia.Clear();
            txtLambda.Clear();
        }

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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ActivarGeneracion();
            MostrarDatos();
        }

        public void ActivarGeneracion()
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

    }

}
