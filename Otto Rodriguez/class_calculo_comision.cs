using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ODBCConnect;
using System.Collections;

namespace WindowsFormsApplication1
{
    class class_calculo_comision
    {
        private DBConnect db = new DBConnect("area_comercial");

        private void consultar(int no_factura, int serie, int bodega, int id_vendedor)
        {
            string tipo_comision = ("select idtbm_tipo_comision from tbm_vendedor where idtbm_vendedor =" + id_vendedor);

            if (tipo_comision == "1")      // si la comision del vendedor es fija
            {
                string porcentaje = ("select procentaje_tipo_comision from tbm_tipo_comision where " + tipo_comision + "= idtbm_tipo_comision");
                string total = ("select total from tbm_factura where serie_factura =" + no_factura + " and no_factura =" + no_factura + " and idtbm_bodega = " + bodega + "");

                int t = Convert.ToInt32(total);
                int p = Convert.ToInt32(porcentaje);
                int calc_comision = (t * p);
            }

            if (tipo_comision == "2")       // si la comision del vendedor es por linea
            {
                int factura = no_factura;

                string query = "select d.cantidad as 'Cantidad', p.id_producto_finalizado as 'Producto', p.precio as 'Precio' ";
                query += "from tbt_detalle_factura d, producto_finalizado p where d.idproducto_finalizado=p.idproducto_finalizado and d.idtbm_bodega=" + bodega;
                query += " and d.no_factura=" + factura + " and d.serie_factura=" + serie;
                double total_comision = 0;
                ArrayList list = db.consultar(query);


                foreach (Dictionary<string, string> v1 in list)
                {

                    query = "select m.porcentaje_comision as 'linea' from tbm_producto_finalizado p, tbm_linea m where p.idtbm_linea=m.idtbm_linea";
                    Dictionary<string, string> d = db.consultar_un_registro(query);
                    double porcentaje = Convert.ToDouble(d["linea"]);
                    double comision = porcentaje * Convert.ToDouble(v1["Precio"]) * Convert.ToDouble(v1["Cantidad"]);
                    total_comision += comision;


                }


                if (tipo_comision == "3")       // si la comision del vendedor es por marca
                {
                    int factura2 = no_factura;

                    string query3 = "select d.cantidad as 'Cantidad', p.id_producto_finalizado as 'Producto', p.precio as 'Precio' ";
                    query3 += "from tbt_detalle_factura d, producto_finalizado p where d.idproducto_finalizado=p.idproducto_finalizado and d.idtbm_bodega=" + bodega;
                    query3 += " and d.no_factura=" + factura2 + " and d.serie_factura=" + serie;

                    ArrayList list2 = db.consultar(query3);


                    foreach (Dictionary<string, string> v1 in list2)
                    {
                        query = "select m.porcentaje_comision as 'marca' from tbm_producto_finalizado p, tbm_marca m where p.idtbm_marca=m.idtbm_marca";
                        Dictionary<string, string> d = db.consultar_un_registro(query);
                        double porcentaje = Convert.ToDouble(d["marca"]);
                        double comision = porcentaje * Convert.ToDouble(v1["Precio"]) * Convert.ToDouble(v1["Cantidad"]);
                        total_comision += comision;


                    }







                }
            }
        }
    }
}
