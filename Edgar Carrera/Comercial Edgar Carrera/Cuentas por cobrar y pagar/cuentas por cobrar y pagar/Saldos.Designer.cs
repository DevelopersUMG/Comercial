﻿namespace cuentas_por_cobrar_y_pagar
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
            this.barra_cc = new Navegador.Barra();
            this.tab_cxp = new System.Windows.Forms.TabPage();
            this.barra1 = new Navegador.Barra();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_cobros = new System.Windows.Forms.DataGridView();
            this.lb_pregunta = new System.Windows.Forms.Label();
            this.dgv_cc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_acp = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_cp = new System.Windows.Forms.DataGridView();
            this.tab_Principal.SuspendLayout();
            this.tab_cxc.SuspendLayout();
            this.tab_cxp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cp)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Principal
            // 
            this.tab_Principal.Controls.Add(this.tab_cxc);
            this.tab_Principal.Controls.Add(this.tab_cxp);
            this.tab_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Principal.Location = new System.Drawing.Point(12, 27);
            this.tab_Principal.Name = "tab_Principal";
            this.tab_Principal.SelectedIndex = 0;
            this.tab_Principal.Size = new System.Drawing.Size(729, 570);
            this.tab_Principal.TabIndex = 0;
            // 
            // tab_cxc
            // 
            this.tab_cxc.BackColor = System.Drawing.Color.Transparent;
            this.tab_cxc.Controls.Add(this.label2);
            this.tab_cxc.Controls.Add(this.dgv_cobros);
            this.tab_cxc.Controls.Add(this.lb_pregunta);
            this.tab_cxc.Controls.Add(this.dgv_cc);
            this.tab_cxc.Controls.Add(this.barra_cc);
            this.tab_cxc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_cxc.Location = new System.Drawing.Point(4, 24);
            this.tab_cxc.Name = "tab_cxc";
            this.tab_cxc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cxc.Size = new System.Drawing.Size(721, 542);
            this.tab_cxc.TabIndex = 0;
            this.tab_cxc.Text = "Cuentas por cobrar";
            // 
            // barra_cc
            // 
            this.barra_cc.BackColor = System.Drawing.Color.Transparent;
            this.barra_cc.Location = new System.Drawing.Point(6, 2);
            this.barra_cc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.barra_cc.Name = "barra_cc";
            this.barra_cc.Size = new System.Drawing.Size(476, 55);
            this.barra_cc.TabIndex = 9;
            this.barra_cc.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra_cc_click_buscar_button);
            // 
            // tab_cxp
            // 
            this.tab_cxp.Controls.Add(this.label3);
            this.tab_cxp.Controls.Add(this.dgv_acp);
            this.tab_cxp.Controls.Add(this.label4);
            this.tab_cxp.Controls.Add(this.dgv_cp);
            this.tab_cxp.Controls.Add(this.barra1);
            this.tab_cxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_cxp.Location = new System.Drawing.Point(4, 24);
            this.tab_cxp.Name = "tab_cxp";
            this.tab_cxp.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cxp.Size = new System.Drawing.Size(721, 542);
            this.tab_cxp.TabIndex = 1;
            this.tab_cxp.Text = "Cuentas por Pagar";
            this.tab_cxp.UseVisualStyleBackColor = true;
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(14, 24);
            this.barra1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(635, 63);
            this.barra1.TabIndex = 12;
            this.barra1.click_buscar_button += new Navegador.Barra.delegadoButton(this.barra1_click_buscar_button);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Abonos ";
            // 
            // dgv_cobros
            // 
            this.dgv_cobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cobros.Location = new System.Drawing.Point(23, 316);
            this.dgv_cobros.Name = "dgv_cobros";
            this.dgv_cobros.Size = new System.Drawing.Size(677, 160);
            this.dgv_cobros.TabIndex = 14;
            this.dgv_cobros.Visible = false;
            // 
            // lb_pregunta
            // 
            this.lb_pregunta.AutoSize = true;
            this.lb_pregunta.Location = new System.Drawing.Point(20, 66);
            this.lb_pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pregunta.Name = "lb_pregunta";
            this.lb_pregunta.Size = new System.Drawing.Size(52, 15);
            this.lb_pregunta.TabIndex = 13;
            this.lb_pregunta.Text = "Cargos";
            // 
            // dgv_cc
            // 
            this.dgv_cc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cc.Location = new System.Drawing.Point(23, 97);
            this.dgv_cc.Name = "dgv_cc";
            this.dgv_cc.Size = new System.Drawing.Size(677, 164);
            this.dgv_cc.TabIndex = 12;
            this.dgv_cc.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Abonos ";
            // 
            // dgv_acp
            // 
            this.dgv_acp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_acp.Location = new System.Drawing.Point(17, 357);
            this.dgv_acp.Name = "dgv_acp";
            this.dgv_acp.Size = new System.Drawing.Size(677, 160);
            this.dgv_acp.TabIndex = 16;
            this.dgv_acp.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cargos";
            // 
            // dgv_cp
            // 
            this.dgv_cp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cp.Location = new System.Drawing.Point(14, 149);
            this.dgv_cp.Name = "dgv_cp";
            this.dgv_cp.Size = new System.Drawing.Size(677, 164);
            this.dgv_cp.TabIndex = 14;
            this.dgv_cp.Visible = false;
            // 
            // Saldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cuentas_por_cobrar_y_pagar.Properties.Resources.fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 609);
            this.Controls.Add(this.tab_Principal);
            this.DoubleBuffered = true;
            this.Name = "Saldos";
            this.Text = "Saldos";
            this.tab_Principal.ResumeLayout(false);
            this.tab_cxc.ResumeLayout(false);
            this.tab_cxc.PerformLayout();
            this.tab_cxp.ResumeLayout(false);
            this.tab_cxp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cc)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_cobros;
        private System.Windows.Forms.Label lb_pregunta;
        private System.Windows.Forms.DataGridView dgv_cc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_acp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_cp;
    }
}