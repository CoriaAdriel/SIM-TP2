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
        private List<double> numerosUniformes = new List<double>();


        // Métodos de la clase
        public Uniforme()
        {
            InitializeComponent();
        }

        private void Uniforme_Load(object sender, System.EventArgs e)
        {
            limpiarCampos();
        }

        //txtB.Select(0, 0);
        private void btnGenerar_Click(object sender, System.EventArgs e)
        {
            try
            {
                int cantidadAGenerar = txtN.GetNumericValue();
                int valorDesde = txtDesde.GetNumericValue();
                int valorHasta = txtHasta.GetNumericValue();
                
                // Limpiamos la lista antes de generar nuevos números
                numerosUniformes.Clear();

                List<double> numerosGenerados = DistribucionUnirme.GenerarNumeroUniforme(cantidadAGenerar, valorDesde, valorHasta);

                // Agregar los números generados a la lista
                numerosUniformes.AddRange(numerosGenerados);

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
            ChiCuadrado ventanaChi = new ChiCuadrado();
            ventanaChi.Show();

        }

        private void btnVerRandom_Click(object sender, EventArgs e)
        {
            Randoms ventanaRandoms = new Randoms(numerosUniformes);
            ventanaRandoms.ShowDialog();
        }
    }
}
