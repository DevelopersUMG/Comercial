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
using System.Collections;

namespace Compras2
{
    public partial class fr_Compras : Form
    {
        public fr_Compras()
        {
            InitializeComponent();
            iniciar();
            fun.Letras(this);
            fun.desactivarLibropaginas(tabControl1);
            fun.ActivarDesactivarControlesT(panel1, "D");
            fun.ActivarDesactivarControlesT(panel2, "D");
            fun.ActivarDesactivarControlesT(panel3, "D");
            tx_Cantidad.Text = "0";
            tx_Total.Enabled = false;
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        Dictionary<string, string> d;
        String stipo_compra;
        DataGridViewColumn columna;
        int Nocompra = 0; //correlativo de numero de compra
        int id_bodega = 0;
        int idtipPago = 0;
        int id_moneda = 0;
        int idproveedor = 0;
        int idproducto = 0;
        String cantidad = null;
        funciones fun = new funciones();
       
        public void iniciar()
        {   
            //combo de proveedor
            cb_Proveedor.DataSource = db.consulta_ComboBox("select idtbm_proveedor,nombre_proveedor from tbm_proveedor");
            cb_Proveedor.DisplayMember = "nombre_proveedor";
            cb_Proveedor.ValueMember = "idtbm_proveedor";
            //combo de moneda
            cb_Moneda.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
            cb_Moneda.DisplayMember = "nombre_moneda";
            cb_Moneda.ValueMember = "idtbm_moneda";

            //combo de tipo de pago
            cb_Tipopago.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
            cb_Tipopago.DisplayMember = "nombre_tipo_pago";
            cb_Tipopago.ValueMember = "idtbm_tipo_pago";

            //combo de bodega
            cb_Bodega.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            cb_Bodega.DisplayMember = "nombre_bodega";
            cb_Bodega.ValueMember = "idtbm_bodega";

        }

        private void cb_Tipocompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stipo_compra = cb_Tipocompra.GetItemText(cb_Tipocompra.SelectedItem);
            detalle(stipo_compra);

        }
        private void barra1_click_nuevo_button()
        {
            if (tabControl1.SelectedIndex != 0)
            {
                tabControl1.SelectedIndex = 0;
            }
            fun.ActivarDesactivarControlesT(panel1, "A");
            fun.ActivarDesactivarControlesT(panel2, "A");
            fun.ActivarDesactivarControlesT(panel3, "A");
            tx_Nocompra.Enabled = false;
            

            d = db.consultar_un_registro("select MAX(no_compra) as 'No' from tbm_compra");
            if (d["No"] != "")
            {
                Nocompra = Convert.ToInt32(d["No"])+1;
                Console.WriteLine("if");
            }
            else
            {
                Nocompra=1;
                Console.WriteLine("else");
            }

            tx_Nocompra.Text = Nocompra.ToString();
            Console.WriteLine(Nocompra);
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            id_bodega = Convert.ToInt32(cb_Bodega.SelectedValue.ToString()); //indice de la bodega

            idtipPago = Convert.ToInt32(cb_Tipopago.SelectedValue.ToString()); //indice tipo de pago

            id_moneda = Convert.ToInt32(cb_Moneda.SelectedValue.ToString()); //indice de la moneda

            idproveedor = Convert.ToInt32(cb_Proveedor.SelectedValue.ToString());//indice proveeedor

            idproducto = Convert.ToInt32(cb_Producto.SelectedValue.ToString());//indice producto

            cantidad = tx_Cantidad.Text;
            if (stipo_compra.Equals("Materia Prima"))
            {
                insertar_detalle_materia_prima_y_finalizado(1, Nocompra, id_bodega, cantidad, idproducto);
                
            }
            else if (stipo_compra.Equals("Producto Finalizado"))
            {
                insertar_detalle_materia_prima_y_finalizado(2,Nocompra, id_bodega, cantidad, idproducto);
            }
            tx_Cantidad.Text = "0";
            tx_Cantidad.Focus();
            fun.ActivarDesactivarControlesT(panel1, "D");            
        }

        private void dg_Detalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
                tx_Total.Text = fun.f1_sum_column(dg_Detalle, "Subtotal");
        }
        private void dg_Detalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tx_Total.Text = fun.f1_sum_column(dg_Detalle, "Subtotal");
        }

        private void barra1_click_guardar_button()
        {
            if (stipo_compra.Equals("Materia Prima"))
            {
                llenado_informacion(1, dg_Detalle, Nocompra, id_bodega);
            }
            else if (stipo_compra.Equals("Producto Finalizado"))
            {
                llenado_informacion(2, dg_Detalle, Nocompra, id_bodega);                
            }
            fun.ActivarDesactivarControlesT(panel1, "D");
            fun.ActivarDesactivarControlesT(panel2, "D");
            fun.ActivarDesactivarControlesT(panel3, "D");
            dg_Detalle.Columns.Clear();
        }
        
        private void barra1_click_actualizar_button()
        {
            iniciar();
        }
        private void barra1_click_buscar_button()
        {
            if (tabControl1.SelectedIndex != 1)
            {
                tabControl1.SelectedIndex = 1;             
            }
            string query = "select t.no_compra No_Compra,t.fecha_compra Fecha_Emitida,b.nombre_bodega Bodega,m.nombre_moneda Moneda,tc.nombre_tipo_compra Tipo_Compra,p.nombre_proveedor Proveedor";
            query += " from tbm_compra t, tbm_bodega b, tbm_moneda m, tbm_tipo_compra tc, tbm_proveedor p";
            query += " where t.idtbm_bodega=b.idtbm_bodega and t.idtbm_moneda=m.idtbm_moneda and t.idtbm_tipo_compra=tc.idtbm_tipo_compra and t.idtbm_proveedor=p.idtbm_proveedor";
            query += " and tc.idtbm_tipo_compra<> 3";

            dg_detallebuscar.DataSource = db.consulta_DataGridView(query);
            
        }
