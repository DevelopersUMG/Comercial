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
    public partial class frm_cuentas_por_cobrar : Form
    {
        public frm_cuentas_por_cobrar()
        {
            InitializeComponent();

        }


         DBConnect db = new DBConnect(Properties.Settings.Default.odbc);


        String sf, nf, cc, nc, s, fe, fv,b;
        int nsaldo=0;

        public void consulta()
        {
            string fecha = dtp_fechaconsulta.Value.ToShortDateString();
            string query;

            query = "select cp.idtbm_cuenta_por_cobrar as 'id cuenta', b.idtbm_bodega as 'Bodega',f.serie_factura as 'Serie', f.no_factura as 'Factura no', c.idtbm_cliente as 'Codigo', c.nombre_cliente as 'Nombre Cliente', cp.total_cuenta_por_cobrar as 'Total del documento',";
            query += "cp.fecha_emision as 'Fecha de emision',cp.fecha_vence as 'Fecha de vencimiento',cp.saldo_cuenta_por_cobrar as 'Saldo actual'";
            query += "from  tbm_cuenta_por_cobrar cp, tbm_bodega b,tbm_cliente c, tbm_factura f where f.serie_factura = cp.serie_factura and f.no_factura = cp.no_factura and ";
            query += "c.idtbm_cliente  = f.idtbm_cliente and f.idtbm_bodega = b.idtbm_bodega and fecha_vence = " + fecha;
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
            string tabla = "tbm_cobros";
            Dictionary<string, string> dict = new Dictionary<string, string>();
           
            dict.Add("id_tbm_cuenta_por_cobrar",this.dgv_consulta.Columns[0].ToString());
            dict.Add("serie_factura", tb_sf.Text);
            dict.Add("no_factura", tb_nf.Text);
            dict.Add("idtbm_bodega", tb_b.Text);
            dict.Add("fecha", dtp_fecha_emision.Text);
            dict.Add("abono", tb_abono.Text);
            dict.Add("idtbm_transacciones", cmb_transaccion.SelectedValue.ToString());
            dict.Add("Descripcion", tb_descripcion.Text);
            
            db.insertar(tabla, dict);

            string t = "tbm_cuentas_por_cobrar";
            Dictionary<string, string> ingreso = new Dictionary<string, string>();
            
            dict.Add("abono", tb_abono.Text);
            dict.Add("saldo", nsaldo.ToString());
            string condicion = "idtbm_cuentas_por_cobrar =" + Convert.ToString(this.dgv_consulta.CurrentRow.Cells[0].Value);
            db.actualizar(t, ingreso, condicion);

        }
         

        private void dgv_consulta_DoubleClick(object sender, EventArgs e)
        {
             b = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[1].Value);
             sf = Convert.ToString( this.dgv_consulta.CurrentRow.Cells[2].Value);
             nf = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[3].Value);
             cc = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[4].Value);
             nc = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[5].Value);
             s = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[9].Value);
             fe = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[7].Value);
             fv = Convert.ToString(this.dgv_consulta.CurrentRow.Cells[8].Value);

             tb_b.Text = b;
             tb_sf.Text = sf;
             tb_nf.Text = nf;
             tb_codigo_cliente.Text = cc;
             tb_nombre_cliente.Text = nc;
             tb_saldo_actual.Text = s;
             dtp_fecha_emision.Text = fe;
             dtp_fv.Text = fv;

             int saldo = Convert.ToInt32(s);

             nsaldo = saldo - Convert.ToInt32(tb_abono);



        }


        private void barra1_click_imprimir_button()
        {
            DS_Comercial_CXC ds = new DS_Comercial_CXC();

            for (int i = 0; i < dgv_consulta.RowCount; i++)
            {
                DataGridView dg = dgv_consulta;
                ds.Tables[0].Rows.Add(new object[]{
                        dg[2,i].Value.ToString(),
                        dg[3,i].Value.ToString(),
                        dg[4,i].Value.ToString(),
                        dg[5,i].Value.ToString(),
                        dg[9,i].Value.ToString(),
                        dg[7,i].Value.ToString(),
                        dg[8,i].Value.ToString(),
                        dg[1,i].Value.ToString()
                        
                        
                    });
            }
            Reportes rep = new Reportes("rttl_cxc.rdlc", ds, "DS_Comercial_CXCr");
            rep.ShowDialog();
        }

        private void cancelar() 
        {
            gpr_ingreso.Visible = false;
            
            tb_abono.Text = " ";
            tb_b.Text = " ";
            tb_codigo_cliente.Text = " ";
            tb_descripcion.Text = " ";
            tb_nf.Text = " ";
            tb_nombre_cliente.Text = " ";
            tb_saldo_actual.Text = " ";
            tb_sf.Text = " ";

           

        
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            insertar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_abono.Text = " ";
            tb_b.Text = " ";
            tb_codigo_cliente.Text = " ";
            tb_descripcion.Text = " ";
            tb_nf.Text = " ";
            tb_nombre_cliente.Text = " ";
            tb_saldo_actual.Text = " ";
            tb_sf.Text = " ";

            gpr_ingreso.Visible = false; 
        }

        private void cmb_transaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

   
    }
}
