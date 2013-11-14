using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace cuentas_por_cobrar_y_pagar
{
    public partial class frm_cuentras_por_pagar : Form
    {
        public frm_cuentras_por_pagar()
        {
            InitializeComponent();
        }


        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        string b, nc, tc, cp, np, fe, fv, s;
        int nsaldo = 0;

        private void barra1_click_imprimir_button()
        {
            DS_Comercial_cuentasxpagar ds = new DS_Comercial_cuentasxpagar();

            for (int i = 0; i < dgv_consulta.RowCount; i++)
            {
                DataGridView dg = dgv_consulta;
                ds.Tables[0].Rows.Add(new object[]{
                        dg[0,i].Value.ToString(),
                        dg[1,i].Value.ToString(),
                        dg[2,i].Value.ToString(),
                        dg[3,i].Value.ToString(),
                        dg[5,i].Value.ToString(),
                        dg[6,i].Value.ToString(),
                        dg[7,i].Value.ToString(),
                        dg[8,i].Value.ToString()
                        
                        
                    });
            }
            Reportes rep = new Reportes("rttl_cxp.rdlc", ds, "DS_Comercial_cuentasxpagar");
            rep.ShowDialog(); 
        }

        private void cmb_transaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_transaccion.DataSource = db.consulta_ComboBox("select * tbm_transacciones");
            cmb_transaccion.DisplayMember = "nombre_transaccion";
            cmb_transaccion.ValueMember = "idtbm_transacciones";
        }

        public void consulta()
        {
            string fecha = dtp_fechaconsulta.Value.ToShortDateString();
            string query;

            query = "select cp.idtbm_cuenta_por_pagar as 'id cuenta', b.idtbm_bodega as 'Bodega',c.no_compra as 'Numero de compra', c.idtbm_tipo_compra as 'Tipo de Compra', p.idtbm_proveedor as 'Codigo Proveedor', p.nombre_proveedor as 'Nombre del proveedor',";
            query += "cp.fecha_emision as 'Fecha de emision',cp.fecha_vence as 'Fecha de vencimiento',cp.saldo_cuenta_por_pagar as 'Saldo actual'";
            query += "from  tbm_cuenta_por_pagar cp, tbm_bodega b,tbm_compra c, tbm_proveedor p  where c.no_compra = cp.no_compra and ";
            query += "c.idtbm_proveedor = p.idtbm_proveedor and cp.idtbm_bodega = b.idtbm_bodega and fecha_vence = " + fecha;
            dgv_consulta.DataSource = db.consulta_DataGridView(query);

            this.dgv_consulta.Columns[0].Visible = false;


        }


        public void nuevo()
        {
            gpr_ingreso.Visible = true;


        }


        public void insertar()
        {
            string tabla = "tbm_pagos";
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("id_tbm_cuenta_por_pagar",this.dgv_consulta.Columns[0].ToString())
            dict.Add("no_compra", tb_nc.Text);
            dict.Add("no_factura", tb_tipo_compra.Text);
            dict.Add("idtbm_bodega", tb_b.Text);
            dict.Add("fecha", dtp_fecha_emision.Text);
            dict.Add("abono", tb_abono.Text);
            dict.Add("Descripcion", tb_descripcion.Text);
            db.insertar(tabla, dict);

            string t = "tbm_cuentas_por_pagar";
            Dictionary<string, string> ingreso = new Dictionary<string, string>();

            dict.Add("abono", tb_abono.Text);
            dict.Add("saldo", nsaldo.ToString());
            string condicion = "idtbm_cuentas_por_pagar =" + Convert.ToString(this.dgv_consulta.CurrentRow.Cells[0].Value);
            db.actualizar(t, ingreso, condicion);

        }

        public void cancela()
        {
            gpr_ingreso.Visible = false;

            tb_abono.Text = " ";
            tb_b.Text = " ";
            tb_nombre_proveedor.Text = " ";
            tb_descripcion.Text = " ";
            tb_nc.Text = " ";
            tb_nombre_proveedor.Text = " ";
            tb_saldo_actual.Text = " ";
            tb_saldo_actual.Text = " ";
        }
        private void dgv_consulta_DoubleClick(object sender, EventArgs e)
        {
            b = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[1].Value);
            nc = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[2].Value);
            tc = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[3].Value);
            cp = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[4].Value);
            np = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[5].Value);
            fe = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[6].Value);
            fv = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[7].Value);
            s = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[8].Value);

            tb_b.Text = b;
            tb_tipo_compra.Text = tc;
            tb_nc.Text = nc;
            tb_codigo_proveedor.Text = cp;
            tb_nombre_proveedor.Text = np;
            tb_saldo_actual.Text = s;
            dtp_fecha_emision.Text = fe;
            dtp_fv.Text = fv;

            int saldo = Convert.ToInt32(s);

            nsaldo = saldo - Convert.ToInt32(tb_abono);



        }

        private void tb_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

    
    
    }


}
