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
using System.Collections;

namespace Cierre_convexo
{
    class Metodoscc
    {


        //Campos Comunes
        const int xfinal = 520;
        const int yfinal = 455;
        Random random = new Random();
        Pen colorPunto = new Pen(Color.Black, 3);

        //Metodos Comunes
        public List<PuntoConAngulo> CreaPuntos(int n, Graphics grafica)
        {

            List<PuntoConAngulo> Puntos = new List<PuntoConAngulo>();
            for (int i = 0; i < n; i++)
            {

                PuntoConAngulo aux2 = new PuntoConAngulo(new Point(random.Next(1, xfinal), random.Next(1, yfinal)));
                grafica.DrawRectangle(colorPunto, new Rectangle((aux2.Punto.X), (aux2.Punto.Y), 1, 1));
                Puntos.Add(aux2);

            }
            return Puntos;
        }//Crea puentos aleatoriamente
        public List<PuntoConAngulo> Extremos(List<PuntoConAngulo> puntos)
        {
            List<PuntoConAngulo> ListaDeExtremos = new List<PuntoConAngulo>();
            
          
            PuntoConAngulo maxX = MaximoX(puntos);
            PuntoConAngulo maxY = MaximoY(puntos);
            PuntoConAngulo minX = MinimoX(puntos);
            PuntoConAngulo minY = MinimoY(puntos);

            ListaDeExtremos.Add(minX);
            if (minX != minY)
                ListaDeExtremos.Add(minY);
            if (minY != maxX)
                ListaDeExtremos.Add(maxX);
            if (maxX != maxY)
                ListaDeExtremos.Add(maxY);
            if (maxY != minX)
                ListaDeExtremos.Add(minX);
            
            return ListaDeExtremos;

        }//Selecciona los puntos mas extremos
        public PuntoConAngulo MaximoX(List<PuntoConAngulo> puntos)
        {
            //List<PuntoConAngulo> aux = new List<PuntoConAngulo>();
       
            //foreach (PuntoConAngulo k in puntos)
            //{
            //    aux.Add(k);
            //}
            //while (aux.Count > 1)
            //{
            //    if (aux[0].Punto.X >= aux[1].Punto.X)
            //    {
            //        aux.RemoveAt(1);
            //    }
            //    else
            //    {
            //        aux.RemoveAt(0);
            //    }
            //}
            //return aux[0];
            PuntoConAngulo aux = puntos[0];
            foreach (PuntoConAngulo l in puntos)
            {
                if (aux.Punto.X < l.Punto.X)
                    aux = l;
            }
            return aux;
        }//Selecciona el punto con mas X
        public PuntoConAngulo MaximoY(List<PuntoConAngulo> puntos)
        {
            //List<PuntoConAngulo> aux = new List<PuntoConAngulo>();
            //foreach (PuntoConAngulo k in puntos)
            //{
            //    aux.Add(k);
            //}
            //while (aux.Count > 1)
            //{
            //    if (aux[0].Punto.Y <= aux[1].Punto.Y)
            //    {
            //        aux.RemoveAt(1);
            //    }
            //    else
            //    {
            //        aux.RemoveAt(0);
            //    }
            //}
            //return aux[0];
            PuntoConAngulo aux = puntos[0];
            foreach (PuntoConAngulo l in puntos)
            {
                if (aux.Punto.Y > l.Punto.Y)
                    aux = l;
            }
            return aux;
        }//Selecciona el punto con mas Y
        public PuntoConAngulo MinimoX(List<PuntoConAngulo> puntos)
        {
            //List<PuntoConAngulo> aux = new List<PuntoConAngulo>();
            //foreach (PuntoConAngulo k in puntos)
            //{
            //    aux.Add(k);
            //}
            //while (aux.Count > 1)
            //{
            //    if (aux[0].Punto.X <= aux[1].Punto.X)
            //    {
            //        aux.RemoveAt(1);
            //    }
            //    else
            //    {
            //        aux.RemoveAt(0);
            //    }
            //}
            //return aux[0];
            PuntoConAngulo aux = puntos[0];
            foreach (PuntoConAngulo l in puntos)
            {
                if (aux.Punto.X > l.Punto.X)
                    aux = l;
            }
            return aux;
        }//Selecciona el punto con menos X
        public PuntoConAngulo MinimoY(List<PuntoConAngulo> puntos)
        {
        //    List<PuntoConAngulo> aux = new List<PuntoConAngulo>();
        //    foreach (PuntoConAngulo k in puntos)
        //    {
        //        aux.Add(k);
        //    }
        //    while (aux.Count > 1)
        //    {
        //        if (aux[0].Punto.Y >= aux[1].Punto.Y)
        //        {
        //            aux.RemoveAt(1);
        //        }
        //        else
        //        {
        //            aux.RemoveAt(0);
        //        }
        //    }
        //    return aux[0];
            PuntoConAngulo aux = puntos[0];
            foreach (PuntoConAngulo l in puntos)
            {
                if (aux.Punto.Y < l.Punto.Y)
                    aux = l;
            }
            return aux;
        }//Selecciona el punto con menos Y
        public int Determinante(Point i, Point c, Point f, Point pCentral)
        {
            Point auxi = RedefinirPunto(i, pCentral);
            Point auxc = RedefinirPunto(c, pCentral);
            Point auxf = RedefinirPunto(f, pCentral);


            int x;
            return x = (auxi.X * auxc.Y * 1) + (auxi.Y * 1 * auxf.X) + (1 * auxc.X * auxf.Y) - (1 * auxc.Y * auxf.X) - (1 * auxf.Y * auxi.X) - (auxc.X * auxi.Y * 1);

        }//Calcula el determinante entre 3 puntos
        public void graficarpuntos(Pen l, List<PuntoConAngulo> puntos, Graphics grafica)
        {
            if (puntos.Count > 1)
            {


                int i = 0;
                Point[] auxa = new Point[puntos.Count];
                foreach (PuntoConAngulo s in puntos)
                {
                    auxa[i] = s.Punto;
                    i++;
                }
                grafica.DrawLines(l, auxa);
                grafica.DrawLine(l, auxa[puntos.Count - 1], auxa[0]);

            }

        }//Toma una lista y une con lineas los puntos uno tras otro
        public static Point RedefinirPunto(Point p, Point central)
        {
            Point aux = new Point(p.X - central.X,central.Y - p.Y);



            //aux.X = p.X - central.X;
            //aux.Y = central.Y - p.Y;

            return aux;


        }//Redefine un punto dependiendo de que centro se le de
        public  void CalculoLugar(PuntoConAngulo punto, Point pCentral)//Calcula el cuadrante correspondiente
        {

            Point aux = RedefinirPunto(punto.Punto, pCentral);

            if ((aux.X < 0) && (aux.Y >= 0)||(aux.X <= 0) && (aux.Y > 0))
            {
                punto.Lugar = "CuadranteII";
            }

            if ((aux.X > 0) && (aux.Y <= 0)||(aux.X >= 0) && (aux.Y < 0))
            {
                punto.Lugar = "CuadranteIV";

            }
            if ((aux.X < 0) && (aux.Y <= 0)||(aux.X <= 0) && (aux.Y < 0))
            {
                punto.Lugar = "CuadranteIII";

            }
            if ((aux.X > 0) && (aux.Y >= 0)||(aux.X >= 0) && (aux.Y > 0))
            {
                punto.Lugar = "CuadranteI";

            }

            if ((aux.X == 0) && (aux.Y == 0))
            {
                punto.Lugar = "Origen";

            }




        }
        public Point CentroPromedio(List<PuntoConAngulo> puntos)
        {

            int sumaX = 0;
            int sumaY = 0;
            foreach (PuntoConAngulo u in puntos)
            {
                sumaX += u.Punto.X;
                sumaY += u.Punto.Y;


            }
            Point centr = new Point(sumaX / puntos.Count, sumaY / puntos.Count);

            return centr;

        }//Saca el promedio de todos los X y todos los Y y crea un punto
        public int BuscarElSiguienteIndice(List<PuntoConAngulo> cierre, PuntoConAngulo punto, int indiceP, Point centro)
        {
            int cont = 0;
            for (int i = indiceP + 1; i < cierre.Count - 1; i++)
            {
                if (Determinante(cierre[i].Punto, punto.Punto, cierre[i + 1].Punto, centro) >= 0)
                {
                    cont++;

                }


            }
            return cont;
        }//Busca el indice del ultimo punto del cierre que vio al punto cuestionado






