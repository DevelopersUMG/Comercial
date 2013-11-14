﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Collections;

namespace Area_comercial
{
    public partial class Saldos : Form
    {
        public Saldos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        private void barra_cc_click_buscar_button()
        {
             

                

                    dgv_cc.DataSource = db.consulta_DataGridView("SELECT cp.idtbm_cuenta_por_cobrar, cp.idtbm_bodega as'Bodega',cp.serie_factura as'Serie',cp.no_factura as 'Numero',c.idtbm_transacciones as 'ID Transaccion',cp.fecha_emision as 'Emision',cp.fecha_vence as 'Vencimiento',cp.total_cuenta_por_cobrar as 'Valor',cp.saldo_cuenta_por_cobrar as 'Saldo', f.idtbm_cliente as 'Cliente' from tbm_cuenta_por_cobrar cp, tbm_cobros c,tbm_factura f where cp.idtbm_cuenta_por_cobrar = c.idtbm_cuenta_por_cobrar and cp.no_factura = f.no_factura and cp.serie_factura = f.serie_factura");
                    dgv_cc.Columns[0].Visible = false;
                   
                    dgv_cc.Visible = true;
                    lbl_c.Visible = true;


                    dgv_cobros.DataSource =db.consulta_DataGridView("SELECT cp.idtbm_cuenta_por_cobrar, c.idtbm_bodega as'Bodega',c.serie_factura as'Serie',c.no_factura as 'Numero',c.idtbm_transacciones as 'ID Transaccion',cp.fecha_emision as 'Emision',cp.fecha_vence as 'Vencimiento',c.abono as 'Valor',cp.saldo_cuenta_por_cobrar as 'Saldo', f.idtbm_cliente as 'Cliente' from tbm_cuenta_por_cobrar cp, tbm_cobros c,tbm_factura f where cp.idtbm_cuenta_por_cobrar = c.idtbm_cuenta_por_cobrar and cp.no_factura = f.no_factura and cp.serie_factura = f.serie_factura");
                    dgv_cobros.Columns[0].Visible = false;
                   
                    dgv_cobros.Visible = true;
                    lbl_a.Visible = true;
                    
                
                
                      
                    }

        private void barra1_click_buscar_button()
        {
            dgv_cp.DataSource = db.consulta_DataGridView("SELECT cp.idtbm_cuenta_por_pagar,cp.idtbm_bodega as 'Bodega',cp.no_compra as'Compra',p.idtbm_transacciones as 'ID Transaccion',cp.fecha_emision as 'Emision',cp.fecha_vence as 'Vencimiento',cp.total_cuenta_por_pagar as 'Valor',cp.saldo_cuenta_por_pagar as 'Saldo',tc.idtbm_proveedor  as 'Proveedor' from tbm_cuenta_por_pagar cp, tbm_pagos p,tbm_compra tc where cp.idtbm_cuenta_por_pagar = p.idtbm_cuenta_por_pagar and cp.no_compra = tc.no_compra ");
            dgv_cp.Columns[0].Visible = false;

            dgv_cp.Visible = true;
            lbl_cargos.Visible = true;
            dgv_acp.DataSource = db.consulta_DataGridView("SELECT c.idtbm_cuenta_por_pagar, c.idtbm_bodega as'Bodega',c.no_compra as 'Compra',c.idtbm_transacciones as 'ID Transaccion',c.fecha as 'Fecha',c.abono as 'Valor',cp.saldo_cuenta_por_pagar as 'Saldo', tc.idtbm_proveedor as 'Proveedor' from tbm_cuenta_por_pagar cp, tbm_pagos c,tbm_compra tc where cp.idtbm_cuenta_por_pagar = c.idtbm_cuenta_por_pagar and tc.no_compra = c.no_compra");
            dgv_acp.Columns[0].Visible = false;

            dgv_acp.Visible = true;
            lbl_abonos.Visible = true;
        }

                
            
        }
        }

       

    

