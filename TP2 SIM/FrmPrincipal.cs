using System;
using System.Drawing;
using System.Windows.Forms;
using TP2_SIM.Distribuciones;

namespace TP2_SIM
{
    public partial class Principal : Form
    {
        /// Constructor de la clase Principal
        public Principal()
        {
            InitializeComponent();

            OcultarDatos();
        }

        /// Método que nos permite ocultar todos los datos visuales.
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
            txtResultados.Visible = false;
        }

        /// Método que nos permite mostrar todos los datos visuales.
        private void MostrarDatos()
        {
            chartDistribucion.Show();
            dgvMuestra.Show();
            gbChi.Visible = true;
            gbKS.Visible = true;
            txtResultados.Visible = true;
        }

        /// Método que no permite limpíar todos los campos requeridos.
        private void LimpiarCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtDesviacion.Clear();
            txtMedia.Clear();
            txtLambda.Clear();
        }

        /// Nos permite ocultar elementos del formualrio cuando se cambia de seleccion de intervalos
        private void cbIntervalos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chartDistribucion.Hide();
            dgvMuestra.Hide();
            gbChi.Visible = false;
            gbKS.Visible = false;
            txtResultados.Visible = false;
        }

        /// Método que nos permite cargar la distribución.
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

        /// Método que nos permite realizar la ejecución completa de cada una de las distribuciones
        /// utilizando el evento del botón: btnGenerar_Click
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ActivarGeneracion();
            MostrarDatos();
        }

        /// Método que nos permite activar la generación de cada una de las distribuciones.
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
                uniforme.Resultados = txtResultados;


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
                exponencialNegativa.Resultados = txtResultados;

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
                normal.Resultados = txtResultados;

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

        private void dgvMuestra_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grilla = sender as DataGridView;
            var rowIndex = (e.RowIndex + 1).ToString();

            var centerformat = new StringFormat()
            {
                //alinea el numero de fila
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grilla.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, this.Font, SystemBrushes.ControlText, headerBounds, centerformat);
        }

    }

}