        //Cierre Radial
        public void DibuRadios(Point centro, List<PuntoConAngulo> listapuntos, Graphics imagen)
        {
            Pen lapiz = new Pen(Color.Yellow);
            foreach (PuntoConAngulo a in listapuntos)
            {
                imagen.DrawLine(lapiz, centro, a.Punto);
            }

        }//dibuja todos los radios dependiendo del centro
        public static double CalculoAngulos(Point punto, Point central)
        {
            double angle = 0;
            double radians = 0;

            Point auxpoint = RedefinirPunto(punto, central);
            if ((auxpoint.X < 0) && (auxpoint.Y < 0))
            {
                radians = Math.Atan2(auxpoint.Y, auxpoint.X);
                angle = ((radians * (180 / Math.PI)) + 360);

            }

            if ((auxpoint.X <= 0) && (auxpoint.Y >= 0))
            {
                radians = Math.Atan2(auxpoint.Y, auxpoint.X);
                angle = ((radians * (180 / Math.PI)));
            }
            if ((auxpoint.X >= 0) && (auxpoint.Y <= 0))
            {
                radians = Math.Atan2(auxpoint.Y, auxpoint.X);
                angle = ((radians * (180 / Math.PI)) + 360);
            }
            if ((auxpoint.X >= 0) && (auxpoint.Y >= 0))
            {
                radians = Math.Atan2(auxpoint.Y, auxpoint.X);
                angle = ((radians * (180 / Math.PI)));
            }
            return angle;

        }//Calcula el angulo dependiendo el cuadrante
        public void OrdenarPuntos(List<PuntoConAngulo> PuntoConAngulo, Point pCentral)
        {




            foreach (PuntoConAngulo a in PuntoConAngulo)
            {

                a.Angulo = CalculoAngulos(a.Punto, pCentral);
                CalculoLugar(a, pCentral);



            }
            PuntoConAngulo.Sort();




        }//Ordena lo puntos por los angulos
        public void Distribuir(List<PuntoConAngulo> punto, Point pCentral)//genera el cierre radial
        {
            if (punto.Count > 3)
            {
                int cont = 4;
                while (cont != 0)
                {
                    for (int i = 1; i < punto.Count - 1; i++)
                    {
                        //si el determinante es negativo elimina un punto
                        if (Determinante(punto[i - 1].Punto, punto[i].Punto, punto[i + 1].Punto, pCentral) <= 0)
                        {  //elimina el punto
                            punto.RemoveAt(i);
                            i--;
                            cont++;
                        }
                    }

                    //caso especial para el ultimo punto con el primero y el segundo
                    if (Determinante(punto[punto.Count - 1].Punto, punto[0].Punto, punto[1].Punto, pCentral) <= 0)
                    {    //elimina el punto
                        punto.RemoveAt(0);
                        cont++;

                    }

                    //caso especial para el penultimo, el ultimo y el primer punto
                    if ((Determinante(punto[punto.Count - 2].Punto, punto[punto.Count - 1].Punto, punto[0].Punto, pCentral) <= 0))
                    {   //elimina el punto
                        punto.RemoveAt(punto.Count - 1);
                        cont++;
                    }
                    cont--;
                }
            }
        }







