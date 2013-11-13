namespace Compras2
{
    partial class MDI
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
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comrpasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionalComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionalServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.comrpasToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eToolStripMenuItem.Text = "Proveedores";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // comrpasToolStripMenuItem
            // 
            this.comrpasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionalComprasToolStripMenuItem,
            this.recepcionDeProductoToolStripMenuItem,
            this.transaccionalServiciosToolStripMenuItem});
            this.comrpasToolStripMenuItem.Name = "comrpasToolStripMenuItem";
            this.comrpasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comrpasToolStripMenuItem.Text = "Compras";
            // 
            // transaccionalComprasToolStripMenuItem
            // 
            this.transaccionalComprasToolStripMenuItem.Name = "transaccionalComprasToolStripMenuItem";
            this.transaccionalComprasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.transaccionalComprasToolStripMenuItem.Text = "Transaccional Compras";
            this.transaccionalComprasToolStripMenuItem.Click += new System.EventHandler(this.transaccionalComprasToolStripMenuItem_Click);
            // 
            // recepcionDeProductoToolStripMenuItem
            // 
            this.recepcionDeProductoToolStripMenuItem.Name = "recepcionDeProductoToolStripMenuItem";
            this.recepcionDeProductoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.recepcionDeProductoToolStripMenuItem.Text = "Recepcion de producto";
            this.recepcionDeProductoToolStripMenuItem.Click += new System.EventHandler(this.recepcionDeProductoToolStripMenuItem_Click);
            // 
            // transaccionalServiciosToolStripMenuItem
            // 
            this.transaccionalServiciosToolStripMenuItem.Name = "transaccionalServiciosToolStripMenuItem";
            this.transaccionalServiciosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.transaccionalServiciosToolStripMenuItem.Text = "Transaccional Servicios";
            this.transaccionalServiciosToolStripMenuItem.Click += new System.EventHandler(this.transaccionalServiciosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pruebaToolStripMenuItem.Text = "prueba";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 442);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comrpasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionalComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionalServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
    }
}