namespace Area_comercial
{
    partial class fr_existencia
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
            this.dg_existencia = new System.Windows.Forms.DataGridView();
            this.lb_pro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_existencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_existencia
            // 
            this.dg_existencia.AllowUserToAddRows = false;
            this.dg_existencia.AllowUserToDeleteRows = false;
            this.dg_existencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_existencia.Location = new System.Drawing.Point(13, 66);
            this.dg_existencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_existencia.Name = "dg_existencia";
            this.dg_existencia.ReadOnly = true;
            this.dg_existencia.Size = new System.Drawing.Size(473, 129);
            this.dg_existencia.TabIndex = 0;
            // 
            // lb_pro
            // 
            this.lb_pro.AutoSize = true;
            this.lb_pro.Location = new System.Drawing.Point(13, 27);
            this.lb_pro.Name = "lb_pro";
            this.lb_pro.Size = new System.Drawing.Size(82, 18);
            this.lb_pro.TabIndex = 1;
            this.lb_pro.Text = "Producto:";
            // 
            // fr_existencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_comercial.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(503, 214);
            this.Controls.Add(this.lb_pro);
            this.Controls.Add(this.dg_existencia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fr_existencia";
            this.Text = "Existencia";
            this.Load += new System.EventHandler(this.fr_existencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_existencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_existencia;
        private System.Windows.Forms.Label lb_pro;
    }
}