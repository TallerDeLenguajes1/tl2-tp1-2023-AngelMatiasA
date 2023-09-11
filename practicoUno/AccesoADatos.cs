using  System; 
using System.Collections; 
using System.IO;
using System.Runtime.CompilerServices;
using EspacioCadete; 
using EspacioCadeteria;

namespace EspacioDatos; 

public class AccesoADatos
{
    Cadete nuevoCadete = new Cadete();  
    
    public AccesoADatos(){

    }

    //metodo para verificar si existe y devuelve el archivo null o reader
    public static StreamReader existeCsv(string nombreCsv){
        StreamReader reader = new StreamReader(File.OpenRead(@nombreCsv));
        return reader;
      
    }
     // se podria pasar x referencia? como? 
    // ahi podria hacer una condicion q devuelva true or false
    public void cargarCadetes(string nombreArchivo, Cadeteria cadeteria){
         
        StreamReader lector =  existeCsv(nombreArchivo); 
        if (lector!= null)
        {   //tendria que estar aca o dentro del while la instanciacion?
           // Cadete nuevoCadete = new Cadete();
            
             string pirmeraLinea = lector.ReadLine();
             Console.WriteLine("primera linea del metodo cargar cadetes" + pirmeraLinea);
             while (!lector.EndOfStream  )
             { 
                Cadete nuevoCadete = new Cadete();
                var linea = lector.ReadLine(); 
                var values = linea.Split(';');
               
                cadeteria.agregarCadete(values[0], values[1], values[2] );
             }
            
        }
    }

     public List<Cadete> leerCadetes(string nombreArchivo){
          List<Cadete> CadetesCsv = new List<Cadete>();  
          
        StreamReader lector =  existeCsv(nombreArchivo); 
        if (lector!= null)
        {   //tendria que estar aca o dentro del while la instanciacion?
           // Cadete nuevoCadete = new Cadete();
            
             string pirmeraLinea = lector.ReadLine();
            //  .Skip(1).
            //  string lineas = File.ReadAllLines(nombreArchivo,)Skip(1);
             Console.WriteLine("primera linea y segunda" + pirmeraLinea);
             
             while (!lector.EndOfStream  )
             { 
                Cadete nuevoCadete = new Cadete();
                var linea = lector.ReadLine(); 
                var values = linea.Split(';');
                nuevoCadete.Nombre = values[0];
                Console.WriteLine($"nombre desd el csv" + values[0]);
 

                nuevoCadete.Direccion = values[1]; 
                nuevoCadete.Telefono = values[2];  
                

                CadetesCsv.Add(nuevoCadete);
                
             }
             
            
        }
       

        return CadetesCsv;
    }


    // se podria pasar x referencia? como? 
    // ahi podria hacer una condicion q devuelva true or false
 /*   public List<Cadete> leerCadetes(string nombreArchivo){
          List<Cadete> CadetesCsv = new List<Cadete>();  
          Cadeteria nueva = new Cadeteria();
        StreamReader lector =  existeCsv(nombreArchivo); 
        if (lector!= null)
        {   //tendria que estar aca o dentro del while la instanciacion?
           // Cadete nuevoCadete = new Cadete();
            
             string pirmeraLinea = lector.ReadLine();
             Console.WriteLine("primera linea y segunda" + pirmeraLinea);
             while (!lector.EndOfStream  )
             { 
                Cadete nuevoCadete = new Cadete();
                var linea = lector.ReadLine(); 
                var values = linea.Split(';');
                nuevoCadete.Nombre = values[0];
                Console.WriteLine($"nombre" + values[0]);
 

                nuevoCadete.Direccion = values[1]; 
                nuevoCadete.Telefono = values[2];  
                

                CadetesCsv.Add(nuevoCadete);
                
             }
             nueva.mostrarCadetes();
            
        }
       

        return CadetesCsv;
    }
*/
    public void leerCsv(){
        StreamReader reader = new StreamReader(File.OpenRead(@"informe.csv"));
        if (reader != null)
        {
              List<string> listA = new List<string>();
        List<string> listB = new List<string>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(';');

            listA.Add(values[0]);
            listB.Add(values[1]);
        
            foreach (var coloumn1 in listA)
            {
                Console.WriteLine(coloumn1);
            }
            foreach (var coloumn2 in listA)
            {
                Console.WriteLine(coloumn2);
            }
        }
            
        }
         else 
         {
            Console.WriteLine("no se encontro el archivo");
         }
      
    }
    
}