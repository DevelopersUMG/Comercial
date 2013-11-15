using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Collections;
using Microsoft.Reporting.WinForms;

namespace Area_comercial
{
    public partial class Saldos : Form
    {
        public Saldos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        int fila;

        private void barra_cc_click_buscar_button()
        {
                    dgv_cc.DataSource = db.consulta_DataGridView("SELECT idtbm_cuenta_por_cobrar,idtbm_bodega as 'Bodega',serie_factura as 'Serie',no_factura as 'Numeo',fecha_emision as 'Emision',fecha_vence as 'Vencimiento',total_cuenta_por_cobrar as 'Tota',abono_cuenta_por_cobrar as 'Abono',saldo_cuenta_por_cobrar as 'Saldo'from tbm_cuenta_por_cobrar");
                    dgv_cc.Columns[0].Visible = false;

                    dgv_cc.Visible = true;
                    lbl_c.Visible=true;
                    lbl_cargos.Visible = true;
                   
                    
                    }

        private void barra1_click_buscar_button()
        {
            dgv_cp.DataSource = db.consulta_DataGridView("SELECT idtbm_cuenta_por_pagar,idtbm_bodega as 'Bodega',no_compra 'Numero de compra',fecha_emision as 'Emision',fecha_vence as 'Vencimiento',total_cuenta_por_pagar as 'Tota',abono_cuenta_por_pagar as 'Abono',saldo_cuenta_por_pagar as 'Saldo'from tbm_cuenta_por_pagar");
            dgv_cp.Columns[0].Visible = false;

            dgv_cp.Visible = true;
            lbl_cargos.Visible = true;
            

            dgv_acp.Visible = true;
            lbl_abonos.Visible = true;
        }

        private void dgv_cp_DoubleClick(object sender, EventArgs e)
        {
            fila = this.dgv_cc.CurrentRow.Index;
            string cuenta = this.dgv_cc.CurrentRow.Cells[0].Value.ToString();



            string query = "SELECT p.fecha AS 'Emision', p.abono AS 'Abono', p.descripcion AS 'Descripcion', t.nombre_transaccion AS 'Transaccion' FROM tbm_cobros p, tbm_transacciones t WHERE p.idtbm_transacciones = t.idtbm_transacciones AND p.idtbm_cuenta_por_cobrar =" + cuenta;

            dgv_cobros.DataSource = db.consulta_DataGridView(query);

            dgv_cobros.Visible = true;



        }

        private void dgv_cp_DoubleClick_1(object sender, EventArgs e)
        {
            fila = this.dgv_cp.CurrentRow.Index;
            string cuenta = this.dgv_cp.CurrentRow.Cells[0].Value.ToString();
            string query = "SELECT p.fecha AS 'Emision', p.abono AS 'Abono', p.descripcion AS 'Descripcion', t.nombre_transaccion AS 'Transaccion' FROM tbm_pagos p, tbm_transacciones t WHERE p.idtbm_transacciones = t.idtbm_transacciones AND p.idtbm_cuenta_por_pagar =" + cuenta; 
        }

        private void barra_cc_click_imprimir_button()
        {
            DS_comercial_Cuentas ds = new DS_comercial_Cuentas();
            for (int i = 0; i < dgv_cobros.RowCount; i++)
            {
                ds.Tables[0].Rows.Add(new object[]{
                    dgv_cobros[0,i].Value.ToString(),
                    dgv_cobros[1,i].Value.ToString(),
                    dgv_cobros[2,i].Value.ToString()
                });
            }
            DataGridView dg = dgv_cobros;
            ReportParameter[] par = {
                new ReportParameter("no_doc",dg[3,fila].Value.ToString()),
                new ReportParameter("fecha",dg[4,fila].Value.ToString()),
                new ReportParameter("cuenta",dg[0,fila].Value.ToString()),
                new ReportParameter("abono",dg[7,fila].Value.ToString()),
                new ReportParameter("saldo",dg[8,fila].Value.ToString()),
                new ReportParameter("bodega",dg[1,fila].Value.ToString()),
                new ReportParameter("total",dg[6,fila].Value.ToString())
            };
            Reportes rep = new Reportes("Reporte_Saldos.rdlc", ds, "saldos", par);
            rep.ShowDialog();
        }

        private void barra1_click_imprimir_button()
        {
            DS_comercial_Cuentas ds = new DS_comercial_Cuentas();

            for (int i = 0; i < dgv_acp.RowCount; i++)
            {
                ds.Tables[0].Rows.Add(new object[]{
                    dgv_acp[0,i].Value.ToString(),
                    dgv_acp[1,i].Value.ToString(),
                    dgv_acp[2,i].Value.ToString()
                });
            }
            DataGridView dg = dgv_cp;
            ReportParameter[] par = {
                new ReportParameter("no_doc",dg[2,fila].Value.ToString()),
                new ReportParameter("fecha",dg[3,fila].Value.ToString()),
                new ReportParameter("cuenta",dg[0,fila].Value.ToString()),
                new ReportParameter("abono",dg[6,fila].Value.ToString()),
                new ReportParameter("saldo",dg[7,fila].Value.ToString()),
                new ReportParameter("bodega",dg[1,fila].Value.ToString()),
                new ReportParameter("total",dg[5,fila].Value.ToString())
            };
            Reportes rep = new Reportes("Reporte_Saldos.rdlc", ds, "saldos", par);
            rep.ShowDialog();
        }

                
            
        }
        }

       

    

