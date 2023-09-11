using System;
using EspacioDatos;
using EspacioCadeteria;
using EspacioCadete;
using EspacioInterfaz;


namespace MyApp; // Note: actual namespace depends on the project name.

    internal class Program
    {
        static void Main(string[] args)
        {
            interfaz presentacion = new interfaz(); 
            presentacion.inicializar();
         //   AccesoADatos datos = new AccesoADatos();
           // Cadeteria nuevaCadeteria = new Cadeteria(datos.leerCadetes("Cadete.csv")); 
            
            //nuevaCadeteria.mostrarCadetes();

          //datos.cargarCadetes("Cadete.csv", nuevaCadeteria);
            // nuevaCadeteria.mostrarCadetes(); 
            // Program.mostrarCadetes(nuevaCadeteria.Cadetes);

           // datos.leerCsv(); 

        //    nuevaCadeteria.altaPediCadeteria();           
        }

       
    }
