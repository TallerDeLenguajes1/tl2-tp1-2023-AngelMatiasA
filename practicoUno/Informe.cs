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
   private List<Cadete> cadetes; 
  private  List<Pedidos> pedidos;

    Cadeteria nuevaCadeteria;

    public Cadeteria NuevaCadeteria { get => nuevaCadeteria; set => nuevaCadeteria = value; }
    public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
    public List<Pedidos> Pedidos { get => pedidos; set => pedidos = value; }
/*
    public Informe (Cadeteria cadeteria){
        this.nuevaCadeteria= cadeteria;
        this.Cadetes = cadeteria.getListaCadetes();
        this.Pedidos = cadeteria.getListaPedidos();

    }
    */
        public double montoGanado(List<Cadete> cadetes){
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
