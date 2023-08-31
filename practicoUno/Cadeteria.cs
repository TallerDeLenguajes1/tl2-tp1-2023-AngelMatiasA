using System; 
using EspacioCadete;
using EspacioPedidos;
namespace EspacioCadeteria; 

public class Cadeteria
{
    private List<Cadete>? Cadetes ; 
    private Pedidos? nuevoPedido;
    private Cadete nuevoCadete;
   
   public  Cadeteria(){
    Cadetes = new List<Cadete>(); 

   }

   public void agregarCadete( string nombre, string direccion, string telefono){
   
    nuevoCadete = new Cadete(nombre, direccion, telefono );
    //hacer tipom capa de datos para comunicar entre todos los objetos
    //similar a este metodo y a agregar pedido
    

   }
   



    
    
}