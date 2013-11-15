using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Area_comercial
{
    public partial class Reportes : Form
    {
        string informe, nombre_data;
        DataSet ds;
        ReportParameter[] par;

        public Reportes(string nombre_informe, DataSet ds, string nombre_data, ReportParameter[] par = null)
        {
            InitializeComponent();                    
            this.informe = nombre_informe;
            this.nombre_data = nombre_data;
            this.ds = ds;
            this.par = par;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            cargar_report();
        }

        private void cargar_report()
        {
            string clase = GetType().ToString();
            string[] v = clase.Split('.');    
            this.reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = v[0] + "." + informe;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(nombre_data, ds.Tables[0]));
            if (par != null)
            {
                reportViewer1.LocalReport.SetParameters(this.par);
            }
            this.reportViewer1.RefreshReport();
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.Clear();
        }
    }
}