//----------------------------------------------------------------------------------------------------------
        public void detalle(String tcompra) //TERMINADO
        {
            dg_Detalle.Columns.Clear();
            if (tcompra.Equals("Materia Prima"))
            {
                //String[] encabezados = { "nocompra", "idtbmbodega", "Fecha_compra", "idtbm_tipo_pago", "idtbm_moneda", "idtbm_tipo_compra", "idtbm_proveedor" };

                //combo de producto
                cb_Producto.DataSource = db.consulta_ComboBox("select id_producto,nombre_producto from tbm_producto");
                cb_Producto.DisplayMember = "nombre_producto";
                cb_Producto.ValueMember = "id_producto";

                String[] encabezados = { " no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "CANTIDAD", "COSTO", "Subtotal" };


                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();

                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    dg_Detalle.Columns.Add(columna);
                }

            }
            else if (tcompra.Equals("Producto Finalizado"))
            {
                //combo de producto               
                cb_Producto.DataSource = db.consulta_ComboBox("select id_producto_finalizado,nombre_producto_finalizado from tbm_producto_finalizado");
                cb_Producto.DisplayMember = "nombre_producto_finalizado";
                cb_Producto.ValueMember = "id_producto_finalizado";

                String[] encabezados = { "no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "CANTIDAD", "PRECIO", "Subtotal" };


                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    dg_Detalle.Columns.Add(columna);
                }

            }
        }
        
        public void insertar_detalle_materia_prima_y_finalizado(int opcion, int no_compra, int idbodega, string cantidad, int idproducto)
        {
            String query = null;
            if (opcion == 1)
                query = "select nombre_producto as 'nombre',  costo_producto as 'costo' from tbm_producto where id_producto=" + idproducto;
            if (opcion == 2)
                query = "select nombre_producto_finalizado as 'nombre', precio_producto_finalizado as 'costo' from tbm_producto_finalizado where id_producto_finalizado=" + idproducto;
           
            String nombreProducto = null;
            String costo = null;
            double total = 0;

            ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dic in array)
            {
                nombreProducto = dic["nombre"];               
                    costo = dic["costo"];
            }            
                total = Convert.ToDouble(costo) * Convert.ToDouble(cantidad);           
            dg_Detalle.Rows.Add(no_compra, idbodega, idproducto, nombreProducto, cantidad, costo, total);
            int indice =dg_Detalle.RowCount - 1;
            dg_Detalle.FirstDisplayedScrollingRowIndex = indice;
        }


        public void llenado_informacion(int opcion, DataGridView tabla, int no_compra, int id_bodega)
        {
            String sno_compra = Convert.ToString(no_compra);
            String sid_bodega = Convert.ToString(id_bodega);
            Dictionary<string, string> dictmaestra = new Dictionary<string, string>();

            dictmaestra.Add("no_compra", sno_compra);
            dictmaestra.Add("idtbm_bodega", sid_bodega);
            dictmaestra.Add("fecha_compra", tx_Fecha.Value.ToString("yyyy-MM-dd HH:mm:ss"));            
            dictmaestra.Add("idtbm_tipo_pago", Convert.ToString(idtipPago));
            dictmaestra.Add("idtbm_moneda", Convert.ToString(id_moneda));
            dictmaestra.Add("idtbm_tipo_compra", Convert.ToString(opcion));
            dictmaestra.Add("idtbm_proveedor", Convert.ToString(idproveedor));
            db.insertar("tbm_compra", dictmaestra);


            Dictionary<int, double> d = new Dictionary<int, double>();
            int codigo = 0;
            double cantidad = 0;

            foreach (DataGridViewRow fila in tabla.Rows)
            {
                if ((opcion == 1) || (opcion == 2))
                {
                    codigo = Convert.ToInt32(fila.Cells["idproducto"].Value.ToString());
                    cantidad = Convert.ToDouble(fila.Cells["CANTIDAD"].Value.ToString());
                }
                
                if (d.ContainsKey(codigo))
                {
                    double value = d[codigo];
                    d[codigo] = value + cantidad;
                }
                else
                {
                    d.Add(codigo, cantidad);
                }
            }

            //AQUI PARA INSERTAR A LOS DETALLES DE COMPRA
            Dictionary<String, String> dictio = new Dictionary<String, String>();
            foreach (var info in d)
            {
                String id_producto = Convert.ToString(info.Key);
                String cant_producto = Convert.ToString(info.Value);

                if ((opcion == 1))
                {
                    dictio.Add("no_compra", sno_compra);
                    dictio.Add("idtbm_bodega", sid_bodega);
                    dictio.Add("cantidad", cant_producto);
                    dictio.Add("id_producto", id_producto);
                    db.insertar("tbt_detalle_compra_materia_prima", dictio);
                    dictio.Clear();

                }
                else if ((opcion == 2))
                {
                    dictio.Add("no_compra", sno_compra);
                    dictio.Add("idtbm_bodega", sid_bodega);
                    dictio.Add("cantidad", cant_producto);
                    dictio.Add("id_producto_finalizado", id_producto);
                    db.insertar("tbt_detalle_compra_producto_finalizado", dictio);
                    dictio.Clear();
                }
                
            }

        }

        

        

        

       

        

       
       

//-fin---->
    }
}
