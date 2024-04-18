using System.Windows.Forms;

namespace TP2_SIM.ControlesEspeciales
{
    public partial class NumericTextBox : UserControl
    {
        // Propiedadades
        public int MaxLength { get; set; } = 10; // Cantidad máxima de dígitos permitidos
        public bool AllowNumbersOnly { get; set; } = true; // Permite ingresar solo números
        
        // Métodos
        public NumericTextBox()
        {
            InitializeComponent();
            //MaxLength = 10; // Valor por defecto
            //AllowNumbersOnly = true; // Valor por defecto
        }

        private void txtCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si se permite solo números y el caracter no es un número ni la tecla de retroceso
            if (AllowNumbersOnly && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // No permitir el ingreso
            }
            // Verificar la longitud máxima permitida
            if (txtCampo.Text.Length >= MaxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // No permitir el ingreso
            }
        }
        
        // Método para obtener el valor numérico del control
        public int GetNumericValue()
        {
            int value = 0;
            if (int.TryParse(txtCampo.Text, out value))
            {
                return value;
            }
            return 0; // Valor predeterminado si no se puede convertir
        }
    }
}
