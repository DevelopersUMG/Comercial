using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;

namespace Transaccional
{
    public partial class Detalle : UserControl
    {

        int factura, serie, bodega;

        public Detalle(int f, int s, int b)
        {
            InitializeComponent();
            this.factura = f;
            this.serie = s;
            this.bodega = b;
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            string query = "select p.nombre as 'Producto', p.precio as 'Precio', d.cantidad as 'Cantidad' ";
            query += "from detalle_factura d, producto p where d.idproducto=p.idproducto and d.idbodega=" + bodega;
            query += " and d.no_factura=" + factura + " and d.serie=" + serie;
            dataGridView1.DataSource = new DBConnect("factura").consulta_DataGridView(query);
        }
    }
}