        //Cierre Envolvente

        public  Point CalculoMenor(List<PuntoConAngulo> Aux, Point inicial)
        {

            PuntoConAngulo menor = Aux[0];

            foreach (PuntoConAngulo item in Aux)
            {
                //Point auxo = RedefinirPunto(item.Punto, inicial);
                item.Pendiente = CalculoPendiente(item, inicial);
                
                if (menor.Pendiente >= item.Pendiente)
                {
                    menor = item;
                }
            }


            return menor.Punto;
        }//Calcula el punto con la menor pendiente
        public  double CalculoPendiente(PuntoConAngulo punto, Point inicial)
        {
            PuntoConAngulo aux = new PuntoConAngulo(RedefinirPunto(punto.Punto, inicial));
            double aretornar = 0;
            if (aux.Punto.X != 0)
                aretornar = (Convert.ToDouble(aux.Punto.Y) / Convert.ToDouble(aux.Punto.X));
            else
            {
                switch (punto.Lugar)
                {
                    case "CuadranteI":
                        {
                            aretornar = (Convert.ToDouble(aux.Punto.Y) + 1);
                            break;
                        }
                    case "CuadranteII":
                        {
                            aretornar = (Convert.ToDouble(aux.Punto.Y) + 1) * -1;
                            break;
                        }
                    case "CuadranteIII":
                        {
                            aretornar = (Convert.ToDouble(aux.Punto.Y) - 1) * -1;
                            break;

                        }
                    case "CuadranteIV":
                        {
                            aretornar = (Convert.ToDouble(aux.Punto.Y) - 1);
                            break;
                        }
                }

            }

            return aretornar;
        }//calcula la pendiente de un punto
        public void EnvolventeCuadranteI(List<PuntoConAngulo> puntos, Point inicial, Graphics grafica, Pen l)
        {

            //Lista donde iran los puntos del cierre
            List<PuntoConAngulo> auxlist = new List<PuntoConAngulo>();
            //Verifica todos los puntos si pertenecen a el cuadranteII
            foreach (PuntoConAngulo item in puntos)
            {   //Punto auxiliar donde esta el punto item redefinido
                Point auxitem = RedefinirPunto(item.Punto, inicial);
                //Incluye al auxlist si esque esta en el cuadranteII
                if (((auxitem.X < 0) && (auxitem.Y >= 0)) || ((auxitem.X <= 0) && (auxitem.Y > 0)))
                {

                    item.Lugar = "CuadranteII";
                    auxlist.Add(item);
                    //grafica.DrawLine(l, inicial, item.Punto);

                }

            }
            // Si esque hay puntos en el auxlist hace la recursividad
            if (auxlist.Count > 0)
            {
                //calcula el punto con menor pendiente
                Point menor = CalculoMenor(auxlist, inicial);
                //grafica el punto inicial con el menor pendiente
                grafica.DrawLine(l, inicial, menor);

                //Hace la recursividad pero ahora con el de menor pendiente como inicial
                EnvolventeCuadranteI(auxlist, menor, grafica, l);
            }



        }//Dibuja el cierre envolvente en el primer cuadrante
        public void EnvolventeCuadranteII(List<PuntoConAngulo> puntos, Point inicial, Graphics grafica, Pen l)
        {

            //Lista donde iran los puntos del cierre
            List<PuntoConAngulo> auxlist = new List<PuntoConAngulo>();
            //Verifica todos los puntos si pertenecen a el cuadranteIII
            foreach (PuntoConAngulo item in puntos)
            {

                //Punto auxiliar donde esta el punto item redefinido
                Point auxitem = RedefinirPunto(item.Punto, inicial);
                //Verifica todos los puntos si pertenecen a el cuadranteIII
                if (((auxitem.X < 0) && (auxitem.Y <= 0)) || ((auxitem.X <= 0) && (auxitem.Y < 0)))
                {
                    item.Lugar = "CuadranteIII";
                    //Incluye al auxlist si esque esta en el cuadranteIII
                    auxlist.Add(item);
                    //grafica.DrawLine(l, inicial, item.Punto);

                }

            }
            if (auxlist.Count > 0)
            {

                //calcula el punto con menor pendiente
                Point menor = CalculoMenor(auxlist, inicial);
                //grafica el punto inicial con el menor pendiente
                grafica.DrawLine(l, inicial, menor);
                //Hace la recursividad pero ahora con el de menor pendiente como inicial
                EnvolventeCuadranteII(auxlist, menor, grafica, l);
            }




        }//Dibuja el cierre envolvente en el segundo cuadrante
        public void EnvolventeCuadranteIII(List<PuntoConAngulo> puntos, Point inicial, Graphics grafica, Pen l)
        {

            //Lista donde iran los puntos del cierre
            List<PuntoConAngulo> auxlist = new List<PuntoConAngulo>();
            //Verifica todos los puntos si pertenecen a el cuadranteIV
            foreach (PuntoConAngulo item in puntos)
            {   //Punto auxiliar donde esta el punto item redefinido
                Point auxitem = RedefinirPunto(item.Punto, inicial);
                //Verifica todos los puntos si pertenecen a el cuadranteIV
                if (((auxitem.X > 0) && (auxitem.Y <= 0)) || ((auxitem.X >= 0) && (auxitem.Y < 0)))
                {
                    item.Lugar = "CuadranteIV";
                    //Incluye al auxlist si esque esta en el cuadranteIV
                    auxlist.Add(item);
                    //grafica.DrawLine(l, inicial, item.Punto);

                }

            }
            if (auxlist.Count > 0)
            {
                //calcula el punto con menor pendiente
                Point menor = CalculoMenor(auxlist, inicial);
                //grafica el punto inicial con el menor pendiente
                grafica.DrawLine(l, inicial, menor);

                //Hace la recursividad pero ahora con el de menor pendiente como inicial
                EnvolventeCuadranteIII(auxlist, menor, grafica, l);
            }



        }//Dibuja el cierre envolvente en el tercer cuadrante
        public void EnvolventeCuadranteIV(List<PuntoConAngulo> puntos, Point inicial, Graphics grafica, Pen l)
        {

            //Lista donde iran los puntos del cierre
            List<PuntoConAngulo> auxlist = new List<PuntoConAngulo>();
            //Verifica todos los puntos si pertenecen a el cuadranteI
            foreach (PuntoConAngulo item in puntos)
            { //Punto auxiliar donde esta el punto item redefinido
                Point auxitem = RedefinirPunto(item.Punto, inicial);
                if (((auxitem.X > 0) && (auxitem.Y >= 0)) || ((auxitem.X >= 0) && (auxitem.Y > 0)))
                {
                    item.Lugar = "CuadranteI";
                    //Incluye al auxlist si esque esta en el cuadranteI
                    auxlist.Add(item);
                    //grafica.DrawLine(l, inicial, item.Punto);

                }

            }
            if (auxlist.Count > 0)
            {
             

                //calcula el punto con menor pendiente
                Point menor = CalculoMenor(auxlist, inicial);
                //grafica el punto inicial con el menor pendiente
                grafica.DrawLine(l, inicial, menor);
                //Hace la recursividad pero ahora con el de menor pendiente como inicial
                EnvolventeCuadranteIV(auxlist, menor, grafica, l);
            }



        }//Dibuja el cierre envolvente en el cuarto cuadrante



