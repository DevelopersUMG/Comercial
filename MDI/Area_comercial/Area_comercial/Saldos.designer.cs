namespace Area_comercial
{
    partial class Saldos
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
            this.tab_Principal = new System.Windows.Forms.TabControl();
            this.tab_cxc = new System.Windows.Forms.TabPage();
            this.lbl_a = new System.Windows.Forms.Label();
            this.dgv_cobros = new System.Windows.Forms.DataGridView();
            this.lbl_c = new System.Windows.Forms.Label();
            this.dgv_cc = new System.Windows.Forms.DataGridView();
            this.barra_cc = new Navegador.Barra();
            this.tab_cxp = new System.Windows.Forms.TabPage();
            this.lbl_abonos = new System.Windows.Forms.Label();
            this.dgv_acp = new System.Windows.Forms.DataGridView();
            this.lbl_cargos = new System.Windows.Forms.Label();
            this.dgv_cp = new System.Windows.Forms.DataGridView();
            this.barra1 = new Navegador.Barra();
            this.tab_Principal.SuspendLayout();
            this.tab_cxc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cc)).BeginInit();
            this.tab_cxp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cp)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Principal
            // 
            this.tab_Principal.Controls.Add(this.tab_cxc);
            this.tab_Principal.Controls.Add(this.tab_cxp);
            this.tab_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Principal.Location = new System.Drawing.Point(16, 33);
            this.tab_Principal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Principal.Name = "tab_Principal";
            this.tab_Principal.SelectedIndex = 0;
            this.tab_Principal.Size = new System.Drawing.Size(972, 702);
            this.tab_Principal.TabIndex = 0;
            // 
            // tab_cxc
            // 
            this.tab_cxc.BackColor = System.Drawing.Color.White;
            this.tab_cxc.Controls.Add(this.lbl_a);
            this.tab_cxc.Controls.Add(this.dgv_cobros);
            this.tab_cxc.Controls.Add(this.lbl_c);
            this.tab_cxc.Controls.Add(this.dgv_cc);
            this.tab_cxc.Controls.Add(this.barra_cc);
            this.tab_cxc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_cxc.Location = new System.Drawing.Point(4, 27);
            this.tab_cxc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_cxc.Name = "tab_cxc";
            this.tab_cxc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_cxc.Size = new System.Drawing.Size(964, 671);
            this.tab_cxc.TabIndex = 0;
            this.tab_cxc.Text = "Cuentas por cobrar";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(27, 351);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(70, 18);
            this.lbl_a.TabIndex = 15;
            this.lbl_a.Text = "Abonos ";
            this.lbl_a.Visible = false;
            // 
            // dgv_cobros
            // 
            this.dgv_cobros.AllowUserToAddRows = false;
            this.dgv_cobros.AllowUserToDeleteRows = false;
            this.dgv_cobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cobros.Location = new System.Drawing.Point(31, 389);
            this.dgv_cobros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cobros.Name = "dgv_cobros";
            this.dgv_cobros.ReadOnly = true;
            this.dgv_cobros.Size = new System.Drawing.Size(903, 197);
            this.dgv_cobros.TabIndex = 14;
            this.dgv_cobros.Visible = false;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(27, 81);
            this.lbl_c.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(63, 18);
            this.lbl_c.TabIndex = 13;
            this.lbl_c.Text = "Cargos";
            this.lbl_c.Visible = false;
            // 
            // dgv_cc
            // 
            this.dgv_cc.AllowUserToAddRows = false;
            this.dgv_cc.AllowUserToDeleteRows = false;
            this.dgv_cc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cc.Location = new System.Drawing.Point(31, 119);
            this.dgv_cc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cc.Name = "dgv_cc";
            this.dgv_cc.ReadOnly = true;
            this.dgv_cc.Size = new System.Drawing.Size(903, 202);
            this.dgv_cc.TabIndex = 12;
            this.dgv_cc.Visible = false;
            this.dgv_cc.DoubleClick += new System.EventHandler(this.dgv_cp_DoubleClick);
            // 
            // barra_cc
            // 
            this.barra_cc.BackColor = System.Drawing.Color.Transparent;
            this.barra_cc.Location = new System.Drawing.Point(8, 2);
            this.barra_cc.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.barra_cc.Name = "barra_cc";
            this.barra_cc.Size = new System.Drawing.Size(635, 68);
            this.barra_cc.TabIndex = 9;
            this.barra_cc.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra_cc_click_buscar_button);
            this.barra_cc.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra_cc_click_imprimir_button);
            // 
            // tab_cxp
            // 
            this.tab_cxp.Controls.Add(this.lbl_abonos);
            this.tab_cxp.Controls.Add(this.dgv_acp);
            this.tab_cxp.Controls.Add(this.lbl_cargos);
            this.tab_cxp.Controls.Add(this.dgv_cp);
            this.tab_cxp.Controls.Add(this.barra1);
            this.tab_cxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_cxp.Location = new System.Drawing.Point(4, 27);
            this.tab_cxp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_cxp.Name = "tab_cxp";
            this.tab_cxp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_cxp.Size = new System.Drawing.Size(964, 671);
            this.tab_cxp.TabIndex = 1;
            this.tab_cxp.Text = "Cuentas por Pagar";
            this.tab_cxp.UseVisualStyleBackColor = true;
            // 
            // lbl_abonos
            // 
            this.lbl_abonos.AutoSize = true;
            this.lbl_abonos.Location = new System.Drawing.Point(19, 401);
            this.lbl_abonos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_abonos.Name = "lbl_abonos";
            this.lbl_abonos.Size = new System.Drawing.Size(70, 18);
            this.lbl_abonos.TabIndex = 17;
            this.lbl_abonos.Text = "Abonos ";
            this.lbl_abonos.Visible = false;
            // 
            // dgv_acp
            // 
            this.dgv_acp.AllowUserToAddRows = false;
            this.dgv_acp.AllowUserToDeleteRows = false;
            this.dgv_acp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_acp.Location = new System.Drawing.Point(23, 439);
            this.dgv_acp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_acp.Name = "dgv_acp";
            this.dgv_acp.ReadOnly = true;
            this.dgv_acp.Size = new System.Drawing.Size(903, 197);
            this.dgv_acp.TabIndex = 16;
            this.dgv_acp.Visible = false;
            // 
            // lbl_cargos
            // 
            this.lbl_cargos.AutoSize = true;
            this.lbl_cargos.Location = new System.Drawing.Point(15, 145);
            this.lbl_cargos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cargos.Name = "lbl_cargos";
            this.lbl_cargos.Size = new System.Drawing.Size(63, 18);
            this.lbl_cargos.TabIndex = 15;
            this.lbl_cargos.Text = "Cargos";
            this.lbl_cargos.Visible = false;
            // 
            // dgv_cp
            // 
            this.dgv_cp.AllowUserToAddRows = false;
            this.dgv_cp.AllowUserToDeleteRows = false;
            this.dgv_cp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cp.Location = new System.Drawing.Point(19, 183);
            this.dgv_cp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cp.Name = "dgv_cp";
            this.dgv_cp.ReadOnly = true;
            this.dgv_cp.Size = new System.Drawing.Size(903, 202);
            this.dgv_cp.TabIndex = 14;
            this.dgv_cp.Visible = false;
            this.dgv_cp.DoubleClick += new System.EventHandler(this.dgv_cp_DoubleClick_1);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(11, 14);
            this.barra1.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(847, 78);
            this.barra1.TabIndex = 12;
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            this.barra1.click_imprimir_button += new Navegador.Barra.delegadoButton(this.barra1_click_imprimir_button);
            // 
            // Saldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Area_comercial.Properties.Resources.fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 750);
            this.Controls.Add(this.tab_Principal);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Saldos";
            this.Text = "Saldos";
            this.tab_Principal.ResumeLayout(false);
            this.tab_cxc.ResumeLayout(false);
            this.tab_cxc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cc)).EndInit();
            this.tab_cxp.ResumeLayout(false);
            this.tab_cxp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Principal;
        private System.Windows.Forms.TabPage tab_cxc;
        private Navegador.Barra barra_cc;
        private System.Windows.Forms.TabPage tab_cxp;
        private Navegador.Barra barra1;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.DataGridView dgv_cobros;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.DataGridView dgv_cc;
        private System.Windows.Forms.Label lbl_abonos;
        private System.Windows.Forms.DataGridView dgv_acp;
        private System.Windows.Forms.Label lbl_cargos;
        private System.Windows.Forms.DataGridView dgv_cp;
    }
}