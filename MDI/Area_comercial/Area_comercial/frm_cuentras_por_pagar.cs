using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace Area_comercial
{
    public partial class frm_cuentras_por_pagar : Form
    {
        public frm_cuentras_por_pagar()
        {
            InitializeComponent();
        }


        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        string b, nc, tc, cp, np, fe, fv, s, a, id, tot;

        double nsaldo = 0, nabono = 0;


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

        }

        public void consulta()
        {
            string fecha = dtp_fechaconsulta.Value.ToString("yyyy-MM-dd");
            string query;

            query = "select cp.idtbm_cuenta_por_pagar as 'id cuenta', b.idtbm_bodega as 'Bodega',c.no_compra as 'Numero de compra', c.idtbm_tipo_compra as 'Tipo de Compra', p.idtbm_proveedor as 'Codigo Proveedor', p.nombre_proveedor as 'Nombre del proveedor',cp.total_cuenta_por_pagar as 'Total del documento',";
            query += "cp.fecha_emision as 'Fecha de emision',cp.fecha_vence as 'Fecha de vencimiento',cp.abono_cuenta_por_pagar,cp.saldo_cuenta_por_pagar as 'Saldo actual'";
            query += "from  tbm_cuenta_por_pagar cp, tbm_bodega b,tbm_compra c, tbm_proveedor p  where c.no_compra = cp.no_compra and ";
            query += "c.idtbm_proveedor = p.idtbm_proveedor and cp.idtbm_bodega = b.idtbm_bodega and fecha_vence like '" + fecha + "%'";
            dgv_consulta.DataSource = db.consulta_DataGridView(query);


            this.dgv_consulta.Columns[0].Visible = false;


            cmb_transaccion.DataSource = db.consulta_ComboBox("select * tbm_transacciones");
            cmb_transaccion.DisplayMember = "nombre_transaccion";
            cmb_transaccion.ValueMember = "idtbm_transacciones";

        }


        public void nuevo()
        {
            gpr_ingreso.Visible = true;


        }


        public void insertar()
        {
            string tabla = "tbm_pagos";
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("id_tbm_cuenta_por_pagar", id);
            dict.Add("no_compra", tb_nc.Text);
            dict.Add("no_factura", tb_tipo_compra.Text);
            dict.Add("idtbm_bodega", tb_b.Text);
            dict.Add("fecha", DateTime.Now.ToString("yyyy-MM-dd"));
            dict.Add("abono", tb_abono.Text);
            dict.Add("idtbm_transacciones", cmb_transaccion.SelectedValue.ToString());
            dict.Add("Descripcion", tb_descripcion.Text);
            db.insertar(tabla, dict);

            string t = "tbm_cuentas_por_pagar";
            Dictionary<string, string> ingreso = new Dictionary<string, string>();

            ingreso.Add("abono_cuenta_por_pagar", nabono.ToString());
            ingreso.Add("saldo_cuenta_por_pagar", nsaldo.ToString());
            string condicion = "idtbm_cuenta_por_pagar =" + Convert.ToString(this.dgv_consulta.CurrentRow.Cells[0].Value);
            db.actualizar(t, ingreso, condicion);

        }


        private void dgv_consulta_DoubleClick(object sender, EventArgs e)
        {



            id = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[0].Value);
            b = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[1].Value);
            nc = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[2].Value);
            tc = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[3].Value);
            cp = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[4].Value);
            np = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[5].Value);
            tot = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[6].Value);
            fe = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[7].Value);
            fv = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[8].Value);
            a = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[9].Value);
            s = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[10].Value);

            tb_b.Text = b;
            tb_tipo_compra.Text = tc;
            tb_nc.Text = nc;
            tb_codigo_proveedor.Text = cp;
            tb_nombre_proveedor.Text = np;
            tb_saldo_actual.Text = s;
            lbl_fecha_emision.Text = fe;
            lbl_fecha_vencimiento.Text = fv;

            gpr_ingreso.Visible = false;







        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            double saldo = Convert.ToDouble(s);
            double abono = Convert.ToDouble(a);

            nabono = abono + Convert.ToDouble(tb_abono.Text);
            nsaldo = saldo - Convert.ToDouble(tb_abono.Text);

            insertar();
            tb_abono.Text = " ";
            tb_b.Text = " ";
            tb_nombre_proveedor.Text = " ";
            tb_descripcion.Text = " ";
            tb_nc.Text = " ";
            tb_nombre_proveedor.Text = " ";
            tb_saldo_actual.Text = " ";
            tb_saldo_actual.Text = " ";

            gpr_ingreso.Visible = false;

            consulta();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_abono.Text = " ";
            tb_b.Text = " ";
            tb_nombre_proveedor.Text = " ";
            tb_descripcion.Text = " ";
            tb_nc.Text = " ";
            tb_nombre_proveedor.Text = " ";
            tb_saldo_actual.Text = " ";
            tb_saldo_actual.Text = " ";

            gpr_ingreso.Visible = false;
        }

        private void frm_cuentas_por_cobrar_Load(object sender, EventArgs e)
        {
            dtp_fechaconsulta.Value = DateTime.Now;
        }





    }


}