        //Cierre Eliminación Interior       
        public void PintaExtremos(List<PuntoConAngulo> puntos, Graphics pic)
        {
            List<PuntoConAngulo> aux = new List<PuntoConAngulo>();
            Pen l = new Pen(Color.Yellow);

            aux.Add(MaximoX(puntos));
            aux.Add(MaximoY(puntos));
            aux.Add(MinimoX(puntos));
            aux.Add(MinimoY(puntos));

            graficarpuntos(l, aux, pic);




        }//Une los puntos extremos con lineas
        public List<PuntoConAngulo> EliminarInteriores(List<PuntoConAngulo> puntos, List<PuntoConAngulo> extremos, Point central)
        {
            List<PuntoConAngulo> puntosaux = new List<PuntoConAngulo>();




            for (int i = 0; i < extremos.Count - 1; i++)
            {
                foreach (PuntoConAngulo item in puntos)
                {
                    if (Determinante(extremos[i].Punto, item.Punto, extremos[i + 1].Punto, central) > 0)
                    {
                        puntosaux.Add(item);

                    }
                }

            }


            return puntosaux;




        }//Elimina los puntos Dentro del cierre
        public void CerrarElimincion(List<PuntoConAngulo> puntos, Graphics g, Point central, Pen lapiz)//GEnera el cierre eliminación interior
        {
            //Lista donde iran los puntos del cierre
            List<PuntoConAngulo> Cierre = Extremos(puntos);
            //Primeros puntos candidatos a ser parte del centro, no incluyen los eliminados por los extremos
            List<PuntoConAngulo> Original = EliminarInteriores(puntos, Cierre, central);





            int cont = 3;


            do
            {


                //Recorre todos los puntos del cierre
                for (int i = 0; i < Cierre.Count - 1; i++)
                {   //Envez de usar la fución random, elegimos uno por uno los puntos candidatos 
                    //ya que estas inculidos de manera aleatoria de ante mano por la función creapuntos
                    foreach (PuntoConAngulo punto in Original)
                    {
                        //Si el determinante entre 2 puntos contiguos del cierre y un punto candidato da positivo lo agrega
                        if (Determinante(Cierre[i].Punto, punto.Punto, Cierre[i + 1].Punto, central) > 0)
                        {
                            //Si hay puntos que eliminar entre el primero que vi el punto y el ultimo que lo vio , los elimina
                            int conI = BuscarElSiguienteIndice(Cierre,punto,i, central);//cantidad de elementos entre el i y el siguiente
                            if (conI > 0)
                            {  //Borra del cierre
                                Cierre.RemoveRange(i + 1, conI);
                            }
                            //Inserta el nuevo punto
                            Cierre.Insert(i + 1, punto);



                            //Dibuja las lineas con el punto ya incluido
                            g.DrawLine(lapiz, Cierre[i].Punto, Cierre[i + 1].Punto);
                            g.DrawLine(lapiz, Cierre[i + 1].Punto, Cierre[i + 2].Punto);

                            cont++;



                        }

                    }
                }
                //elimina los puntos internos al cierres
                Original = EliminarInteriores(Original, Cierre, central);
                cont--;
                //Hace todo lo del bloque de codigo hasta que no hayan puntos que agregar
            } while ((cont != 0));






        }
        



