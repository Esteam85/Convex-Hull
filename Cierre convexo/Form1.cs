//Universidad Central de Chile

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
using System.Collections;
using System.Diagnostics;

namespace Cierre_convexo
{
    public partial class Form1 : Form
    {
        
       
        
        public Form1()
        {
              
            InitializeComponent();
            
        }
        //campos
        //Color de la linea dada por el lapiz
        Pen lapiz = new Pen(Color.White);
        //Random
        Random random = new Random();
        //instancia de la clase metodoscc para porder usar sus metodos
        Metodoscc metodocc = new Metodoscc();
        //Punto central
        Point pCentral;
        //Lista de punto aleatorios
        List<PuntoConAngulo> Puntitos;
        //Obejeto que mide el tiempo de ejecución
        Stopwatch ejecucion = new Stopwatch();
        //Evento apretar boton Generar
        private void button1_Click(object sender, EventArgs e)
        {
            //si hay puntos y hay algo en el textbox de puntos...
            if ((Puntitos!=null) && (cPuntos.Text != ""))
            {
                ejecucion.Start();
                string aux = Convert.ToString(tipoCierre.SelectedItem);
                //Depende de lo que diga el comboBox es el cierre que hara
                switch (aux)
                {
                    case "Cierre Radial":
                        {

                            if ((Convert.ToInt32(cPuntos.Text) > 2) && (cPuntos.Text != ""))
                            {
                                
                                Graphics grafica = pic.CreateGraphics();
                                
                                

                                metodocc.DibuRadios(pCentral, Puntitos, grafica);                                
                                metodocc.OrdenarPuntos(Puntitos,pCentral);
                                metodocc.graficarpuntos(new Pen(Color.LightBlue), Puntitos, grafica);
                                metodocc.Distribuir(Puntitos,pCentral);
                                metodocc.graficarpuntos(lapiz, Puntitos, grafica);
                                ejecucion.Stop();

                                foreach (PuntoConAngulo u in Puntitos)
                                {
                                    list.Items.Add(u.Punto);
                                }
                                foreach (PuntoConAngulo u in Puntitos)
                                {
                                    list2.Items.Add(u.Angulo);
                                }
                                foreach (PuntoConAngulo u in Puntitos)
                                {
                                    list3.Items.Add(u.Lugar);
                                }

                            }
                            break;

                        }

                    case "Cierre Eliminación Interior":
                        {
                           
                            Graphics grafica = pic.CreateGraphics();                          
                            Point pCentral = metodocc.CentroPromedio(Puntitos);

                            metodocc.PintaExtremos(Puntitos, grafica);
                            metodocc.CerrarElimincion(Puntitos, grafica, pCentral, lapiz);
                            ejecucion.Stop();

                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                list.Items.Add(u.Punto);
                            }


                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                metodocc.CalculoLugar(u, pCentral);
                                list3.Items.Add(u.Lugar);
                            }
                           
                        
                            
                           

                            break;
                        }
                    case "Cierre Incremental":
                        {
                            Graphics grafica = pic.CreateGraphics();
                            metodocc.Incremental(Puntitos, lapiz, grafica);
                            ejecucion.Stop();
                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                list.Items.Add(u.Punto);
                            }


                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                metodocc.CalculoLugar(u, pCentral);
                                list3.Items.Add(u.Lugar);
                            }
                            break;

                        }
                    case "Cierre Amigo de Navarro":
                        {
                            
                            Graphics grafica = pic.CreateGraphics();
                            Puntitos.Add(Puntitos[0]);
                            metodocc.PintaExtremos(Puntitos, grafica);

                            metodocc.EnvolventeCuadranteI(Puntitos, metodocc.MaximoX(Puntitos).Punto, grafica, lapiz);
                            metodocc.EnvolventeCuadranteII(Puntitos, metodocc.MaximoY(Puntitos).Punto, grafica, lapiz);
                            metodocc.EnvolventeCuadranteIII(Puntitos, metodocc.MinimoX(Puntitos).Punto, grafica, lapiz);
                            metodocc.EnvolventeCuadranteIV(Puntitos, metodocc.MinimoY(Puntitos).Punto, grafica, lapiz);
                            ejecucion.Stop();
                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                list.Items.Add(u.Punto);
                            }


                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                metodocc.CalculoLugar(u, pCentral);
                                list3.Items.Add(u.Lugar);
                            }
                            label5.Text = "Pendiente";
                            foreach (PuntoConAngulo u in Puntitos)
                            {
                                metodocc.CalculoPendiente(u, pCentral);
                                list2.Items.Add(u.Pendiente);
                            }
                            
                            break;
                        }

                }
                
                tiempo.Text = Convert.ToString(ejecucion.ElapsedMilliseconds);
                ejecucion.Reset();
            }
        }
       
      
      

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics grafica = pic.CreateGraphics();
            grafica.Clear(Color.White);
            list.Items.Clear();
            list2.Items.Clear();
            list3.Items.Clear();
           
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            lapiz = new Pen(Color.Red);

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            lapiz = new Pen(Color.Blue);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            lapiz = new Pen(Color.Green);
        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
            //Generador de puntos
                //Se limpia la grafica antes de empesar a poner puntos
           
            Graphics grafica = pic.CreateGraphics();
            grafica.Clear(Color.White);
                // si hay algo en el maskedbox empiesa osino no hace nah
            if (cPuntos.Text != "")
            {
                Puntitos = metodocc.CreaPuntos(Convert.ToInt32(cPuntos.Text),grafica);
                pCentral = metodocc.CentroPromedio(Puntitos);
            }
           
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //llenamos de infomación el cmbbox
            tipoCierre.Items.AddRange(new string[] { "Cierre Radial", "Cierre Eliminación Interior", "Cierre Incremental", "Cierre Amigo de Navarro" });

        }

        private void list3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   


      

    }
}
