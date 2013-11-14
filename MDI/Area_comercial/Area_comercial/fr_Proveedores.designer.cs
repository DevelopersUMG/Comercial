namespace Area_comercial
{
    partial class fr_Proveedores
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
            this.barra1 = new Navegador.Barra();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Registro = new System.Windows.Forms.Label();
            this.tx_Registro = new System.Windows.Forms.TextBox();
            this.tx_Direccion = new System.Windows.Forms.TextBox();
            this.tx_Telefono = new System.Windows.Forms.TextBox();
            this.tx_Proveedor = new System.Windows.Forms.TextBox();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_Telefono = new System.Windows.Forms.Label();
            this.lb_Nombreproveedor = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_Detallebuscar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detallebuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(11, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 0;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_editar_button += new Navegador.Barra.delegadoButton(this.barra1_click_editar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.barra1_click_eliminar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Registro);
            this.panel1.Controls.Add(this.tx_Registro);
            this.panel1.Controls.Add(this.tx_Direccion);
            this.panel1.Controls.Add(this.tx_Telefono);
            this.panel1.Controls.Add(this.tx_Proveedor);
            this.panel1.Controls.Add(this.lb_Direccion);
            this.panel1.Controls.Add(this.lb_Telefono);
            this.panel1.Controls.Add(this.lb_Nombreproveedor);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 287);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Registro
            // 
            this.lbl_Registro.AutoSize = true;
            this.lbl_Registro.Location = new System.Drawing.Point(232, 26);
            this.lbl_Registro.Name = "lbl_Registro";
            this.lbl_Registro.Size = new System.Drawing.Size(56, 13);
            this.lbl_Registro.TabIndex = 7;
            this.lbl_Registro.Text = "Registro #";
            // 
            // tx_Registro
            // 
            this.tx_Registro.Location = new System.Drawing.Point(314, 23);
            this.tx_Registro.Name = "tx_Registro";
            this.tx_Registro.Size = new System.Drawing.Size(100, 20);
            this.tx_Registro.TabIndex = 6;
            // 
            // tx_Direccion
            // 
            this.tx_Direccion.Location = new System.Drawing.Point(145, 147);
            this.tx_Direccion.Name = "tx_Direccion";
            this.tx_Direccion.Size = new System.Drawing.Size(269, 20);
            this.tx_Direccion.TabIndex = 5;
            // 
            // tx_Telefono
            // 
            this.tx_Telefono.Location = new System.Drawing.Point(145, 99);
            this.tx_Telefono.Name = "tx_Telefono";
            this.tx_Telefono.Size = new System.Drawing.Size(269, 20);
            this.tx_Telefono.TabIndex = 4;
            // 
            // tx_Proveedor
            // 
            this.tx_Proveedor.Location = new System.Drawing.Point(145, 58);
            this.tx_Proveedor.Name = "tx_Proveedor";
            this.tx_Proveedor.Size = new System.Drawing.Size(269, 20);
            this.tx_Proveedor.TabIndex = 3;
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Location = new System.Drawing.Point(41, 150);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lb_Direccion.TabIndex = 2;
            this.lb_Direccion.Text = "Dirección";
            // 
            // lb_Telefono
            // 
            this.lb_Telefono.AutoSize = true;
            this.lb_Telefono.Location = new System.Drawing.Point(41, 106);
            this.lb_Telefono.Name = "lb_Telefono";
            this.lb_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lb_Telefono.TabIndex = 1;
            this.lb_Telefono.Text = "Teléfono";
            // 
            // lb_Nombreproveedor
            // 
            this.lb_Nombreproveedor.AutoSize = true;
            this.lb_Nombreproveedor.Location = new System.Drawing.Point(12, 65);
            this.lb_Nombreproveedor.Name = "lb_Nombreproveedor";
            this.lb_Nombreproveedor.Size = new System.Drawing.Size(96, 13);
            this.lb_Nombreproveedor.TabIndex = 0;
            this.lb_Nombreproveedor.Text = "Nombre Proveedor";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 334);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_Detallebuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_Detallebuscar
            // 
            this.dg_Detallebuscar.AllowUserToAddRows = false;
            this.dg_Detallebuscar.AllowUserToDeleteRows = false;
            this.dg_Detallebuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Detallebuscar.Location = new System.Drawing.Point(6, 33);
            this.dg_Detallebuscar.Name = "dg_Detallebuscar";
            this.dg_Detallebuscar.ReadOnly = true;
            this.dg_Detallebuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Detallebuscar.Size = new System.Drawing.Size(474, 272);
            this.dg_Detallebuscar.TabIndex = 0;
            this.dg_Detallebuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Detallebuscar_CellClick);
            // 
            // fr_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_comercial.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(521, 407);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barra1);
            this.Name = "fr_Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.fr_Proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detallebuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tx_Direccion;
        private System.Windows.Forms.TextBox tx_Telefono;
        private System.Windows.Forms.TextBox tx_Proveedor;
        private System.Windows.Forms.Label lb_Direccion;
        private System.Windows.Forms.Label lb_Telefono;
        private System.Windows.Forms.Label lb_Nombreproveedor;
        private System.Windows.Forms.Label lbl_Registro;
        private System.Windows.Forms.TextBox tx_Registro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg_Detallebuscar;
    }
}