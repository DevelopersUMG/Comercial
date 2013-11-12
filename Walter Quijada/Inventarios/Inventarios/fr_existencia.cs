using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ODBCConnect;
namespace Inventarios
{
    public partial class fr_existencia : Form
    {

        int id;
        public fr_existencia(int i)
        {
            InitializeComponent();
            this.id = i;
        }
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);

        private void fr_existencia_Load(object sender, EventArgs e)
        {
            consultar(); 
        }
        private void consultar()
        {
             
            string query4 = "select nombre_producto_finalizado as 'nombre' from tbm_producto_finalizado where id_producto_finalizado='"+id+"'";
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                lb_pro.Text = "Producto: " + v1["nombre"];
            }


            dg_existencia.DataSource = con.consulta_DataGridView("select a.id_producto_finalizado, a.nombre_producto_finalizado as 'Nombre Producto',c.nombre_bodega as 'Nombre Bodega', b.cantidad as 'Existencia', b.idproducto_finalizado, b.idtbm_bodega, c.idtbm_bodega from tbm_producto_finalizado as a, tbt_inventario_producto_finalizado as b, tbm_bodega as c where  b.idproducto_finalizado='" + id + "' and a.id_producto_finalizado='" + id + "' and b.idtbm_bodega=c.idtbm_bodega");
            dg_existencia.Columns[0].Visible = false;
            dg_existencia.Columns[1].Width = 150;
            dg_existencia.Columns[2].Width = 150;
            dg_existencia.Columns[3].Width = 120;
            dg_existencia.Columns[4].Visible = false;
            dg_existencia.Columns[5].Visible = false;
            dg_existencia.Columns[6].Visible = false;
            dg_existencia.Visible = true;
        }
        
    }

}
