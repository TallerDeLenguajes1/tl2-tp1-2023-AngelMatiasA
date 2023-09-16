using EspacioCadeteria; 
using EspacioCadete;
using EspacioPedidos;
using System.Collections; 
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace EspacioInforme; 

public class Informe
{ 
    /*Mostrar  el monto ganado  y la cantidad de envíos de cada cadete y el total. 
    Muestre también la cantidad de envíos promedio por cadete. */
   int enviPromedXCadete; 
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
          int total= 0;
        nuevaLisInf = new List<LisInforme>();
        foreach (Cadete cadete in this.cadeteria.getListaCadetes())
        {
                            
            Console.WriteLine($"el pedido es para {cadete.Direccion} cadete nro {cadete.Nombre}");

            foreach (Pedidos pedido in cadete.ListaPedidos)
            {
                // if(pedido.Estado == pedido.getarreglosEstados(2)){
                //     total +=500;
                // }
            }
            
            
        }

    }
        public double montosGanado(List<Cadete> cadetes){
        double total = 0; 
        foreach (Cadete cadete in cadetes)
        {
            foreach (Pedidos pedido in cadete.ListaPedidos)
            {
                if(pedido.Estado == pedido.getarreglosEstados(2)){
                    total +=500;
                }
            }
            
            
        }

        return total;
    }
    
}
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