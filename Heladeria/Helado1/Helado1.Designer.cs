namespace Heladeria.Helado1
{
    partial class Helado1
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
            this.Helado3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Helado3
            // 
            this.Helado3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Helado3.AutoSize = true;
            this.Helado3.Font = new System.Drawing.Font("Arial Narrow", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Helado3.ForeColor = System.Drawing.Color.Black;
            this.Helado3.Location = new System.Drawing.Point(571, 364);
            this.Helado3.Name = "Helado3";
            this.Helado3.Size = new System.Drawing.Size(246, 69);
            this.Helado3.TabIndex = 4;
            this.Helado3.Text = "Helados3";
            // 
            // Helado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Helado3);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Helado1";
            this.Size = new System.Drawing.Size(1518, 797);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Helado3;
    }
}
