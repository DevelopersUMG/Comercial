namespace Area_comercial
{
    partial class Consulta_Clientes
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
            this.grid_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_clientes
            // 
            this.grid_clientes.AllowUserToAddRows = false;
            this.grid_clientes.AllowUserToDeleteRows = false;
            this.grid_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clientes.Location = new System.Drawing.Point(30, 28);
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(629, 226);
            this.grid_clientes.TabIndex = 0;
            this.grid_clientes.DoubleClick += new System.EventHandler(this.grid_clientes_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona un Cliente";
            // 
            // Consulta_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_clientes);
            this.Name = "Consulta_Clientes";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.Consulta_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_clientes;
        private System.Windows.Forms.Label label1;
    }
}