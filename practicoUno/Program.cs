using System;
using EspacioDatos;
using EspacioCadeteria;
using EspacioCadete;


namespace MyApp; // Note: actual namespace depends on the project name.

    internal class Program
    {
        static void Main(string[] args)
        {
            AccesoADatos datos = new AccesoADatos();
            Cadeteria nuevaCadeteria = new Cadeteria(datos.leerCadetes("Cadete.csv")); 
            
            nuevaCadeteria.mostrarCadetes();

          //datos.cargarCadetes("Cadete.csv", nuevaCadeteria);
            // nuevaCadeteria.mostrarCadetes(); 
            // Program.mostrarCadetes(nuevaCadeteria.Cadetes);

           // datos.leerCsv();           
        }

         public static void  mostrarCadetes ( List<Cadete> lista){  
            foreach (Cadete Cadete in lista)
            {
                  Console.WriteLine($"Cadete nro {Cadete.Id}");
        Console.Write($"Nombre  {Cadete.Nombre}. ");
        Console.Write($"Direccion {Cadete.Direccion}. ");
        Console.Write($"Telefono: {Cadete.Telefono}. ");
        Console.WriteLine("****************************************************");
        
                
            }
            
   

   }
    }
