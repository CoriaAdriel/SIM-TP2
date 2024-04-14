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

namespace TP2_SIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtA.Enabled = false;
            txtB.Enabled = false;
            txtDesviacion.Enabled = false;
            txtMedia.Enabled = false;
            txtLambda.Enabled = false;
            txtA.Clear();
            txtB.Clear();
            txtDesviacion.Clear();
            txtMedia.Clear();
            txtLambda.Clear();
        }

        private void cbDistribucion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDistribucion.SelectedIndex == 1)
            {
                LimpiarCampos();
                txtLambda.Enabled = true;
            }
            else if (cbDistribucion.SelectedIndex == 0)
            {
                LimpiarCampos();
                txtA.Enabled = true;
                txtB.Enabled = true;
            }
            else
            {
                LimpiarCampos();
                txtDesviacion.Enabled = true;
                txtMedia.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
