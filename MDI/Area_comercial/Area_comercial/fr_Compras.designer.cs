namespace Area_comercial
{
    partial class fr_Compras
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tx_Fecha = new System.Windows.Forms.DateTimePicker();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.cb_Tipocompra = new System.Windows.Forms.ComboBox();
            this.cb_Proveedor = new System.Windows.Forms.ComboBox();
            this.cb_Tipopago = new System.Windows.Forms.ComboBox();
            this.cb_Bodega = new System.Windows.Forms.ComboBox();
            this.cb_Moneda = new System.Windows.Forms.ComboBox();
            this.lb_Tipocompra = new System.Windows.Forms.Label();
            this.lb_Proveedor = new System.Windows.Forms.Label();
            this.lb_tipopago = new System.Windows.Forms.Label();
            this.lb_Bodega = new System.Windows.Forms.Label();
            this.lb_Moneda = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tx_Nocompra = new System.Windows.Forms.TextBox();
            this.lb_nocompra = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Cantidad = new System.Windows.Forms.Label();
            this.lb_Producto = new System.Windows.Forms.Label();
            this.tx_Cantidad = new System.Windows.Forms.TextBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.dg_Detalle = new System.Windows.Forms.DataGridView();
            this.barra1 = new Navegador.Barra();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_Total = new System.Windows.Forms.Label();
            this.tx_Total = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dg_detallebuscar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detallebuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_Fecha
            // 
            this.tx_Fecha.Location = new System.Drawing.Point(78, 20);
            this.tx_Fecha.Name = "tx_Fecha";
            this.tx_Fecha.Size = new System.Drawing.Size(302, 20);
            this.tx_Fecha.TabIndex = 0;
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Location = new System.Drawing.Point(503, 4);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(84, 31);
            this.bt_Agregar.TabIndex = 1;
            this.bt_Agregar.Text = "Agregar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // cb_Tipocompra
            // 
            this.cb_Tipocompra.FormattingEnabled = true;
            this.cb_Tipocompra.Items.AddRange(new object[] {
            "Materia Prima",
            "Producto Finalizado"});
            this.cb_Tipocompra.Location = new System.Drawing.Point(124, 58);
            this.cb_Tipocompra.Name = "cb_Tipocompra";
            this.cb_Tipocompra.Size = new System.Drawing.Size(165, 21);
            this.cb_Tipocompra.TabIndex = 2;
            this.cb_Tipocompra.SelectionChangeCommitted += new System.EventHandler(this.cb_Tipocompra_SelectionChangeCommitted);
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.Location = new System.Drawing.Point(114, 94);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.Size = new System.Drawing.Size(175, 21);
            this.cb_Proveedor.TabIndex = 3;
            // 
            // cb_Tipopago
            // 
            this.cb_Tipopago.FormattingEnabled = true;
            this.cb_Tipopago.Location = new System.Drawing.Point(114, 129);
            this.cb_Tipopago.Name = "cb_Tipopago";
            this.cb_Tipopago.Size = new System.Drawing.Size(175, 21);
            this.cb_Tipopago.TabIndex = 4;
            // 
            // cb_Bodega
            // 
            this.cb_Bodega.FormattingEnabled = true;
            this.cb_Bodega.Location = new System.Drawing.Point(402, 86);
            this.cb_Bodega.Name = "cb_Bodega";
            this.cb_Bodega.Size = new System.Drawing.Size(140, 21);
            this.cb_Bodega.TabIndex = 5;
            // 
            // cb_Moneda
            // 
            this.cb_Moneda.FormattingEnabled = true;
            this.cb_Moneda.Location = new System.Drawing.Point(402, 124);
            this.cb_Moneda.Name = "cb_Moneda";
            this.cb_Moneda.Size = new System.Drawing.Size(140, 21);
            this.cb_Moneda.TabIndex = 6;
            // 
            // lb_Tipocompra
            // 
            this.lb_Tipocompra.AutoSize = true;
            this.lb_Tipocompra.Location = new System.Drawing.Point(11, 61);
            this.lb_Tipocompra.Name = "lb_Tipocompra";
            this.lb_Tipocompra.Size = new System.Drawing.Size(82, 13);
            this.lb_Tipocompra.TabIndex = 7;
            this.lb_Tipocompra.Text = "Tipo de Compra";
            // 
            // lb_Proveedor
            // 
            this.lb_Proveedor.AutoSize = true;
            this.lb_Proveedor.Location = new System.Drawing.Point(34, 102);
            this.lb_Proveedor.Name = "lb_Proveedor";
            this.lb_Proveedor.Size = new System.Drawing.Size(56, 13);
            this.lb_Proveedor.TabIndex = 8;
            this.lb_Proveedor.Text = "Proveedor";
            // 
            // lb_tipopago
            // 
            this.lb_tipopago.AutoSize = true;
            this.lb_tipopago.Location = new System.Drawing.Point(34, 132);
            this.lb_tipopago.Name = "lb_tipopago";
            this.lb_tipopago.Size = new System.Drawing.Size(56, 13);
            this.lb_tipopago.TabIndex = 9;
            this.lb_tipopago.Text = "Tipo Pago";
            // 
            // lb_Bodega
            // 
            this.lb_Bodega.AutoSize = true;
            this.lb_Bodega.Location = new System.Drawing.Point(310, 94);
            this.lb_Bodega.Name = "lb_Bodega";
            this.lb_Bodega.Size = new System.Drawing.Size(44, 13);
            this.lb_Bodega.TabIndex = 10;
            this.lb_Bodega.Text = "Bodega";
            // 
            // lb_Moneda
            // 
            this.lb_Moneda.AutoSize = true;
            this.lb_Moneda.Location = new System.Drawing.Point(310, 124);
            this.lb_Moneda.Name = "lb_Moneda";
            this.lb_Moneda.Size = new System.Drawing.Size(46, 13);
            this.lb_Moneda.TabIndex = 11;
            this.lb_Moneda.Text = "Moneda";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(11, 26);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lb_Fecha.TabIndex = 12;
            this.lb_Fecha.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tx_Nocompra);
            this.panel1.Controls.Add(this.lb_nocompra);
            this.panel1.Controls.Add(this.tx_Fecha);
            this.panel1.Controls.Add(this.lb_Fecha);
            this.panel1.Controls.Add(this.cb_Tipocompra);
            this.panel1.Controls.Add(this.lb_Moneda);
            this.panel1.Controls.Add(this.cb_Proveedor);
            this.panel1.Controls.Add(this.lb_Bodega);
            this.panel1.Controls.Add(this.cb_Tipopago);
            this.panel1.Controls.Add(this.lb_tipopago);
            this.panel1.Controls.Add(this.cb_Bodega);
            this.panel1.Controls.Add(this.lb_Proveedor);
            this.panel1.Controls.Add(this.cb_Moneda);
            this.panel1.Controls.Add(this.lb_Tipocompra);
            this.panel1.Location = new System.Drawing.Point(31, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 167);
            this.panel1.TabIndex = 13;
            // 
            // tx_Nocompra
            // 
            this.tx_Nocompra.Enabled = false;
            this.tx_Nocompra.Location = new System.Drawing.Point(449, 51);
            this.tx_Nocompra.Name = "tx_Nocompra";
            this.tx_Nocompra.Size = new System.Drawing.Size(93, 20);
            this.tx_Nocompra.TabIndex = 14;
            // 
            // lb_nocompra
            // 
            this.lb_nocompra.AutoSize = true;
            this.lb_nocompra.Location = new System.Drawing.Point(310, 58);
            this.lb_nocompra.Name = "lb_nocompra";
            this.lb_nocompra.Size = new System.Drawing.Size(100, 13);
            this.lb_nocompra.TabIndex = 13;
            this.lb_nocompra.Text = "Orden de Compra #";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_Cantidad);
            this.panel2.Controls.Add(this.lb_Producto);
            this.panel2.Controls.Add(this.tx_Cantidad);
            this.panel2.Controls.Add(this.cb_Producto);
            this.panel2.Controls.Add(this.bt_Agregar);
            this.panel2.Location = new System.Drawing.Point(31, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 38);
            this.panel2.TabIndex = 14;
            // 
            // lb_Cantidad
            // 
            this.lb_Cantidad.AutoSize = true;
            this.lb_Cantidad.Location = new System.Drawing.Point(287, 12);
            this.lb_Cantidad.Name = "lb_Cantidad";
            this.lb_Cantidad.Size = new System.Drawing.Size(62, 13);
            this.lb_Cantidad.TabIndex = 4;
            this.lb_Cantidad.Text = "CANTIDAD";
            // 
            // lb_Producto
            // 
            this.lb_Producto.AutoSize = true;
            this.lb_Producto.Location = new System.Drawing.Point(3, 13);
            this.lb_Producto.Name = "lb_Producto";
            this.lb_Producto.Size = new System.Drawing.Size(50, 13);
            this.lb_Producto.TabIndex = 3;
            this.lb_Producto.Text = "Producto";
            // 
            // tx_Cantidad
            // 
            this.tx_Cantidad.Location = new System.Drawing.Point(376, 9);
            this.tx_Cantidad.Name = "tx_Cantidad";
            this.tx_Cantidad.Size = new System.Drawing.Size(118, 20);
            this.tx_Cantidad.TabIndex = 2;
            // 
            // cb_Producto
            // 
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(78, 9);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(203, 21);
            this.cb_Producto.TabIndex = 0;
            // 
            // dg_Detalle
            // 
            this.dg_Detalle.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Detalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg_Detalle.Location = new System.Drawing.Point(14, 0);
            this.dg_Detalle.Name = "dg_Detalle";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_Detalle.Size = new System.Drawing.Size(616, 214);
            this.dg_Detalle.TabIndex = 15;
            this.dg_Detalle.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_Detalle_RowsAdded);
            this.dg_Detalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_Detalle_RowsRemoved);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(5, 0);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(266, 42);
            this.barra1.TabIndex = 16;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_Total);
            this.panel3.Controls.Add(this.tx_Total);
            this.panel3.Controls.Add(this.dg_Detalle);
            this.panel3.Location = new System.Drawing.Point(6, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 248);
            this.panel3.TabIndex = 19;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(363, 227);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(31, 13);
            this.lb_Total.TabIndex = 17;
            this.lb_Total.Text = "Total";
            // 
            // tx_Total
            // 
            this.tx_Total.Location = new System.Drawing.Point(423, 220);
            this.tx_Total.Name = "tx_Total";
            this.tx_Total.Size = new System.Drawing.Size(100, 20);
            this.tx_Total.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 505);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dg_detallebuscar);
            this.panel4.Location = new System.Drawing.Point(23, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 423);
            this.panel4.TabIndex = 1;
            // 
            // dg_detallebuscar
            // 
            this.dg_detallebuscar.AllowUserToAddRows = false;
            this.dg_detallebuscar.AllowUserToDeleteRows = false;
            this.dg_detallebuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detallebuscar.Location = new System.Drawing.Point(3, 50);
            this.dg_detallebuscar.Name = "dg_detallebuscar";
            this.dg_detallebuscar.ReadOnly = true;
            this.dg_detallebuscar.Size = new System.Drawing.Size(658, 370);
            this.dg_detallebuscar.TabIndex = 0;
            // 
            // fr_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_comercial.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(710, 633);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barra1);
            this.Name = "fr_Compras";
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detallebuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tx_Fecha;
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.ComboBox cb_Tipocompra;
        private System.Windows.Forms.ComboBox cb_Proveedor;
        private System.Windows.Forms.ComboBox cb_Tipopago;
        private System.Windows.Forms.ComboBox cb_Bodega;
        private System.Windows.Forms.ComboBox cb_Moneda;
        private System.Windows.Forms.Label lb_Tipocompra;
        private System.Windows.Forms.Label lb_Proveedor;
        private System.Windows.Forms.Label lb_tipopago;
        private System.Windows.Forms.Label lb_Bodega;
        private System.Windows.Forms.Label lb_Moneda;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.TextBox tx_Cantidad;
        private System.Windows.Forms.DataGridView dg_Detalle;
        private Navegador.Barra barra1;
        private System.Windows.Forms.TextBox tx_Nocompra;
        private System.Windows.Forms.Label lb_nocompra;
        private System.Windows.Forms.Label lb_Cantidad;
        private System.Windows.Forms.Label lb_Producto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tx_Total;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg_detallebuscar;
        private System.Windows.Forms.Panel panel4;
    }
}

