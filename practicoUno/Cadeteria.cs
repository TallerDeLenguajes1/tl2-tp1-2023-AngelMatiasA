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
   // alta pedido llamando a la funcion del objeto cadete q a su vez llama a la funcion del obj pedido
   public void altaPediCadeteria(int idCadete,string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){

    foreach(var cad in Cadetes){

        if (cad.Id==idCadete){
            cad.altaPedido(observacion, nomcli, clidire, cliTelefono, cliDatRef );
        }
    }
   

   }

   public void agregarCadete( string nombre, string direccion, string telefono){
   
    nuevoCadete = new Cadete(nombre, direccion, telefono );

    Cadetes.Add(nuevoCadete);
    //hacer tipom capa de datos para comunicar entre todos los objetos
    //similar a este metodo y a agregar pedido

    

   }
   public void asignarPedidos(string nombreCadete, Pedidos pedido){
    foreach (Cadete cadetePedido in Cadetes)
    {
        if (nombreCadete == cadetePedido.Nombre)
        {
            cadetePedido.asignarPedido(pedido);
            break;
            
        }
        
    }
    
   }
    public void reasignarPedidos(int idPedido, string NombreCadeteAsignar){
        Pedidos ? pedidos;
        foreach (Cadete cadeteCancelado in Cadetes)
        {
            //primera version
            pedidos =cadeteCancelado.RemoverPedido(idPedido);
            if (pedidos != null)
            {
                break;
            }
            //otraversion
        //    foreach (Pedidos pedido in item.ListaPedidos)
        //    {
        //         if (pedido.NroPedido == idPedido)
        //         {
        //             // item.ListaPedidos.
        //             break;
                    
        //         }
            
        //    }
            
        }
        //  if (pedidos !=null)
        // {
            
        // }
       
        // asignarPedidos(NombreCadeteAsignar, pedidos );

    
   }
   



    
    
}