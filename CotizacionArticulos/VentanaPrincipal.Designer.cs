namespace CotizacionArticulos
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cotizacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionToolStripMenuItem1,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cotizacionToolStripMenuItem1
            // 
            this.cotizacionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionDeArticulosToolStripMenuItem});
            this.cotizacionToolStripMenuItem1.Name = "cotizacionToolStripMenuItem1";
            this.cotizacionToolStripMenuItem1.Size = new System.Drawing.Size(91, 24);
            this.cotizacionToolStripMenuItem1.Text = "Cotizacion";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeArticulosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // cotizacionDeArticulosToolStripMenuItem
            // 
            this.cotizacionDeArticulosToolStripMenuItem.Name = "cotizacionDeArticulosToolStripMenuItem";
            this.cotizacionDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cotizacionDeArticulosToolStripMenuItem.Text = "Cotizacion de Articulos";
            // 
            // consultaDeArticulosToolStripMenuItem
            // 
            this.consultaDeArticulosToolStripMenuItem.Name = "consultaDeArticulosToolStripMenuItem";
            this.consultaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultaDeArticulosToolStripMenuItem.Text = "Consulta de Articulos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cotizacion De Articulos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cotizacionDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeArticulosToolStripMenuItem;
    }
}

