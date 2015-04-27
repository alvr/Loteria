﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loteria
{
    static class Programa
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new Principal();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0)
                Application.ExitThread();
            else
                Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
