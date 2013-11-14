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
    public partial class fr_Proveedores : Form
    {
        public fr_Proveedores()
        {
            InitializeComponent();
            fun.Letras(this);
            this.fun.desactivarLibropaginas(this.tabControl1);
            fun.ActivarDesactivarControlesT(this.panel1,"D");
            
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        Dictionary<string, string> d;
        funciones fun = new funciones();
        int indice = 0;
        int operacion = 1;

        private void barra1_click_guardar_button()
        {
            if (operacion == 1)
            {
                db.empezar_transaccion();
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_proveedor", tx_Proveedor.Text);
                dict.Add("telefono_nombre_proveedor", tx_Telefono.Text);
                dict.Add("direccion_nombre_proveedor", tx_Direccion.Text);
                db.insertar("tbm_proveedor", dict);
                fun.ActivarDesactivarControlesT(panel1, "D");
                actualizar();
                operacion = 1;
            }
            else if (operacion == 0)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_proveedor", tx_Proveedor.Text.ToString());
                dict.Add("telefono_nombre_proveedor", tx_Telefono.Text.ToString());
                dict.Add("direccion_nombre_proveedor", tx_Direccion.Text.ToString());
                string tabla = "tbm_proveedor";
                String condicion="idtbm_proveedor="+tx_Registro.Text.ToString();
                Console.WriteLine(tx_Direccion.Text.ToString());
                db.actualizar(tabla,dict,condicion);
                fun.ActivarDesactivarControlesT(panel1, "D");
                operacion = 1;

            }

        }

        private void barra1_click_nuevo_button()
        {
            if (tabControl1.SelectedIndex != 0)
            {
                tabControl1.SelectedIndex = 0;
            }

            fun.ActivarDesactivarControlesT(panel1, "A");
            tx_Registro.Enabled = false;

            d = db.consultar_un_registro("select MAX(idtbm_proveedor) as 'No' from tbm_proveedor");
            int nuevoregistro = 0;
            if (d["No"] != "")
            {
                nuevoregistro =Convert.ToInt32(d["No"]) + 1;                
            }
            else
            {
                nuevoregistro++;
                
            }
            tx_Registro.Text = nuevoregistro.ToString();

            
        }

        private void barra1_click_buscar_button()
        {
            if (tabControl1.SelectedIndex != 1)
            {
                tabControl1.SelectedIndex = 1;
            }

            
        }

        public void actualizar()
        {
            string query = "select idtbm_proveedor as Codigo, nombre_proveedor as Proveedor, telefono_nombre_proveedor as Telefono, direccion_nombre_proveedor as Direccion from tbm_proveedor";
            dg_Detallebuscar.DataSource = db.consulta_DataGridView(query);
        }

       

        private void barra1_click_actualizar_button()
        {
            actualizar();
        }

        private void fr_Proveedores_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void barra1_click_editar_button() //metodo editar
        {
            
            if (tabControl1.SelectedIndex != 0)
            {
                tabControl1.SelectedIndex = 0;
            }
            tx_Registro.Text = dg_Detallebuscar.Rows[indice].Cells[0].Value.ToString();
            tx_Proveedor.Text = dg_Detallebuscar.Rows[indice].Cells[1].Value.ToString();
            tx_Telefono.Text = dg_Detallebuscar.Rows[indice].Cells[2].Value.ToString();
            tx_Direccion.Text = dg_Detallebuscar.Rows[indice].Cells[3].Value.ToString();
            this.fun.ActivarDesactivarControlesT(this.panel1, "A");
            operacion = 0;
            this.tx_Registro.Enabled = false;
        }

        
        private void dg_Detallebuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                indice = e.RowIndex;
            }
        }

        private void barra1_click_eliminar_button()        
        {   
            if(MessageBox.Show("Desea eliminar el Registro", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string tabla = "tbm_proveedor";
                string condicion = "idtbm_proveedor=" + dg_Detallebuscar.Rows[indice].Cells[0].Value.ToString();                
                try
                {
                    
                    db.eliminar(tabla, condicion);  
                    actualizar();
                }
                catch (Exception e)
                {
                    MessageBox.Show("El registro No se puede eliminar "+e.Message);
                }
                
            }

        }

        private void barra1_click_imprimir_button()
        {
            ds_comercial_proveedores ds = new ds_comercial_proveedores();
            for (int i = 0; i < dg_Detallebuscar.RowCount; i++)
            {
                ds.Tables[0].Rows.Add(new object[]{
                    dg_Detallebuscar[0,i].Value.ToString(), 
                    dg_Detallebuscar[1,i].Value.ToString(),
                    dg_Detallebuscar[2,i].Value.ToString(),
                    dg_Detallebuscar[3,i].Value.ToString()
                });
            }
            Reportes rep = new Reportes("Report2.rdlc", ds, "provee");
            rep.ShowDialog();
        }

    }
}
