/***************************************************************
FECHA: GUATEMALA 12 DE NOVIEMBRE 2013
CREADOR: GUILLERMO CANEL 0901-09-12084- UMG
DESCRIPCIÓN: FUNCIONES PARA LOS FORMULARIOS

***************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ODBCConnect;
using Navegador;
using System.Collections;
namespace Area_comercial
{
    class funciones
    {
        DBConnect con = new DBConnect(Properties.Settings.Default.odbc);
        int cantid = 0;
        public String f2_sum_column(DataGridView dataGridView, String nombreColumna)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            string retorno;
            double suma = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                String info = Convert.ToString(fila.Cells[nombreColumna].Value.ToString());
                suma = double.Parse(info, formato) + suma;
            }
            retorno = string.Format(formato, "{0:0.0000}",suma);
            return retorno;
        }

        public String f1_sum_column(DataGridView dataGridView, String nombreColumna)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            string retorno;
            double suma = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                String info = Convert.ToString(fila.Cells[nombreColumna].Value.ToString());
                suma = Convert.ToDouble(info) + suma;
            }
            retorno = string.Format(formato, "{0:0.0000}", suma);
            return retorno;
        }


        public void color_tabla(DataGridView datagridview)
        {
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }

        //**************************************************************************************************
        public void desactivarLibropaginas(TabControl libro)
        {
            foreach (TabPage pagina in libro.TabPages)
            {
                pagina.UseVisualStyleBackColor = false;
                pagina.BackColor = Color.Transparent;
            }
        }

        public void Letras(Form formulario)
        {
            foreach (Control controles in formulario.Controls)            
            {
                if (controles is DataGridView)
                {
                    controles.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                }
               
                else
                    if ((controles is DateTimePicker))
                    {
                        controles.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                    }
                    else
                        if (!(controles is Barra))
                        {
                            controles.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        }
            }
        }
        public void ActivarDesactivarControlesT(Control panel,String opcion)
        {
            if (opcion.Equals("D"))
            {
                foreach (Control controles in panel.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = false;
                        
                    }
                    if (controles is Panel)
                    {
                        controles.BackColor = Color.Transparent;
                    }
                    if (controles is ComboBox)
                    {
                        controles.Enabled = false;
                    }
                    if (controles is DataGridView)
                    {
                        controles.Enabled = false;
                    }
                    if (controles is DateTimePicker)
                    {
                        controles.Enabled = false;
                    }
                    if (controles is Button)
                    {
                        controles.Enabled = false;
                    }
                }
            }
            else if (opcion.Equals("A"))
            {
                foreach (Control controles in panel.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = true;
                        
                    }
                    if (controles is Panel)
                    {
                        controles.BackColor = Color.Transparent;
                    }
                    if (controles is ComboBox)
                    {
                        controles.Enabled = true;
                    }
                    if (controles is DataGridView)
                    {
                        controles.Enabled = true;
                    }
                    if (controles is DateTimePicker)
                    {
                        controles.Enabled = true;
                    }
                    if (controles is Button)
                    {
                        controles.Enabled = true;
                    }
                }
            }
        }




        //**************************************************************************************************
        public int estado_insercion(Control panel)
        {
            int estado = 0; //no hay campos vacios

            foreach (Control caja in panel.Controls)
            {
                estado = 0;
                if (caja is TextBox)
                {
                    if (string.IsNullOrEmpty(caja.Text))
                    {
                        estado=1;
                        return 1;
                    }
                }
            }
            return estado;
        }

        public void activar_controles(Panel panel)
        {
            foreach (Control elemento in panel.Controls)
            {

                if (elemento is TextBox)
                {
                    elemento.Enabled = true;
                    elemento.Text = string.Empty;
                }
                
            }
        
        }


        public void desactivar_controles(Panel panel)
        {
            foreach (Control elemento in panel.Controls)
            {

                if (elemento is TextBox)
                {
                    elemento.Enabled = false;
                }
            }
        }

    
    
    //AUTOR WUALTER QUIJADA
        //OBSERVACION: SE UTILZARON FUNCIONES ELABORADAS POR EL PARA ALIMENTAR A LOS INVENTARIOS

        public void sumamat(int idpro, int cant, int idbod)
        {
            int s1 = 0;
            int s2 = 0;
            string query4 = "select count(idtbm_producto) as 's1', count(idtbm_bodega) as 's2' from tbt_inventario_producto where idtbm_producto='" + idpro + "' and idtbm_bodega='" + idbod + "'";
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                s1 = Convert.ToInt32(v1["s1"]);
                s2 = Convert.ToInt32(v1["s2"]);
                if ((s1 > 0) && (s2 > 0))
                {
                    string query = "select cantidad from tbt_inventario_producto where idtbm_bodega='" + idbod + "' and idtbm_producto='" + idpro + "'";

                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        cantid = Convert.ToInt32(v["cantidad"]);
                    }
                    String tabla = "tbt_inventario_producto";
                    Dictionary<String, String> dict;
                    dict = new Dictionary<String, String>();
                    dict.Add("cantidad", (cantid + cant).ToString());
                    con.actualizar(tabla, dict, "idtbm_bodega='" + idbod + "' and idtbm_producto='" + idpro + "'");
                    MessageBox.Show("Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, no se puede actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public void sumaprof(int idpro, int cant, int idbod)
        {
            int s1 = 0;
            int s2 = 0;
            string query4 = "select count(idproducto_finalizado) as 's1', count(idtbm_bodega) as 's2' from tbt_inventario_producto_finalizado where idproducto_finalizado='" + idpro + "' and idtbm_bodega='" + idbod + "'";
            ArrayList array2 = con.consultar(query4);
            foreach (Dictionary<string, string> v1 in array2)
            {
                s1 = Convert.ToInt32(v1["s1"]);
                s2 = Convert.ToInt32(v1["s2"]);
                if ((s1 > 0) && (s2 > 0))
                {
                    string query = "select cantidad from tbt_inventario_producto_finalizado where idtbm_bodega='" + idbod + "' and idproducto_finalizado='" + idpro + "'";

                    ArrayList array = con.consultar(query);
                    foreach (Dictionary<string, string> v in array)
                    {
                        cantid = Convert.ToInt32(v["cantidad"]);
                    }

                    String tabla = "tbt_inventario_producto_finalizado";
                    Dictionary<String, String> dict;
                    dict = new Dictionary<String, String>();
                    dict.Add("cantidad", (cantid + cant).ToString());
                    con.actualizar(tabla, dict, "idtbm_bodega='" + idbod + "' and idproducto_finalizado='" + idpro + "'");
                    MessageBox.Show("Actualizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, no se puede actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



    
    }

}



    