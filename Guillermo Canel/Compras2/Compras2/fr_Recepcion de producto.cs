/***************************************************************
FECHA: GUATEMALA 12 DE NOVIEMBRE 2013
CREADOR: GUILLERMO CANEL 0901-09-12084- UMG

***************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace Compras2
{
    public partial class fr_Recepcion_de_producto : Form
    {
        public fr_Recepcion_de_producto()
        {
            InitializeComponent();
            fun.Letras(this);
            fun.ActivarDesactivarControlesT(panel2, "D");
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        funciones fun = new funciones();
        Dictionary<string, string> dict1; 
        Dictionary<string, string> dict; //para capturar no de bodega
        private void cb_Tipoproducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String cadena = cb_Tipoproducto.GetItemText(cb_Tipoproducto.SelectedItem);            
            llenado_Ordenes(cadena);
        }
        private void cb_Ordencompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String cadena = cb_Tipoproducto.GetItemText(cb_Tipoproducto.SelectedItem);
            this.llenado_datagrid(cadena);
            
        }

        private void barra1_click_guardar_button()
        {
            //guardando en cuentas por pagar()
            
            int a;
            bool error = false;
            db.empezar_transaccion();
            dict=new Dictionary<string,string>();
            dict.Add("total_cuenta_por_pagar", tx_Total.Text.ToString());            
            DateTime fecha = Convert.ToDateTime(tx_Fechaemitida.Text);            
            dict.Add("fecha_emision", fecha.ToString("yyyy-MM-dd HH:mm:ss"));
            dict.Add("fecha_vence", tx_fechavencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            dict.Add("no_compra",cb_Ordencompra.SelectedValue.ToString());
            dict.Add("idtbm_bodega",tx_Bodega.Text);
            dict.Add("saldo_cuenta_por_pagar", tx_Total.Text.ToString());
            a=db.insertar("tbm_cuenta_por_pagar", dict);
            dict.Clear();
            
            //alimentando a bodegas de inventario
            String cadena = cb_Tipoproducto.GetItemText(cb_Tipoproducto.SelectedItem);
           
            if (cadena.Equals("Materia Prima"))
            {                

                foreach (DataGridViewRow fila in dg_Detalle.Rows)
                {                  
                    String cantidad =Convert.ToString( fila.Cells["Cantidad"].Value);
                    String codbodegas = Convert.ToString(fila.Cells["codbodega"].Value);
                    String codigoprod =Convert.ToString( fila.Cells["codproducto"].Value);                    
                    string query3="select idtbm_producto as 'CodiP' from tbt_inventario_producto where idtbm_producto="+codigoprod;
                    Dictionary<string, string> Temporal= db.consultar_un_registro(query3);
                    
                    if ((Temporal.Count==0))
                    {
                        Temporal.Clear();
                        Dictionary<string, string> dica = new Dictionary<string, string>();
                        dica.Add("idtbm_producto", codigoprod.ToString());
                        dica.Add("cantidad", cantidad.ToString());
                        dica.Add("idtbm_bodega", codbodegas.ToString());
                        db.insertar("tbt_inventario_producto", dica);
                    }
                    else
                    {
                        //enviar a wualter para inventario
                        int auxiproducto = Convert.ToInt32(codigoprod.ToString());
                        double auxcantidad = Convert.ToDouble(cantidad.ToString());
                        int auxbodega = Convert.ToInt32(codbodegas.ToString());
                        int auxdouble = Convert.ToInt32(auxcantidad);
                        fun.sumamat(auxiproducto, auxdouble, auxbodega);                        
                    }
                    cantidad = null;
                    codbodegas = null;
                    codigoprod = null;
                    
                }
                
            }                
            else if(cadena.Equals("Producto Finalizado"))
            {

                foreach (DataGridViewRow fila in dg_Detalle.Rows)
                {
                    String cantidad = Convert.ToString(fila.Cells["Cantidad"].Value);
                    String codbodegas = Convert.ToString(fila.Cells["codbodega"].Value);
                    String codigoprod = Convert.ToString(fila.Cells["codproducto"].Value);
                    string query3 = "select idproducto_finalizado as 'CodiP' from tbt_inventario_producto_finalizado where idproducto_finalizado=" + codigoprod;
                    Dictionary<string, string> Temporal = db.consultar_un_registro(query3);

                    if ((Temporal.Count == 0))
                    {
                        Temporal.Clear();
                        Dictionary<string, string> dica = new Dictionary<string, string>();
                        dica.Add("idproducto_finalizado", codigoprod.ToString());
                        dica.Add("cantidad", cantidad.ToString());
                        dica.Add("idtbm_bodega", codbodegas.ToString());
                        db.insertar("tbt_inventario_producto_finalizado", dica);
                    }
                    else
                    {
                        //enviar a wualter para inventario
                        int auxiproducto = Convert.ToInt32(codigoprod.ToString());
                        double auxcantidad = Convert.ToDouble(cantidad.ToString());
                        int auxbodega = Convert.ToInt32(codbodegas.ToString());
                        int auxdouble = Convert.ToInt32(auxcantidad);                        
                        fun.sumaprof(auxiproducto, auxdouble, auxbodega);
                    }
                    cantidad = null;
                    codbodegas = null;
                    codigoprod = null;

                }
            }
            fun.ActivarDesactivarControlesT(panel2, "D");
           
        }


        private void barra1_click_nuevo_button()
        {
            fun.ActivarDesactivarControlesT(panel2, "A");            
            
        }

//_------------------------------------------------------------------------
        public void llenado_Ordenes(String noordena)
        {
           
            cb_Ordencompra.DataSource = null;
            dg_Detalle.Columns.Clear();
            tx_Bodega.Text = "";
            tx_Fechaemitida.Text = "";
            if (noordena.Equals("Materia Prima"))
            {
                this.iniciar();
            }
            else if (noordena.Equals("Producto Finalizado"))
            {
                this.iniciar2();
            }

        }
        public void llenado_datagrid(String tipocompra)
        {
            string No = cb_Ordencompra.SelectedValue.ToString();
            if (tipocompra.Equals("Materia Prima"))
            {
                string query = "select tt.idtbm_bodega as codbodega, tt.id_producto as codproducto, t.nombre_producto as Producto, tt.cantidad as Cantidad, t.costo_producto as Costo, (tt.cantidad*t.costo_producto) as Subtotal from tbt_detalle_compra_materia_prima tt inner join tbm_producto t on tt.id_producto=t.id_producto where tt.no_compra=" + No;
                String query2 = "select idtbm_bodega as nobodega,fecha_compra as fechaemitida from tbm_compra where no_compra=" + No;
                dict1=db.consultar_un_registro(query2);

                tx_Bodega.Text = dict1["nobodega"].ToString();            
                tx_Fechaemitida.Text = dict1["fechaemitida"].ToString();
                dict1.Clear();
               
                dg_Detalle.DataSource = db.consulta_DataGridView(query);
                dg_Detalle.Columns[0].Visible = false;
                dg_Detalle.Columns[1].Visible = false;
            }
            else if (tipocompra.Equals("Producto Finalizado"))
            {
                //reprogramar

                string query = "select tt.idtbm_bodega as codbodega, tt.id_producto_finalizado as codproducto, t.nombre_producto_finalizado as Producto, tt.cantidad as Cantidad, t.Precio_producto_finalizado as Precio, (tt.cantidad*t.Precio_producto_finalizado) as Subtotal from tbt_detalle_compra_producto_finalizado tt inner join tbm_producto_finalizado t on tt.id_producto_finalizado=t.id_producto_finalizado where tt.no_compra=" + No;
                dg_Detalle.DataSource = db.consulta_DataGridView(query);
                dg_Detalle.Columns[0].Visible = false;
                dg_Detalle.Columns[1].Visible = false;
                String query2 = "select idtbm_bodega as nobodega,fecha_compra as fechaemitida from tbm_compra where no_compra=" + No;
                dict1 = db.consultar_un_registro(query2);                
                tx_Bodega.Text = dict1["nobodega"].ToString();                
                tx_Fechaemitida.Text = dict1["fechaemitida"].ToString();
                dict1.Clear();
            }
            double suma = 0;
            foreach (DataGridViewRow fila in dg_Detalle.Rows)
            {
                suma = Convert.ToDouble(fila.Cells["Subtotal"].Value) + suma;
            }
            tx_Total.Text = suma.ToString();
        }


        public void iniciar()
        {

            //String query = "select no_compra from tbm_compra where idtbm_tipo_compra=1";
            string query = "Select t.no_compra from tbm_compra t where not exists";
            query += " (select t2.no_compra from tbm_cuenta_por_pagar t2";
            query += " where t2.no_compra = t.no_compra)and t.idtbm_tipo_compra=1";
            cb_Ordencompra.DataSource = db.consulta_ComboBox(query);
            cb_Ordencompra.DisplayMember = "no_compra";
            cb_Ordencompra.ValueMember = "no_compra";          
        }
        public void iniciar2()
        {
            //String query = "select no_compra from tbm_compra where idtbm_tipo_compra=2";
            string query="Select t.no_compra from tbm_compra t where not exists";
            query+=" (select t2.no_compra from tbm_cuenta_por_pagar t2";
            query += " where t2.no_compra = t.no_compra)and t.idtbm_tipo_compra=2";
            cb_Ordencompra.DataSource = db.consulta_ComboBox(query);
            cb_Ordencompra.DisplayMember = "no_compra";
            cb_Ordencompra.ValueMember = "no_compra";      
        }



       
        

    

    }
}
