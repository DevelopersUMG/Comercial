namespace Compras2
{
    partial class fr_Compra_Servicio
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
            this.lb_Moneda = new System.Windows.Forms.Label();
            this.cb_Moneda = new System.Windows.Forms.ComboBox();
            this.cb_Tipopago = new System.Windows.Forms.ComboBox();
            this.lbl_Tipopago = new System.Windows.Forms.Label();
            this.cb_Bodega = new System.Windows.Forms.ComboBox();
            this.lb_Bodega = new System.Windows.Forms.Label();
            this.tx_Orden = new System.Windows.Forms.TextBox();
            this.tx_Valor = new System.Windows.Forms.TextBox();
            this.tx_Fechavence = new System.Windows.Forms.DateTimePicker();
            this.tx_Fechaactual = new System.Windows.Forms.DateTimePicker();
            this.cb_Proveedor = new System.Windows.Forms.ComboBox();
            this.lb_Noorden = new System.Windows.Forms.Label();
            this.cb_Concepto = new System.Windows.Forms.ComboBox();
            this.lb_Proveedor = new System.Windows.Forms.Label();
            this.lb_Concepto = new System.Windows.Forms.Label();
            this.lb_Fechaactual = new System.Windows.Forms.Label();
            this.lb_Valor = new System.Windows.Forms.Label();
            this.lb_Fechavence = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(27, 11);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 0;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb_Moneda);
            this.panel1.Controls.Add(this.cb_Moneda);
            this.panel1.Controls.Add(this.cb_Tipopago);
            this.panel1.Controls.Add(this.lbl_Tipopago);
            this.panel1.Controls.Add(this.cb_Bodega);
            this.panel1.Controls.Add(this.lb_Bodega);
            this.panel1.Controls.Add(this.tx_Orden);
            this.panel1.Controls.Add(this.tx_Valor);
            this.panel1.Controls.Add(this.tx_Fechavence);
            this.panel1.Controls.Add(this.tx_Fechaactual);
            this.panel1.Controls.Add(this.cb_Proveedor);
            this.panel1.Controls.Add(this.lb_Noorden);
            this.panel1.Controls.Add(this.cb_Concepto);
            this.panel1.Controls.Add(this.lb_Proveedor);
            this.panel1.Controls.Add(this.lb_Concepto);
            this.panel1.Controls.Add(this.lb_Fechaactual);
            this.panel1.Controls.Add(this.lb_Valor);
            this.panel1.Controls.Add(this.lb_Fechavence);
            this.panel1.Location = new System.Drawing.Point(36, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 296);
            this.panel1.TabIndex = 8;
            // 
            // lb_Moneda
            // 
            this.lb_Moneda.AutoSize = true;
            this.lb_Moneda.Location = new System.Drawing.Point(33, 102);
            this.lb_Moneda.Name = "lb_Moneda";
            this.lb_Moneda.Size = new System.Drawing.Size(46, 13);
            this.lb_Moneda.TabIndex = 18;
            this.lb_Moneda.Text = "Moneda";
            // 
            // cb_Moneda
            // 
            this.cb_Moneda.FormattingEnabled = true;
            this.cb_Moneda.Location = new System.Drawing.Point(124, 99);
            this.cb_Moneda.Name = "cb_Moneda";
            this.cb_Moneda.Size = new System.Drawing.Size(224, 21);
            this.cb_Moneda.TabIndex = 17;
            // 
            // cb_Tipopago
            // 
            this.cb_Tipopago.FormattingEnabled = true;
            this.cb_Tipopago.Location = new System.Drawing.Point(124, 72);
            this.cb_Tipopago.Name = "cb_Tipopago";
            this.cb_Tipopago.Size = new System.Drawing.Size(224, 21);
            this.cb_Tipopago.TabIndex = 16;
            // 
            // lbl_Tipopago
            // 
            this.lbl_Tipopago.AutoSize = true;
            this.lbl_Tipopago.Location = new System.Drawing.Point(44, 75);
            this.lbl_Tipopago.Name = "lbl_Tipopago";
            this.lbl_Tipopago.Size = new System.Drawing.Size(32, 13);
            this.lbl_Tipopago.TabIndex = 15;
            this.lbl_Tipopago.Text = "Pago";
            // 
            // cb_Bodega
            // 
            this.cb_Bodega.FormattingEnabled = true;
            this.cb_Bodega.Location = new System.Drawing.Point(124, 46);
            this.cb_Bodega.Name = "cb_Bodega";
            this.cb_Bodega.Size = new System.Drawing.Size(224, 21);
            this.cb_Bodega.TabIndex = 14;
            // 
            // lb_Bodega
            // 
            this.lb_Bodega.AutoSize = true;
            this.lb_Bodega.Location = new System.Drawing.Point(33, 49);
            this.lb_Bodega.Name = "lb_Bodega";
            this.lb_Bodega.Size = new System.Drawing.Size(44, 13);
            this.lb_Bodega.TabIndex = 13;
            this.lb_Bodega.Text = "Bodega";
            // 
            // tx_Orden
            // 
            this.tx_Orden.Enabled = false;
            this.tx_Orden.Location = new System.Drawing.Point(358, 7);
            this.tx_Orden.Name = "tx_Orden";
            this.tx_Orden.Size = new System.Drawing.Size(100, 20);
            this.tx_Orden.TabIndex = 12;
            // 
            // tx_Valor
            // 
            this.tx_Valor.Location = new System.Drawing.Point(124, 241);
            this.tx_Valor.Name = "tx_Valor";
            this.tx_Valor.Size = new System.Drawing.Size(98, 20);
            this.tx_Valor.TabIndex = 11;
            // 
            // tx_Fechavence
            // 
            this.tx_Fechavence.Location = new System.Drawing.Point(124, 184);
            this.tx_Fechavence.Name = "tx_Fechavence";
            this.tx_Fechavence.Size = new System.Drawing.Size(224, 20);
            this.tx_Fechavence.TabIndex = 10;
            // 
            // tx_Fechaactual
            // 
            this.tx_Fechaactual.Location = new System.Drawing.Point(124, 154);
            this.tx_Fechaactual.Name = "tx_Fechaactual";
            this.tx_Fechaactual.Size = new System.Drawing.Size(224, 20);
            this.tx_Fechaactual.TabIndex = 9;
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.Location = new System.Drawing.Point(124, 126);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.Size = new System.Drawing.Size(224, 21);
            this.cb_Proveedor.TabIndex = 8;
            // 
            // lb_Noorden
            // 
            this.lb_Noorden.AutoSize = true;
            this.lb_Noorden.Location = new System.Drawing.Point(270, 10);
            this.lb_Noorden.Name = "lb_Noorden";
            this.lb_Noorden.Size = new System.Drawing.Size(66, 13);
            this.lb_Noorden.TabIndex = 0;
            this.lb_Noorden.Text = "No. Orden #";
            // 
            // cb_Concepto
            // 
            this.cb_Concepto.FormattingEnabled = true;
            this.cb_Concepto.Location = new System.Drawing.Point(124, 214);
            this.cb_Concepto.Name = "cb_Concepto";
            this.cb_Concepto.Size = new System.Drawing.Size(309, 21);
            this.cb_Concepto.TabIndex = 6;
            // 
            // lb_Proveedor
            // 
            this.lb_Proveedor.AutoSize = true;
            this.lb_Proveedor.Location = new System.Drawing.Point(23, 124);
            this.lb_Proveedor.Name = "lb_Proveedor";
            this.lb_Proveedor.Size = new System.Drawing.Size(56, 13);
            this.lb_Proveedor.TabIndex = 1;
            this.lb_Proveedor.Text = "Proveedor";
            // 
            // lb_Concepto
            // 
            this.lb_Concepto.AutoSize = true;
            this.lb_Concepto.Location = new System.Drawing.Point(23, 214);
            this.lb_Concepto.Name = "lb_Concepto";
            this.lb_Concepto.Size = new System.Drawing.Size(53, 13);
            this.lb_Concepto.TabIndex = 5;
            this.lb_Concepto.Text = "Concepto";
            // 
            // lb_Fechaactual
            // 
            this.lb_Fechaactual.AutoSize = true;
            this.lb_Fechaactual.Location = new System.Drawing.Point(18, 154);
            this.lb_Fechaactual.Name = "lb_Fechaactual";
            this.lb_Fechaactual.Size = new System.Drawing.Size(69, 13);
            this.lb_Fechaactual.TabIndex = 2;
            this.lb_Fechaactual.Text = "Fecha actual";
            // 
            // lb_Valor
            // 
            this.lb_Valor.AutoSize = true;
            this.lb_Valor.Location = new System.Drawing.Point(33, 248);
            this.lb_Valor.Name = "lb_Valor";
            this.lb_Valor.Size = new System.Drawing.Size(31, 13);
            this.lb_Valor.TabIndex = 4;
            this.lb_Valor.Text = "Valor";
            // 
            // lb_Fechavence
            // 
            this.lb_Fechavence.AutoSize = true;
            this.lb_Fechavence.Location = new System.Drawing.Point(17, 184);
            this.lb_Fechavence.Name = "lb_Fechavence";
            this.lb_Fechavence.Size = new System.Drawing.Size(70, 13);
            this.lb_Fechavence.TabIndex = 3;
            this.lb_Fechavence.Text = "Fecha vence";
            // 
            // fr_Compra_Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compras2.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(650, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra1);
            this.Name = "fr_Compra_Servicio";
            this.Text = "Compra de Servicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tx_Valor;
        private System.Windows.Forms.DateTimePicker tx_Fechavence;
        private System.Windows.Forms.DateTimePicker tx_Fechaactual;
        private System.Windows.Forms.ComboBox cb_Proveedor;
        private System.Windows.Forms.Label lb_Noorden;
        private System.Windows.Forms.ComboBox cb_Concepto;
        private System.Windows.Forms.Label lb_Proveedor;
        private System.Windows.Forms.Label lb_Concepto;
        private System.Windows.Forms.Label lb_Fechaactual;
        private System.Windows.Forms.Label lb_Valor;
        private System.Windows.Forms.Label lb_Fechavence;
        private System.Windows.Forms.TextBox tx_Orden;
        private System.Windows.Forms.ComboBox cb_Bodega;
        private System.Windows.Forms.Label lb_Bodega;
        private System.Windows.Forms.ComboBox cb_Tipopago;
        private System.Windows.Forms.Label lbl_Tipopago;
        private System.Windows.Forms.Label lb_Moneda;
        private System.Windows.Forms.ComboBox cb_Moneda;
    }
}