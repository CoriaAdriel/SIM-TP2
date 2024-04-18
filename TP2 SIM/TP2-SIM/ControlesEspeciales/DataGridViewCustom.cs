using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_SIM.ControlesEspeciales
{
    public partial class DataGridViewCustom : UserControl
    {
        public DataGridViewCustom()
        {
            InitializeComponent();
        }
        // Propiedades importantes
        [Browsable(true)]
        [Category("Datos")]
        [Description("Origen de datos para el control DataGridView.")]
        public object DataSource
        {
            get { return gdrBase.DataSource; }
            set { gdrBase.DataSource = value; }
        }

        [Browsable(true)]
        [Category("Apariencia")]
        [Description("Colección de columnas para el control DataGridView.")]
        public DataGridViewColumnCollection Columns
        {
            get { return gdrBase.Columns; }
        }

        [Browsable(true)]
        [Category("Comportamiento")]
        [Description("Indica si se permite al usuario agregar filas al control DataGridView.")]
        public bool AllowUserToAddRows
        {
            get { return gdrBase.AllowUserToAddRows; }
            set { gdrBase.AllowUserToAddRows = value; }
        }
    }
}
