using System; 
using EspacioCadete;
using EspacioPedidos;
namespace EspacioCadeteria; 

public class Cadeteria
{
    private List<Cadete>? cadetes ; 
    private List<Pedidos>? lisPedCadeteria;
    private Cadete? nuevoCadete ; 
        private Cadete? objCadete = new Cadete(); 

    private string nombreCadeteria = "";
    private string telefonoCadeteria ="";


 public  Cadeteria(List<Cadete> LisCadetes){
    this.cadetes = LisCadetes; 
    lisPedCadeteria = new List<Pedidos>(); 
    

   }
    public  Cadeteria(List<Cadete> LisCadetes, string nombre, string telefono){
    this.cadetes = LisCadetes; 
    this.nombreCadeteria = nombre; 
    this.telefonoCadeteria = telefono; 
    lisPedCadeteria = new List<Pedidos>(); 

   }
   // alta pedido llamando a la funcion del objeto cadete q a su vez llama a la funcion del obj pedido
   public void altaPediCadeteria(int idCadete,string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){

    
         lisPedCadeteria.Add(objCadete.altaPedido(observacion, nomcli, clidire, cliTelefono, cliDatRef ));  
      
   }

   public void agregarCadete( string nombre, string direccion, string telefono){
   
    nuevoCadete = new Cadete(nombre, direccion, telefono );

        this.cadetes.Add(nuevoCadete);
    //hacer tipom capa de datos para comunicar entre todos los objetos
    //similar a este metodo y a agregar pedido

    

   }
       public string NombreCadeteria { get => nombreCadeteria; set => nombreCadeteria = value; }
    public string TelefonoCadeteria { get => telefonoCadeteria; set => telefonoCadeteria = value; }
    //public List<Cadete>? Cadetes { get => Cadetes; set => Cadetes = value; }
    /*public void CargaInicialCadetes(List<Cadete> LisCadetes)
    {
        this.cadetes=LisCadetes;    
    }
*/
    public List<Pedidos> getListaPedidos(){
        return this.lisPedCadeteria;
    }
     public List<Cadete> getListaCadetes(){
        return this.cadetes;
    }
    public void asignarPedidos(int idPedido, int idCadete){
        Pedidos pedidoAux;
    foreach (Pedidos  Pedido in getListaPedidos())
    {
        if (idPedido == Pedido.NroPedido)
        {
            foreach (Cadete cadeteAsignar in this.cadetes)
            {
                if(idCadete == cadeteAsignar.Id)
                {
                    cadeteAsignar.asignarPedido(Pedido);
                    Console.WriteLine($"Pedido nro {Pedido.NroPedido} asignado al cadete id"+
                    $"{cadeteAsignar.Id}: {cadeteAsignar.Nombre}");
                }
            }            
        }        
    }
    
   } 
   // le tendria que pasar el parametro List<Cadete> cadetesAMostrar


      public void asignarPedidos(int idPedido,  string nombreCadete){
        Pedidos pedidoAux;
    foreach (Pedidos  Pedido in getListaPedidos())
    {
        if (idPedido == Pedido.NroPedido)
        {
            foreach (Cadete cadeteAsignar in this.cadetes)
            {
                if(String.Equals(nombreCadete, cadeteAsignar.Nombre, StringComparison.OrdinalIgnoreCase))
                {
                    cadeteAsignar.asignarPedido(Pedido);
                    Console.WriteLine($"Pedido nro {Pedido.NroPedido} asignado al cadete id"+
                    $"{cadeteAsignar.Id}: {cadeteAsignar.Nombre}");
                }
            }            
        }        
    }
    
   } 
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