using System;
using EspacioDatos;
using EspacioCadeteria;


namespace MyApp; // Note: actual namespace depends on the project name.

    internal class Program
    {
        static void Main(string[] args)
        { 
            AccesoADatos datos = new AccesoADatos();
            Cadeteria nuevaCadeteria = new Cadeteria(); 
             nuevaCadeteria.Cadetes = datos.leerCadetes("Cadete.csv"); 
            // nuevaCadeteria.mostrarCadetes(nuevaCadeteria.Cadetes);

          //datos.cargarCadetes("Cadete.csv", nuevaCadeteria);
            nuevaCadeteria.mostrarCadetes();

  
           // datos.leerCsv();           
        }
    }
