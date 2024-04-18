namespace TP2_SIM.ControlesEspeciales
{
    partial class NumericTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCampo
            // 
            this.txtCampo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCampo.Location = new System.Drawing.Point(0, 0);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(88, 20);
            this.txtCampo.TabIndex = 0;
            this.txtCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCampo_KeyPress);
            // 
            // NumericTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCampo);
            this.Name = "NumericTextBox";
            this.Size = new System.Drawing.Size(88, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo;
    }
}
