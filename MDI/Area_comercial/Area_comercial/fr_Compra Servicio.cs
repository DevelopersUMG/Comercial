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
namespace Area_comercial
{
    public partial class fr_Compra_Servicio : Form
    {
        public fr_Compra_Servicio()
        {
            InitializeComponent();
            iniciar();
            fun.Letras(this);
            fun.ActivarDesactivarControlesT(panel1, "D");
            
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        funciones fun = new funciones();
        Dictionary<string, string> d = new Dictionary<string, string>();
        private void barra1_click_guardar_button()
        {

            string tipocompra="3";
            string tipopago=Convert.ToString(cb_Tipopago.SelectedValue.ToString());
            string bodega = Convert.ToString(cb_Bodega.SelectedValue.ToString());
            string concepto = Convert.ToString(cb_Concepto.SelectedValue.ToString());
            string moneda=Convert.ToString(cb_Moneda.SelectedValue.ToString());
            string proveedor=Convert.ToString(cb_Proveedor.SelectedValue.ToString());
            string orden =Convert.ToString( tx_Orden.Text.ToString());
            string valor =Convert.ToString( tx_Valor.Text.ToString());

            Dictionary<string, string> dictio = new Dictionary<string, string>();
            Console.WriteLine("******************************************");
            dictio.Add("idtbm_bodega", bodega);
            dictio.Add("fecha_compra", tx_Fechaactual.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            dictio.Add("idtbm_tipo_pago", tipopago);
            dictio.Add("idtbm_moneda", moneda);
            dictio.Add("idtbm_tipo_compra", tipocompra);
            dictio.Add("idtbm_proveedor", proveedor);
            db.insertar("tbm_compra", dictio);   
            Dictionary<string, string> diccio = new Dictionary<string, string>();            
            Console.WriteLine("******************************************");
            diccio.Add("no_compra", orden);
            diccio.Add("idtbm_bodega", bodega);
            diccio.Add("idtbm_servicio", concepto);
            diccio.Add("costo", valor);
            db.insertar("tbt_detalle_compra_servicio", diccio);
            Console.WriteLine("******************************************");
            Dictionary<string, string> dic2 = new Dictionary<string, string>();
            dic2.Add("total_cuenta_por_pagar", valor);
            dic2.Add("fecha_emision", tx_Fechaactual.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            dic2.Add("fecha_vence", tx_Fechavence.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            dic2.Add("no_compra", orden);
            dic2.Add("idtbm_bodega", bodega);
            dic2.Add("saldo_cuenta_por_pagar", valor);
            Console.WriteLine("******************************************");
            db.insertar("tbm_cuenta_por_pagar", dic2);

            fun.ActivarDesactivarControlesT(panel1, "D");
        }
        public void iniciar()
        {
            //proveedor
            cb_Proveedor.DataSource = db.consulta_ComboBox("select idtbm_proveedor,nombre_proveedor from tbm_proveedor");
            cb_Proveedor.DisplayMember = "nombre_proveedor";
            cb_Proveedor.ValueMember = "idtbm_proveedor";
            //concepto
            cb_Concepto.DataSource = db.consulta_ComboBox("select idtbm_servicio,nombre_servicio from tbm_servicio");
            cb_Concepto.DisplayMember = "nombre_servicio";
            cb_Concepto.ValueMember = "idtbm_servicio";
            //combo de moneda
            cb_Moneda.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
            cb_Moneda.DisplayMember = "nombre_moneda";
            cb_Moneda.ValueMember = "idtbm_moneda";

            //bodega
            cb_Bodega.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            cb_Bodega.DisplayMember = "nombre_bodega";
            cb_Bodega.ValueMember = "idtbm_bodega";


            //combo de tipo de pago
            cb_Tipopago.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
            cb_Tipopago.DisplayMember = "nombre_tipo_pago";
            cb_Tipopago.ValueMember = "idtbm_tipo_pago";
        }

        private void barra1_click_nuevo_button()
        {
            fun.ActivarDesactivarControlesT(panel1, "A");
            tx_Orden.Enabled = false;

            d = db.consultar_un_registro("select MAX(no_compra) as 'No' from tbm_compra");
            int nuevoregistro = 0;
            if (d["No"] != "")
            {
                nuevoregistro = Convert.ToInt32(d["No"]) + 1;
            }
            else
            {
                nuevoregistro++;
            }
            tx_Orden.Text = nuevoregistro.ToString();
            d.Clear();
        }
    }
}
