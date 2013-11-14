namespace Area_comercial
{
    partial class fr_Recepcion_de_producto
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
            this.tx_Fechaemitida = new System.Windows.Forms.TextBox();
            this.lb_Bodega = new System.Windows.Forms.Label();
            this.lb_Fechaemitida = new System.Windows.Forms.Label();
            this.tx_Bodega = new System.Windows.Forms.TextBox();
            this.tx_Total = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.dg_Detalle = new System.Windows.Forms.DataGridView();
            this.tx_fechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.lb_Fechavencimiento = new System.Windows.Forms.Label();
            this.cb_Ordencompra = new System.Windows.Forms.ComboBox();
            this.cb_Tipoproducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Tipoproducto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tx_Fechaemitida);
            this.panel1.Controls.Add(this.lb_Bodega);
            this.panel1.Controls.Add(this.lb_Fechaemitida);
            this.panel1.Controls.Add(this.tx_Bodega);
            this.panel1.Controls.Add(this.tx_Total);
            this.panel1.Controls.Add(this.lb_Total);
            this.panel1.Controls.Add(this.dg_Detalle);
            this.panel1.Location = new System.Drawing.Point(21, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 361);
            this.panel1.TabIndex = 1;
            // 
            // tx_Fechaemitida
            // 
            this.tx_Fechaemitida.Enabled = false;
            this.tx_Fechaemitida.Location = new System.Drawing.Point(362, 61);
            this.tx_Fechaemitida.Name = "tx_Fechaemitida";
            this.tx_Fechaemitida.Size = new System.Drawing.Size(279, 20);
            this.tx_Fechaemitida.TabIndex = 10;
            // 
            // lb_Bodega
            // 
            this.lb_Bodega.AutoSize = true;
            this.lb_Bodega.Location = new System.Drawing.Point(58, 64);
            this.lb_Bodega.Name = "lb_Bodega";
            this.lb_Bodega.Size = new System.Drawing.Size(44, 13);
            this.lb_Bodega.TabIndex = 7;
            this.lb_Bodega.Text = "Bodega";
            // 
            // lb_Fechaemitida
            // 
            this.lb_Fechaemitida.AutoSize = true;
            this.lb_Fechaemitida.Location = new System.Drawing.Point(242, 64);
            this.lb_Fechaemitida.Name = "lb_Fechaemitida";
            this.lb_Fechaemitida.Size = new System.Drawing.Size(74, 13);
            this.lb_Fechaemitida.TabIndex = 9;
            this.lb_Fechaemitida.Text = "Fecha Emitida";
            // 
            // tx_Bodega
            // 
            this.tx_Bodega.Enabled = false;
            this.tx_Bodega.Location = new System.Drawing.Point(122, 61);
            this.tx_Bodega.Name = "tx_Bodega";
            this.tx_Bodega.Size = new System.Drawing.Size(100, 20);
            this.tx_Bodega.TabIndex = 8;
            // 
            // tx_Total
            // 
            this.tx_Total.Enabled = false;
            this.tx_Total.Location = new System.Drawing.Point(479, 337);
            this.tx_Total.Name = "tx_Total";
            this.tx_Total.Size = new System.Drawing.Size(90, 20);
            this.tx_Total.TabIndex = 6;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(412, 340);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(42, 13);
            this.lb_Total.TabIndex = 5;
            this.lb_Total.Text = "TOTAL";
            // 
            // dg_Detalle
            // 
            this.dg_Detalle.AllowUserToAddRows = false;
            this.dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Detalle.Location = new System.Drawing.Point(96, 87);
            this.dg_Detalle.Name = "dg_Detalle";
            this.dg_Detalle.Size = new System.Drawing.Size(545, 235);
            this.dg_Detalle.TabIndex = 4;
            // 
            // tx_fechavencimiento
            // 
            this.tx_fechavencimiento.Location = new System.Drawing.Point(278, 38);
            this.tx_fechavencimiento.Name = "tx_fechavencimiento";
            this.tx_fechavencimiento.Size = new System.Drawing.Size(319, 20);
            this.tx_fechavencimiento.TabIndex = 12;
            // 
            // lb_Fechavencimiento
            // 
            this.lb_Fechavencimiento.AutoSize = true;
            this.lb_Fechavencimiento.Location = new System.Drawing.Point(42, 38);
            this.lb_Fechavencimiento.Name = "lb_Fechavencimiento";
            this.lb_Fechavencimiento.Size = new System.Drawing.Size(152, 13);
            this.lb_Fechavencimiento.TabIndex = 11;
            this.lb_Fechavencimiento.Text = "Fecha de Vencimiento Factura";
            // 
            // cb_Ordencompra
            // 
            this.cb_Ordencompra.FormattingEnabled = true;
            this.cb_Ordencompra.Location = new System.Drawing.Point(499, 9);
            this.cb_Ordencompra.Name = "cb_Ordencompra";
            this.cb_Ordencompra.Size = new System.Drawing.Size(121, 21);
            this.cb_Ordencompra.TabIndex = 3;
            this.cb_Ordencompra.SelectionChangeCommitted += new System.EventHandler(this.cb_Ordencompra_SelectionChangeCommitted);
            // 
            // cb_Tipoproducto
            // 
            this.cb_Tipoproducto.FormattingEnabled = true;
            this.cb_Tipoproducto.Items.AddRange(new object[] {
            "Materia Prima",
            "Producto Finalizado"});
            this.cb_Tipoproducto.Location = new System.Drawing.Point(160, 3);
            this.cb_Tipoproducto.Name = "cb_Tipoproducto";
            this.cb_Tipoproducto.Size = new System.Drawing.Size(177, 21);
            this.cb_Tipoproducto.TabIndex = 2;
            this.cb_Tipoproducto.SelectionChangeCommitted += new System.EventHandler(this.cb_Tipoproducto_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Orden de Compra #";
            // 
            // lb_Tipoproducto
            // 
            this.lb_Tipoproducto.AutoSize = true;
            this.lb_Tipoproducto.Location = new System.Drawing.Point(14, 12);
            this.lb_Tipoproducto.Name = "lb_Tipoproducto";
            this.lb_Tipoproducto.Size = new System.Drawing.Size(74, 13);
            this.lb_Tipoproducto.TabIndex = 0;
            this.lb_Tipoproducto.Text = "Tipo Producto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tx_fechavencimiento);
            this.panel2.Controls.Add(this.lb_Tipoproducto);
            this.panel2.Controls.Add(this.lb_Fechavencimiento);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_Tipoproducto);
            this.panel2.Controls.Add(this.cb_Ordencompra);
            this.panel2.Location = new System.Drawing.Point(24, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 73);
            this.panel2.TabIndex = 13;
            // 
            // fr_Recepcion_de_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_comercial.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(709, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra1);
            this.Name = "fr_Recepcion_de_producto";
            this.Text = "Recepcion de producto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tipoproducto;
        private System.Windows.Forms.ComboBox cb_Ordencompra;
        private System.Windows.Forms.ComboBox cb_Tipoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_Detalle;
        private System.Windows.Forms.TextBox tx_Total;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.TextBox tx_Bodega;
        private System.Windows.Forms.Label lb_Bodega;
        private System.Windows.Forms.TextBox tx_Fechaemitida;
        private System.Windows.Forms.Label lb_Fechaemitida;
        private System.Windows.Forms.Label lb_Fechavencimiento;
        private System.Windows.Forms.DateTimePicker tx_fechavencimiento;
        private System.Windows.Forms.Panel panel2;
    }
}