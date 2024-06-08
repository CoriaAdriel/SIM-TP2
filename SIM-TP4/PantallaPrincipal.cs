using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIM_TP4.Simulaciones;

namespace SIM_TP4
{
    public partial class PantallaPrincipal : Form
    {
        public int simulaciones {  get; set; }
        public int desde { get; set; }

        public PantallaPrincipal()
        {
            InitializeComponent();
            ValoresDefault();
        }

        private void ValoresDefault()
        {
            txtEmpleadosPermisos.Text = "4";
            txtLambdaPermisos.Text = "10";

            txtEmpleadosPlanos.Text = "2";
            txtLambdaPlanos.Text = "6";

            txtEmpleadosObras.Text = "3";
            txtLambdaObras.Text = "5";

            txtEmpleadosNormativas.Text = "2";
            txtLambdaNormativas.Text = "8";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var validoSimulaciones = validarFechas();
            if (validoSimulaciones)
            {
                if (chckbNuevoServicio.Checked)
                {
                    //aca hariamos la simulacion con el servicio extra de obras
                }
                else
                {
                    //simulacion en condiciones normales
                    SimulacionNormal simulacionNormal = new SimulacionNormal(simulaciones, desde, Convert.ToInt32(txtEmpleadosPermisos.Text.Trim()), Convert.ToInt32(txtEmpleadosPlanos.Text.Trim()), Convert.ToInt32(txtEmpleadosObras.Text.Trim()),
                        Convert.ToInt32(txtEmpleadosNormativas.Text.Trim()), Convert.ToInt32(txtLambdaPermisos.Text.Trim()), Convert.ToInt32(txtLambdaPlanos.Text.Trim()), Convert.ToInt32(txtLambdaObras.Text.Trim()), Convert.ToInt32(txtLambdaNormativas.Text.Trim()));
                }
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            ValoresDefault();
        }

        private bool validarFechas()
        {
            this.desde = Convert.ToInt32(txtDesde.Text.Trim());
            this.simulaciones = Convert.ToInt32(txtSimulaciones.Text.Trim());

            //evaluamos se el desde + 300 lineas de simulaciones es menor que el total de simulaciones.
            if (desde+300 <= simulaciones)
            {
                return true;
            }
            else 
            {
                MessageBox.Show("Error: El numero de simulaciones no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }


        //
        //Controladores que evitan ingresar letras en los campos
        //

        private void txtEmpladosPermisos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLmbdaPermisos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEmpladosPlanos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLambdaPlanos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEmpladosObras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLambdaObras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEmpladosNormativas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLambdaNormativas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSimulaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
