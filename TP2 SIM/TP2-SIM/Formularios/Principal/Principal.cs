using TP2_SIM.Generadores.Exponencial;
using TP2_SIM.Generadores.Normal;
using TP2_SIM.Generadores.Uniforme;
using System.Windows.Forms;

namespace TP2_SIM.Formularios.Principal
{
    public partial class Principal : FrmBase
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnUniforme_Click(object sender, System.EventArgs e)
        {
            Uniforme ventanaUniforme = new Uniforme();
            ventanaUniforme.Show();
            this.Hide();
        }

        private void btnNormal_Click(object sender, System.EventArgs e)
        {
            Normal ventanaNormal = new Normal();
            ventanaNormal.Show();
            this.Hide();
        }

        private void btnExponcial_Click(object sender, System.EventArgs e)
        {
            Exponencial ventanaExponencial = new Exponencial();
            ventanaExponencial.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Gracias por utilizar nuestro sistemas", "Simulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
