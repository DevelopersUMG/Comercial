﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Transaccional
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Factura());
            //Application.Run(new class_calculo_comision().consultar(0,0,0,0));
        }
    }
}