        //Cierre Incremental
       public void OrdenarPorX(List<PuntoConAngulo> puntos, int primero, int ultimo)
        {
            int i, j, central;
            PuntoConAngulo pivote;

            central = (primero + ultimo) / 2;
            pivote = puntos[central];
            i = primero;
            j = ultimo;

            do
            {
                while (puntos[i].Punto.X < pivote.Punto.X) i++;
                while (puntos[j].Punto.X > pivote.Punto.X) j--;

                if (i <= j)
                {
                    PuntoConAngulo temp;
                    temp = puntos[i];
                    puntos[i] = puntos[j];
                    puntos[j] = temp;
                    i++;
                    j--;

                }
            } while (i <= j);

            if (primero < j)
            {
                OrdenarPorX(puntos, primero, j);
            }
            if (i < ultimo)
            {
                OrdenarPorX(puntos, i, ultimo);
            }
        }//Ordena de manera quicksort desde el menor a mayor X
       public void Ordenar3Primeros(PuntoConAngulo uno, PuntoConAngulo dos, PuntoConAngulo tres,List<PuntoConAngulo> cierre)
       {
           Point centroUnoTres = new Point((uno.Punto.X + tres.Punto.X + dos.Punto.X) / 3, (uno.Punto.Y + dos.Punto.Y + tres.Punto.Y) / 3);

          
               if (Determinante(uno.Punto, dos.Punto, tres.Punto, centroUnoTres) > 0)
               {
                   cierre.Add(uno);
                   cierre.Add(dos);
                   cierre.Add(tres);
                   cierre.Add(uno);
               }
               else
               {
                   cierre.Add(uno);
                   cierre.Add(tres);
                   cierre.Add(dos);
                   cierre.Add(uno);

               }


       }//ordena los primero 3 puntos dependiendo de la pendiente entre el primer y tercer punto 
       public void Incremental(List<PuntoConAngulo> puntos, Pen lapiz, Graphics grafica)
        {

           //ordena los puntos por el X
            OrdenarPorX(puntos, 0, puntos.Count - 1);
            //Lista donde ira el ciere
            List<PuntoConAngulo> Cierre = new List<PuntoConAngulo>();   
            //Ordena los primeros 3 puntos y los agrega al cierre
            Ordenar3Primeros(puntos[0], puntos[1], puntos[2], Cierre);     
            //grafica el primer triangulo
            graficarpuntos(lapiz, Cierre, grafica);
               //pregunta punto por punto parte desde el tres porque ya se agregaron esos 3
                for (int i = 3; i < puntos.Count; i++)
                {
                 //indice del primer punto del cierre
                int indiceP = 0;
                 //Punto que apunta al primer punto del cierre
                PuntoConAngulo primero = Cierre[indiceP];
                //Puntos que apunta al centro del cierre actual
                Point centroCierre = CentroPromedio(Cierre);
                 //Recorre todos los puntos del cierre para ir incluyendo los nuevos
                for (int j = 1; j <Cierre.Count; j++)
                {
                    //Si el determinante entre 2 puntos contiguos del cierre y un punto candidato da positivo lo agrega
                    if (Determinante(primero.Punto, puntos[i].Punto, Cierre[j].Punto, centroCierre) >= 0)
                    {
                        //Dibujar el primero con el punto
                        grafica.DrawLine(lapiz, primero.Punto, puntos[i].Punto);
                       // Buscar el siguiente
                        int indiceS = BuscarElSiguienteIndice(Cierre, puntos[i], indiceP, centroCierre);
                        // Borrar si es necesario
                        if (indiceS > 0)
                        {
                            Cierre.RemoveRange(indiceP + 1, indiceS);
                        }
                         //Inserta el nuevo punto
                        Cierre.Insert(indiceP + 1,puntos[i]);
                        //Grafica el nuevo punto con el ultimo que lo vio
                        grafica.DrawLine(lapiz,Cierre[indiceP+1].Punto, Cierre[indiceP+2].Punto);


                        //ya que agrego hace que termine el for 
                        j = Cierre.Count;
                    }
                    else
                    {   //si no agrego ningun punto , primero avanza al siguiente punto del cierre para ver si puede ver al punto candidao
                        primero = Cierre[indiceP+1];
                        //el indice aumenta
                        indiceP++;
                    }



                }


                }

        }//Cierra de forma incremental



    }
}



