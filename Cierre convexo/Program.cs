﻿//Universidad Central de Chile

//Programa cierre convexo
//Integrantes: Sebastian Moya
//             Esteban Contreras

//Profesor: Julio Fuentealba



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Cierre_convexo
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
            Application.Run(new Form1());
            
        }
    }
}
