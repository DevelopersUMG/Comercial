namespace compras
{
    partial class mdiprincipal
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
            this.nOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recpsionDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nOToolStripMenuItem
            // 
            this.nOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.nOToolStripMenuItem.Name = "nOToolStripMenuItem";
            this.nOToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.nOToolStripMenuItem.Text = "Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.proveedoresToolStripMenuItem.Text = "<proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traToolStripMenuItem,
            this.traToolStripMenuItem1,
            this.recpsionDeProductoToolStripMenuItem});
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // traToolStripMenuItem
            // 
            this.traToolStripMenuItem.Name = "traToolStripMenuItem";
            this.traToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.traToolStripMenuItem.Text = "Transaccional Compras";
            this.traToolStripMenuItem.Click += new System.EventHandler(this.traToolStripMenuItem_Click);
            // 
            // traToolStripMenuItem1
            // 
            this.traToolStripMenuItem1.Name = "traToolStripMenuItem1";
            this.traToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.traToolStripMenuItem1.Text = "Transaccional Servicio";
            this.traToolStripMenuItem1.Click += new System.EventHandler(this.traToolStripMenuItem1_Click);
            // 
            // recpsionDeProductoToolStripMenuItem
            // 
            this.recpsionDeProductoToolStripMenuItem.Name = "recpsionDeProductoToolStripMenuItem";
            this.recpsionDeProductoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.recpsionDeProductoToolStripMenuItem.Text = "Recepcion de producto";
            this.recpsionDeProductoToolStripMenuItem.Click += new System.EventHandler(this.recpsionDeProductoToolStripMenuItem_Click);
            // 
            // mdiprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 512);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdiprincipal";
            this.Text = "mdiprincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recpsionDeProductoToolStripMenuItem;
    }
}