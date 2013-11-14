using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ODBCConnect;
using System.Collections;

namespace Area_comercial
{
    class class_calculo_comision
    {
        private DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        public void consultar(int no_factura, int serie, int bodega, int id_vendedor)
        {
            double total_comision=0;
            string query = "select idtbm_tipo_comision from tbm_vendedor where idtbm_vendedor =" + id_vendedor;
            
            Dictionary<string,string> dict1 = db.consultar_un_registro(query);
            string tipo_comision = dict1["idtbm_tipo_comision"];

            if (tipo_comision == "1")      // si la comision del vendedor es fija
            {
                query = "select porcentaje_tipo_comision from tbm_tipo_comision where " + tipo_comision + "= idtbm_tipo_comision";                
                dict1 = db.consultar_un_registro(query);
                string porcentaje = dict1["porcentaje_tipo_comision"];
                query = "select total from tbm_factura where serie_factura =" + serie + " and no_factura =" + no_factura + " and idtbm_bodega = " + bodega + "";
                dict1 = db.consultar_un_registro(query);
                string total = dict1["total"];
                double t = Convert.ToDouble(total);
                double p = Convert.ToDouble(porcentaje);
                total_comision = (t * p);                
            }

            if (tipo_comision == "2")       // si la comision del vendedor es por linea
            {
                int factura = no_factura;

                query = "select d.cantidad as 'Cantidad', p.id_producto_finalizado as 'Producto', p.precio as 'Precio' ";
                query += "from tbt_detalle_factura d, producto_finalizado p where d.idproducto_finalizado=p.idproducto_finalizado and d.idtbm_bodega=" + bodega;
                query += " and d.no_factura=" + factura + " and d.serie_factura=" + serie;
                ArrayList list = db.consultar(query);


                foreach (Dictionary<string, string> v1 in list)
                {

                    query = "select m.porcentaje_comision as 'linea' from tbm_producto_finalizado p, tbm_linea m where p.idtbm_linea=m.idtbm_linea";
                    Dictionary<string, string> d = db.consultar_un_registro(query);
                    double porcentaje = Convert.ToDouble(d["linea"]);
                    double comision = porcentaje * Convert.ToDouble(v1["Precio"]) * Convert.ToDouble(v1["Cantidad"]);
                    total_comision += comision;
                }

            }
            else if (tipo_comision == "3")       // si la comision del vendedor es por marca
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
// EMPEZANDO A INSERTAR
            query = "select idtbEmpleado from tbm_vendedor where idtbm_vendedor = " + id_vendedor;
            Dictionary<string, string> dic2 = db.consultar_un_registro(query);
            int i = DateTime.Now.Month;
            int b = DateTime.Now.Year;
            string query5 = "select monto,tbempleado_idEmple from tbm_comision where tbEmpleado_idEmple = " + dic2["idtbEmpleado"] + " and mes = " + i + " and año =" + b;
            string idempleado = dic2["idtbEmpleado"];
            dic2 = db.consultar_un_registro(query5);
            string tabla = "tbm_comision";
            Console.WriteLine(dic2.Count.ToString());
            if (dic2.Count != 2)
            {
                string query6 = "select (max(idtbm_comision)+1) as 'id' from tbm_comision";
                Dictionary<string, string> dic3 = db.consultar_un_registro(query6);
                
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idtbm_comision", dic3["id"]);
                dict.Add("mes", i.ToString());
                dict.Add("año", b.ToString());
                dict.Add("monto", total_comision.ToString());
                dict.Add("tbEmpleado_idEmple", idempleado);

                db.insertar(tabla, dict);
            }
            else
            {
                Dictionary<string, string> dicop = new Dictionary<string, string>();
                double r = Convert.ToDouble(dic2["monto"]) + total_comision;
                dicop.Add("monto", r.ToString());
                string condicion = "tbEmpleado_idEmple = " + idempleado + " and mes = " + i + " and año =" + b;
                db.actualizar(tabla, dicop, condicion);
            }

        }
    }
}
