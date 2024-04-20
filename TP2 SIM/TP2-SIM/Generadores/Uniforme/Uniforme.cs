using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP2_SIM.Formularios.Principal;
using TP2_SIM.Formularios.Randoms;
using TP2_SIM.PruebaDeBondad.ChiCuadrado;

namespace TP2_SIM.Generadores.Uniforme
{
    public partial class Uniforme : FrmBase
    {
        // Atributos de la clase
        DistribucionUnirme uniforme = new DistribucionUnirme();
    

        // Métodos de la clase
        public Uniforme()
        {
            InitializeComponent();
        }

        private void Uniforme_Load(object sender, System.EventArgs e)
        {
            limpiarCampos();
            habilitarRadioButtomPorDefecto();
        }
        private void habilitarRadioButtomPorDefecto()
        {
            rd10.Checked = true;
            rd12.Checked = false;
            rd16.Checked = false;
            rd23.Checked = false;
        }


        //txtB.Select(0, 0);
        private void btnGenerar_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Comprobamos el valor actual de la cantidad de intervalos
                if (rd10.Checked)
                {
                    uniforme.CantidadIntervalos = Convert.ToInt32(rd10.Text);
                }
                else if (rd12.Checked)
                {
                    uniforme.CantidadIntervalos = Convert.ToInt32(rd12.Text);
                }
                else if (rd16.Checked)
                {
                    uniforme.CantidadIntervalos = Convert.ToInt32(rd16.Text);
                }
                else if (rd23.Checked)
                {
                    uniforme.CantidadIntervalos = Convert.ToInt32(rd23.Text);
                }

                // Asignamos cada valor del formulario en la clase Uniforme
                uniforme.N = Convert.ToInt32(txtN.GetNumericValue());
                uniforme.Desde = Convert.ToDouble(txtDesde.GetNumericValue());
                uniforme.Hasta = Convert.ToDouble(txtHasta.GetNumericValue());
                uniforme.Desde = Convert.ToDouble(txtDesde.GetNumericValue());                
                uniforme.Grafico = chtUniforme;

                // Generar Números aleatorios Uniforme
                uniforme.GenerarDistribucionUniforme();
                uniforme.GenerarGrafico();

                // Actualizar el gráfico con la nueva cantidad de intervalos
                uniforme.ActualizarGrafico(uniforme.CantidadIntervalos);

                // Mostramos un mensaje de números generados con éxito
                MessageBox.Show("Se ha generado los rnd con éxito", "Distribución Uniforme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }            
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtN.Text = "";
            txtHasta.Text = "";
            txtDesde.Text = "";            
        }

        private void Uniforme_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Nos permite mostrar la ventana principal
            Principal ventanaPrincipal = new Principal();
            ventanaPrincipal.Show();
        }

        private void btnPruebaChi_Click(object sender, EventArgs e)
        {

        }

        private void btnVerRandom_Click(object sender, EventArgs e)
        {
            Randoms ventanaRnds = new Randoms(uniforme.NumerosUniformes);
            ventanaRnds.Show();
        }
    }
}
