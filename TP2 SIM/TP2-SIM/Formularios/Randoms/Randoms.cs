using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_SIM.Generadores.Uniforme;

namespace TP2_SIM.Formularios.Randoms
{
    public partial class Randoms : FrmBase
    {
        private List<double> numerosUniformes;

        public Randoms(List<double> numerosUniformes)
        {
            InitializeComponent();
            this.numerosUniformes = numerosUniformes;
        }

        private void Randoms_Load(object sender, EventArgs e)
        {
            gdrRandom.Rows.Clear();
            foreach (double num in numerosUniformes)
            {

                // Redondeamos el número a cuatro decimales
                double numeroRedondeado = Math.Round(num, 4);

                // Crear una nueva fila para agregar el número RND
                DataGridViewRow fila = new DataGridViewRow();

                // Crear una celda para el número RND
                DataGridViewTextBoxCell celdaRnd = new DataGridViewTextBoxCell();

                // Nos permite mostrar únicamente 4 decimales
                celdaRnd.Value = numeroRedondeado.ToString("0.####");

                // Agregamos la celda a la fila
                fila.Cells.Add(celdaRnd);

                // Agregamos la fila a la grilla
                gdrRandom.Rows.Add(fila);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana actual
            this.Close();            
        }
    }
}
