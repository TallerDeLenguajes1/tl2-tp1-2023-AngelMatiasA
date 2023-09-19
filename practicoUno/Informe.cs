using EspacioCadeteria; 
using EspacioCadete;
using EspacioPedidos;
using System.Collections; 
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace EspacioInforme; 

public class Informe
{ 
    /*Mostrar  el monto ganado  y la cantidad de envíos de cada cadete y el totalEnvixCad. 
    Muestre también la cantidad de envíos promedio por cadete. */
   private int enviPromedXCadete; 
   private int totalEnvios;
   Cadeteria cadeteria; 
   List<LisInforme> nuevaLisInf; 

public Informe (){     
   }

   public Informe (Cadeteria nuevacadeteria){
      
        CargarInforme( nuevacadeteria);

    
   
   }

    // private static void CargarInforme(Cadeteria cadeteria)
    // {
    //     throw new NotImplementedException();
    // }

    private  void CargarInforme (Cadeteria nuevacadeteria){
          this.cadeteria = nuevacadeteria;
          int totalEnvixCad= 0; 
          LisInforme lisinforme;
          int cantidadDeCadetes = cadeteria.getListaCadetes().Count;

        nuevaLisInf = new List<LisInforme>();
        foreach (Cadete cadete in this.cadeteria.getListaCadetes())
        {totalEnvixCad = 0; 
        lisinforme = new LisInforme();
                            
            Console.WriteLine($"el pedido es para {cadete.Direccion} cadete nro {cadete.Nombre}");

            foreach (Pedidos pedido in cadete.ListaPedidos)
            {
                if(pedido.Estado == pedido.getarreglosEstados(2)){
                    totalEnvixCad ++;
                }
            } 
            lisinforme.setCantxCade(totalEnvixCad);
            lisinforme.setMontoGanadoCade(totalEnvixCad *500);
            lisinforme.setNomCade(cadete.Nombre); 
            lisinforme.setIdCade(cadete.Id); 
            nuevaLisInf.Add(lisinforme); 
            totalEnvios +=  totalEnvixCad;
            enviPromedXCadete = totalEnvios / cantidadDeCadetes;

            
            
        } 


    } 
    public void mostrarInforme (){
        Console.WriteLine("Informe \n \n "); 
        Console.WriteLine($"El total de envios es de {totalEnvios}");
        
        Console.WriteLine($"El promedio de envios por cadetes  es de {this.enviPromedXCadete}");
        
        foreach (var inform in this.nuevaLisInf)
        {
            Console.WriteLine("Cadete nro " + inform.getIdCade());
            Console.WriteLine("Nombre : "+ inform.getNomCade());
            Console.WriteLine("Cantidad de envios"+ inform.getCantxCade());
            Console.WriteLine("Monto ganado "+ inform.getMontoGanadoCade());
        }

    }
        public double montosGanado(List<Cadete> cadetes){
        double totalEnvixCad = 0; 
        foreach (Cadete cadete in cadetes)
        {
            foreach (Pedidos pedido in cadete.ListaPedidos)
            {
                if(pedido.Estado == pedido.getarreglosEstados(2)){
                    totalEnvixCad +=500;
                }
            }
            
            
        }

        return totalEnvixCad;
    }
    
}//fin de la clase Informe

//comienza la clase ejecinforme
public class EjecInforme{
    

    private Informe informNuevo;

    public EjecInforme(){
        informNuevo = new Informe(); 
    }
     public EjecInforme(Cadeteria pCadeteria){
      
        informNuevo = new Informe(pCadeteria); 
    }

    // public IEnumerable<Informe>  getInforme(){
    //     return informNuevo.ToArray<Informe>;

    // }
}

public class LisInforme
{
   private double montoGanado= 0.0; 
   private int cantPorCadete = 0; 
   private string nombreCadete = "" ; 
   private int idCadete= 0; 

   public LisInforme(){

   }
    public LisInforme(int id, string nombre, int cant, double ganancias){ 
        this.idCadete = id; 
        this.nombreCadete = nombre; 
        this.cantPorCadete = cant; 
        this.montoGanado = ganancias;

   }
      public int getIdCade(){

    return this.idCadete;
   }
   public void setIdCade(int id){

     this.idCadete = id;
   }
   public int getCantxCade(){

    return this.cantPorCadete;
   }
   public void setCantxCade(int cant){

     this.cantPorCadete = cant;
   }
     public string getNomCade(){

    return this.nombreCadete;
   }
   public void setNomCade(string nombre){

     this.nombreCadete = nombre;
   }
   
  
     public double getMontoGanadoCade(){

    return this.montoGanado;
   }
   public void setMontoGanadoCade( double ganado){

     this.montoGanado = ganado;
   }

}