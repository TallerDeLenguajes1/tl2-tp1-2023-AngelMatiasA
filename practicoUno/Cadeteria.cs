using System; 
using EspacioCadete;
using EspacioPedidos;
namespace EspacioCadeteria; 

public class Cadeteria
{
    private List<Cadete>? cadetes ; 
    private Pedidos? nuevoPedido;
    private Cadete? nuevoCadete; 
    private string? nombreCadeteria;
    private string? telefonoCadeteria;


    public  Cadeteria(){
    cadetes = new List<Cadete>(); 

   }
   // alta pedido llamando a la funcion del objeto cadete q a su vez llama a la funcion del obj pedido
   public void altaPediCadeteria(int idCadete,string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){

    foreach(var cad in cadetes){

        if (cad.Id==idCadete){
          //  cad.altaPedido(observacion, nomcli, clidire, cliTelefono, cliDatRef );
        }
    }
   

   }

   public void agregarCadete( string nombre, string direccion, string telefono){
   
    nuevoCadete = new Cadete(nombre, direccion, telefono );

    this.cadetes.Add(nuevoCadete);
    //hacer tipom capa de datos para comunicar entre todos los objetos
    //similar a este metodo y a agregar pedido

    

   }
       public string NombreCadeteria { get => nombreCadeteria; set => nombreCadeteria = value; }
    public string TelefonoCadeteria { get => telefonoCadeteria; set => telefonoCadeteria = value; }
    public List<Cadete>? Cadetes { get => Cadetes; set => Cadetes = value; }

    public void asignarPedidos(string nombreCadete, Pedidos pedido){
    foreach (Cadete cadetePedido in cadetes)
    {
        if (nombreCadete == cadetePedido.Nombre)
        {
            cadetePedido.asignarPedido(pedido);
            break;
            
        }
        
    }
    
   }
   // le tendria que pasar el parametro List<Cadete> cadetesAMostrar
   public  void  mostrarCadetes ( ){
    foreach (Cadete Cadete in this.cadetes)
    {
        Console.WriteLine($"Cadete nro {Cadete.Id}");
        Console.Write($"Nombre  {Cadete.Nombre}. ");
        Console.Write($"Direccion {Cadete.Direccion}. ");
        Console.Write($"Telefono: {Cadete.Telefono}. ");
        Console.WriteLine("****************************************************");
        
    }

   }
    public void reasignarPedidos(int idPedido, string NombreCadeteAsignar){
        Pedidos ? pedidos;
        foreach (Cadete cadeteCancelado in cadetes)
        {
            //primera version
            pedidos =cadeteCancelado.RemoverPedido(idPedido);
            if (pedidos != null)
            {
                foreach (Cadete cadete in this.cadetes)
            {
                if (cadete.Nombre == NombreCadeteAsignar)
                {
                    cadete.asignarPedido(pedidos); 
                }
                
            }
             
            }
            
            //hacer un for each con la lista de cadetes para bscar el cadete a asignar. 
            //y asignarle el pedido devuelto de la funcion anterior
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