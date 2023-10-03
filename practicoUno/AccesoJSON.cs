using System;
using EspacioCadeteria;
using EspacioCadete;
using System.Text.Json;
using System.IO;
using EspacioInforme;
namespace EspacioDatos;
public class AccesoJSON : AccesoADatos
{

    // public List<Cadete> LeerCadetes(string nombreArchivo)
    // { //deserializacion

    //     List<Cadete> listProduc = new List<Cadete>();
    //     string json = File.ReadAllText(nombreArchivo);
    //     listProduc = JsonSerializer.Deserialize<List<Cadete>>(json);

    //     return listProduc;

    // }
    public override List<Cadete> cargarCadetes(string nombreArchivo)
    {
           List<Cadete> CadetesJson =  new List<Cadete>(); 
        if (existeArchivo(nombreArchivo))
        {
            using (var streamReader = new StreamReader(nombreArchivo))
            {
                var json = streamReader.ReadToEnd();
                Console.WriteLine(" Se imprime el json "+json);
                 CadetesJson = JsonSerializer.Deserialize<List<Cadete>>(json);
                return CadetesJson;
            }
        }
        else
        {
            Console.WriteLine($"El archivo {nombreArchivo} no existe.");
            return null;
        }
    }

    public void GuardarInforme(string nombreArchivo, Informe inform)
    {
        string listaJSON = JsonSerializer.Serialize(inform);
        File.WriteAllText(nombreArchivo, listaJSON);
    }
}
