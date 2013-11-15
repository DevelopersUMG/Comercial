namespace WindowsFormsApplication1
{
    partial class form_comisiones_reporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_comision = new System.Windows.Forms.DataGridView();
            this.bx_nombre = new System.Windows.Forms.ComboBox();
            this.label_vend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grid_comision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_comision
            // 
            this.grid_comision.AllowUserToAddRows = false;
            this.grid_comision.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_comision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_comision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_comision.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_comision.Location = new System.Drawing.Point(-22, 158);
            this.grid_comision.Name = "grid_comision";
            this.grid_comision.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_comision.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_comision.Size = new System.Drawing.Size(240, 150);
            this.grid_comision.TabIndex = 1;
            // 
            // bx_nombre
            // 
            this.bx_nombre.FormattingEnabled = true;
            this.bx_nombre.Location = new System.Drawing.Point(241, 67);
            this.bx_nombre.Name = "bx_nombre";
            this.bx_nombre.Size = new System.Drawing.Size(121, 21);
            this.bx_nombre.TabIndex = 2;
            // 
            // label_vend
            // 
            this.label_vend.AutoSize = true;
            this.label_vend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vend.Location = new System.Drawing.Point(38, 65);
            this.label_vend.Name = "label_vend";
            this.label_vend.Size = new System.Drawing.Size(189, 20);
            this.label_vend.TabIndex = 4;
            this.label_vend.Text = "Nombre de Vendedor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mes :";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(241, 158);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Generar ";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(241, 106);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // form_comisiones_reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(422, 208);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_vend);
            this.Controls.Add(this.bx_nombre);
            this.Controls.Add(this.grid_comision);
            this.Name = "form_comisiones_reporte";
            this.Text = "form_comisiones_reporte";
            this.Load += new System.EventHandler(this.form_comisiones_reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_comision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_comision;
        private System.Windows.Forms.ComboBox bx_nombre;
        private System.Windows.Forms.Label label_vend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}