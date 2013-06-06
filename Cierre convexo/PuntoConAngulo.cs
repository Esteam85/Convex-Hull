//Universidad Central de Chile

//Programa cierre convexo
//Integrantes: Sebastian Moya
//             Esteban Contreras

//Profesor: Julio Fuentealba


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cierre_convexo 
{
    class PuntoConAngulo : IComparable
    {
        string lugar="";
        int cuadrante = 0;

       
      
        Point punto;
        double pendiente;
        double angulo;
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        public int Cuadrante
        {
            get { return cuadrante; }
            set { cuadrante = value; }
        }

       public Point Punto
       {
           get { return punto; }
           set { punto = value; }
       }
       

       public double Pendiente
       {
           get { return pendiente; }
           set { pendiente = value; }
       }
       

       public double Angulo
       {
           get { return angulo; }
           set { angulo = value; }
       }
       public PuntoConAngulo(Point punto, double angulo)
       {
           this.punto = punto;
           this.angulo = angulo;
       }
       public PuntoConAngulo(Point punto)
       {
           this.punto = punto;
          
       }
       public PuntoConAngulo(double pendiente)
       {
           this.pendiente = pendiente;

       }

       #region Miembros de IComparable

       int IComparable.CompareTo(object obj)
       {
           if (obj is PuntoConAngulo)
           {
               PuntoConAngulo temp = (PuntoConAngulo)obj;

               return angulo.CompareTo(temp.angulo);
           }
           throw new NotImplementedException();
       }

       #endregion
    }
}
