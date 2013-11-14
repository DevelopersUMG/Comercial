namespace Area_comercial
{
    partial class frm_cuentras_por_pagar
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
            this.gpr_ingreso = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_nc = new System.Windows.Forms.TextBox();
            this.dtp_fv = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_vencimiento = new System.Windows.Forms.Label();
            this.dtp_fecha_emision = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_emision = new System.Windows.Forms.Label();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.tb_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_transaccion = new System.Windows.Forms.Label();
            this.tb_codigo_proveedor = new System.Windows.Forms.TextBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.lbl_documento_afectado = new System.Windows.Forms.Label();
            this.cmb_transaccion = new System.Windows.Forms.ComboBox();
            this.tb_tipo_compra = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.tb_saldo_actual = new System.Windows.Forms.TextBox();
            this.tb_abono = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grup_ = new System.Windows.Forms.GroupBox();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.group_fecha = new System.Windows.Forms.GroupBox();
            this.dtp_fechaconsulta = new System.Windows.Forms.DateTimePicker();
            this.lbl_selecciondefecha = new System.Windows.Forms.Label();
            this.barra1 = new Navegador.Barra();
            this.gpr_ingreso.SuspendLayout();
            this.grup_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.group_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpr_ingreso
            // 
            this.gpr_ingreso.BackColor = System.Drawing.Color.Transparent;
            this.gpr_ingreso.Controls.Add(this.label1);
            this.gpr_ingreso.Controls.Add(this.tb_b);
            this.gpr_ingreso.Controls.Add(this.tb_nc);
            this.gpr_ingreso.Controls.Add(this.dtp_fv);
            this.gpr_ingreso.Controls.Add(this.lbl_fecha_vencimiento);
            this.gpr_ingreso.Controls.Add(this.dtp_fecha_emision);
            this.gpr_ingreso.Controls.Add(this.lbl_fecha_emision);
            this.gpr_ingreso.Controls.Add(this.tb_descripcion);
            this.gpr_ingreso.Controls.Add(this.lbl_abono);
            this.gpr_ingreso.Controls.Add(this.lbl_descripcion);
            this.gpr_ingreso.Controls.Add(this.tb_nombre_proveedor);
            this.gpr_ingreso.Controls.Add(this.lbl_transaccion);
            this.gpr_ingreso.Controls.Add(this.tb_codigo_proveedor);
            this.gpr_ingreso.Controls.Add(this.lbl_Proveedor);
            this.gpr_ingreso.Controls.Add(this.lbl_documento_afectado);
            this.gpr_ingreso.Controls.Add(this.cmb_transaccion);
            this.gpr_ingreso.Controls.Add(this.tb_tipo_compra);
            this.gpr_ingreso.Controls.Add(this.btn_cancelar);
            this.gpr_ingreso.Controls.Add(this.btn_aceptar);
            this.gpr_ingreso.Controls.Add(this.tb_saldo_actual);
            this.gpr_ingreso.Controls.Add(this.tb_abono);
            this.gpr_ingreso.Controls.Add(this.lbl_saldo);
            this.gpr_ingreso.Controls.Add(this.label2);
            this.gpr_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpr_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpr_ingreso.Location = new System.Drawing.Point(34, 171);
            this.gpr_ingreso.Name = "gpr_ingreso";
            this.gpr_ingreso.Size = new System.Drawing.Size(635, 237);
            this.gpr_ingreso.TabIndex = 22;
            this.gpr_ingreso.TabStop = false;
            this.gpr_ingreso.Text = "Abono a Cuenta por pagar";
            this.gpr_ingreso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bodega:";
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(556, 42);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(44, 21);
            this.tb_b.TabIndex = 27;
            // 
            // tb_nc
            // 
            this.tb_nc.Location = new System.Drawing.Point(220, 91);
            this.tb_nc.Name = "tb_nc";
            this.tb_nc.Size = new System.Drawing.Size(82, 21);
            this.tb_nc.TabIndex = 26;
            // 
            // dtp_fv
            // 
            this.dtp_fv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fv.Location = new System.Drawing.Point(493, 96);
            this.dtp_fv.Name = "dtp_fv";
            this.dtp_fv.Size = new System.Drawing.Size(107, 21);
            this.dtp_fv.TabIndex = 25;
            this.dtp_fv.Value = new System.DateTime(2013, 11, 9, 7, 53, 32, 0);
            // 
            // lbl_fecha_vencimiento
            // 
            this.lbl_fecha_vencimiento.AutoSize = true;
            this.lbl_fecha_vencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_vencimiento.Location = new System.Drawing.Point(338, 102);
            this.lbl_fecha_vencimiento.Name = "lbl_fecha_vencimiento";
            this.lbl_fecha_vencimiento.Size = new System.Drawing.Size(149, 15);
            this.lbl_fecha_vencimiento.TabIndex = 24;
            this.lbl_fecha_vencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtp_fecha_emision
            // 
            this.dtp_fecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_emision.Location = new System.Drawing.Point(493, 69);
            this.dtp_fecha_emision.Name = "dtp_fecha_emision";
            this.dtp_fecha_emision.Size = new System.Drawing.Size(107, 21);
            this.dtp_fecha_emision.TabIndex = 23;
            this.dtp_fecha_emision.Value = new System.DateTime(2013, 11, 13, 0, 0, 0, 0);
            // 
            // lbl_fecha_emision
            // 
            this.lbl_fecha_emision.AutoSize = true;
            this.lbl_fecha_emision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_emision.Location = new System.Drawing.Point(365, 74);
            this.lbl_fecha_emision.Name = "lbl_fecha_emision";
            this.lbl_fecha_emision.Size = new System.Drawing.Size(122, 15);
            this.lbl_fecha_emision.TabIndex = 22;
            this.lbl_fecha_emision.Text = "Fecha de Emision";
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(116, 128);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(484, 21);
            this.tb_descripcion.TabIndex = 19;
            this.tb_descripcion.TextChanged += new System.EventHandler(this.tb_descripcion_TextChanged);
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abono.Location = new System.Drawing.Point(255, 210);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(47, 15);
            this.lbl_abono.TabIndex = 21;
            this.lbl_abono.Text = "Abono";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 131);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(83, 15);
            this.lbl_descripcion.TabIndex = 20;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // tb_nombre_proveedor
            // 
            this.tb_nombre_proveedor.Location = new System.Drawing.Point(220, 166);
            this.tb_nombre_proveedor.Name = "tb_nombre_proveedor";
            this.tb_nombre_proveedor.Size = new System.Drawing.Size(188, 21);
            this.tb_nombre_proveedor.TabIndex = 18;
            // 
            // lbl_transaccion
            // 
            this.lbl_transaccion.AutoSize = true;
            this.lbl_transaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transaccion.Location = new System.Drawing.Point(13, 54);
            this.lbl_transaccion.Name = "lbl_transaccion";
            this.lbl_transaccion.Size = new System.Drawing.Size(85, 15);
            this.lbl_transaccion.TabIndex = 17;
            this.lbl_transaccion.Text = "Transaccion";
            // 
            // tb_codigo_proveedor
            // 
            this.tb_codigo_proveedor.Location = new System.Drawing.Point(139, 166);
            this.tb_codigo_proveedor.Name = "tb_codigo_proveedor";
            this.tb_codigo_proveedor.Size = new System.Drawing.Size(66, 21);
            this.tb_codigo_proveedor.TabIndex = 15;
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proveedor.Location = new System.Drawing.Point(42, 169);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(72, 15);
            this.lbl_Proveedor.TabIndex = 14;
            this.lbl_Proveedor.Text = "Proveedor";
            // 
            // lbl_documento_afectado
            // 
            this.lbl_documento_afectado.AutoSize = true;
            this.lbl_documento_afectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento_afectado.Location = new System.Drawing.Point(12, 94);
            this.lbl_documento_afectado.Name = "lbl_documento_afectado";
            this.lbl_documento_afectado.Size = new System.Drawing.Size(151, 15);
            this.lbl_documento_afectado.TabIndex = 13;
            this.lbl_documento_afectado.Text = "Documento que afecta";
            // 
            // cmb_transaccion
            // 
            this.cmb_transaccion.FormattingEnabled = true;
            this.cmb_transaccion.Location = new System.Drawing.Point(139, 50);
            this.cmb_transaccion.Name = "cmb_transaccion";
            this.cmb_transaccion.Size = new System.Drawing.Size(164, 23);
            this.cmb_transaccion.TabIndex = 12;
            // 
            // tb_tipo_compra
            // 
            this.tb_tipo_compra.Location = new System.Drawing.Point(170, 91);
            this.tb_tipo_compra.Name = "tb_tipo_compra";
            this.tb_tipo_compra.Size = new System.Drawing.Size(44, 21);
            this.tb_tipo_compra.TabIndex = 11;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Area_comercial.Properties.Resources.glyphicons_192_circle_remove;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.Location = new System.Drawing.Point(462, 169);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 41);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = global::Area_comercial.Properties.Resources.glyphicons_193_circle_ok;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_aceptar.Location = new System.Drawing.Point(543, 169);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 41);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // tb_saldo_actual
            // 
            this.tb_saldo_actual.Location = new System.Drawing.Point(114, 207);
            this.tb_saldo_actual.Name = "tb_saldo_actual";
            this.tb_saldo_actual.Size = new System.Drawing.Size(120, 21);
            this.tb_saldo_actual.TabIndex = 7;
            // 
            // tb_abono
            // 
            this.tb_abono.Location = new System.Drawing.Point(308, 207);
            this.tb_abono.Name = "tb_abono";
            this.tb_abono.Size = new System.Drawing.Size(127, 21);
            this.tb_abono.TabIndex = 6;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(13, 213);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(95, 15);
            this.lbl_saldo.TabIndex = 5;
            this.lbl_saldo.Text = "Saldo  Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // grup_
            // 
            this.grup_.BackColor = System.Drawing.Color.Transparent;
            this.grup_.Controls.Add(this.dgv_consulta);
            this.grup_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_.Location = new System.Drawing.Point(15, 414);
            this.grup_.Name = "grup_";
            this.grup_.Size = new System.Drawing.Size(722, 182);
            this.grup_.TabIndex = 21;
            this.grup_.TabStop = false;
            this.grup_.Text = "Detalle de documentos a cobrar ";
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Location = new System.Drawing.Point(16, 20);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.Size = new System.Drawing.Size(686, 145);
            this.dgv_consulta.TabIndex = 0;
            // 
            // group_fecha
            // 
            this.group_fecha.BackColor = System.Drawing.Color.Transparent;
            this.group_fecha.Controls.Add(this.dtp_fechaconsulta);
            this.group_fecha.Controls.Add(this.lbl_selecciondefecha);
            this.group_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.group_fecha.Location = new System.Drawing.Point(34, 72);
            this.group_fecha.Name = "group_fecha";
            this.group_fecha.Size = new System.Drawing.Size(337, 54);
            this.group_fecha.TabIndex = 20;
            this.group_fecha.TabStop = false;
            // 
            // dtp_fechaconsulta
            // 
            this.dtp_fechaconsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaconsulta.Location = new System.Drawing.Point(220, 19);
            this.dtp_fechaconsulta.Name = "dtp_fechaconsulta";
            this.dtp_fechaconsulta.Size = new System.Drawing.Size(107, 20);
            this.dtp_fechaconsulta.TabIndex = 3;
            this.dtp_fechaconsulta.Value = new System.DateTime(2013, 11, 9, 7, 53, 32, 0);
            // 
            // lbl_selecciondefecha
            // 
            this.lbl_selecciondefecha.AutoSize = true;
            this.lbl_selecciondefecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecciondefecha.Location = new System.Drawing.Point(6, 20);
            this.lbl_selecciondefecha.Name = "lbl_selecciondefecha";
            this.lbl_selecciondefecha.Size = new System.Drawing.Size(208, 15);
            this.lbl_selecciondefecha.TabIndex = 2;
            this.lbl_selecciondefecha.Text = "Seleccione la fecha a consultar";
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(34, 12);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(268, 42);
            this.barra1.TabIndex = 19;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.nuevo);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.insertar);
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.consulta);
            this.barra1.click_eliminar_button += new Navegador.Barra.delegadoButton(this.cancela);
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            // 
            // frm_cuentras_por_pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_comercial.Properties.Resources.fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 609);
            this.Controls.Add(this.gpr_ingreso);
            this.Controls.Add(this.grup_);
            this.Controls.Add(this.group_fecha);
            this.Controls.Add(this.barra1);
            this.DoubleBuffered = true;
            this.Name = "frm_cuentras_por_pagar";
            this.Text = "Cuentas por Pagar";
            this.gpr_ingreso.ResumeLayout(false);
            this.gpr_ingreso.PerformLayout();
            this.grup_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.group_fecha.ResumeLayout(false);
            this.group_fecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpr_ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_nc;
        private System.Windows.Forms.DateTimePicker dtp_fv;
        private System.Windows.Forms.Label lbl_fecha_vencimiento;
        private System.Windows.Forms.DateTimePicker dtp_fecha_emision;
        private System.Windows.Forms.Label lbl_fecha_emision;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.Label lbl_abono;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox tb_nombre_proveedor;
        private System.Windows.Forms.Label lbl_transaccion;
        private System.Windows.Forms.TextBox tb_codigo_proveedor;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.Label lbl_documento_afectado;
        private System.Windows.Forms.ComboBox cmb_transaccion;
        private System.Windows.Forms.TextBox tb_tipo_compra;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox tb_saldo_actual;
        private System.Windows.Forms.TextBox tb_abono;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grup_;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.GroupBox group_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fechaconsulta;
        private System.Windows.Forms.Label lbl_selecciondefecha;
        private Navegador.Barra barra1;
    }
}