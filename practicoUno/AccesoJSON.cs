using System;
using EspacioCadeteria;  
using EspacioCadete; 
using System.Text.Json; 
using System.IO;
using EspacioInforme;
namespace EspacioDatos
{ 

    public class AccesoJSON{

         public  List<Cadete>  LeerCadetes (string nombreArchivo){ //deserializacion

            List<Cadete> listProduc = new List<Cadete>();
             string json = File.ReadAllText(nombreArchivo);
             listProduc = JsonSerializer.Deserialize<List<Cadete>>(json);
                        
             return listProduc;
          
        }

        public void GuardarInforme(string nombreArchivo, Informe inform){
        string listaJSON = JsonSerializer.Serialize(inform);

        if(!File.Exists(nombreArchivo)){
            File.WriteAllText(nombreArchivo, listaJSON);
        }
    }

    }

}