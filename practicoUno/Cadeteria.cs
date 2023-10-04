using System;
using EspacioCadete;
using EspacioPedidos;
using System.Linq;
namespace EspacioCadeteria;

public class Cadeteria
{
    private List<Cadete>? cadetes;
    private List<Pedidos>? lisPedCadeteria;
    private Cadete? nuevoCadete;
    private Cadete? objCadete = new Cadete();

    private string nombreCadeteria = "";
    private string telefonoCadeteria = "";

// cambiar construc p nombre y telef y la list d cadetes la agrego dsp
    public Cadeteria()
    {
        cadetes = new List<Cadete>();
        lisPedCadeteria = new List<Pedidos>();

    }
    public Cadeteria ( string pnombre, string ptelefono){
        this.nombreCadeteria = pnombre; 
        this.telefonoCadeteria = ptelefono;
        cadetes = new List<Cadete>();
        lisPedCadeteria = new List<Pedidos>();
    }
    public Cadeteria(List<Cadete> LisCadetes)
    {
        this.cadetes = LisCadetes;
        //lo comento xq uso el asginar pedidos testing para arrancar la lista
        lisPedCadeteria = new List<Pedidos>();


   }
    // alta pedido llamando a la funcion del objeto cadete q a su vez llama a la funcion del obj pedido

   public string NombreCadeteria { get ; set; }
    public string TelefonoCadeteria { get; set; }
    public List<Cadete>? Cadetes {  get => cadetes; set => cadetes = value; }
   
    public List<Pedidos> getListaPedidos()
    {
        return this.lisPedCadeteria;
    }
    public List<Cadete> getListaCadetes()
    {
        return this.cadetes;
    }
  
  
    public void asignarPedidosTesting (List<Pedidos> pedidos){
        this.lisPedCadeteria = pedidos;

    }
  

    public void altaPedidoCadeteria( string observacion, string nomcli, string clidire, string cliTelefono, string cliDatRef)
    {


        lisPedCadeteria.Add(objCadete.altaPedido(observacion, nomcli, clidire, cliTelefono, cliDatRef));

    } 


    public void cambiarEStadoPedido(int idPedido, int estado){
        string estadoAnterior=""; 
        estado --;
        var pedido = this.lisPedCadeteria.FirstOrDefault(p=>p.NroPedido == idPedido); 
        if (pedido!= null){
            estadoAnterior = pedido.Estado; 
            pedido.Estado = pedido.getarreglosEstados(estado);
             Console.WriteLine($" \n Estado anterior {estadoAnterior}");
                Console.WriteLine(pedido.ToString());
        }

    }

public void mostrarPedidosPorEStado(int estado)
{
    estado--; //para que la opcion ingresada disminuya al valor de arrayEstados

    var pedidosFiltrados = this.lisPedCadeteria
        .Where(pedido => String.Equals(pedido.Estado, pedido.getarreglosEstados(estado), StringComparison.OrdinalIgnoreCase))
        .ToList();

    if (pedidosFiltrados.Any())
    {
        foreach (var pedido in pedidosFiltrados)
        {
            string infoPedido = pedido.ToString();
            Console.WriteLine("********************************************* \n");
            Console.WriteLine($"{infoPedido}");
        }
        Console.WriteLine("********************************************* \n");
    }
    else
    {
        Console.WriteLine("La lista de pedidos Esta vacia");
    }
}

    public void agregarCadete(string nombre, string direccion, string telefono)
    {

        nuevoCadete = new Cadete(nombre, direccion, telefono);

        this.cadetes.Add(nuevoCadete);
        //hacer tipom capa de datos para comunicar entre todos los objetos
        //similar a este metodo y a agregar pedido



    }
 
     public void asignarPedidos(int idPedido, int idCadete)
    {
         var pedido = this.lisPedCadeteria
        .FirstOrDefault(p => p.NroPedido == idPedido);

    if (pedido != null)
    {
        var cadete = this.cadetes
            .FirstOrDefault(c => c.Id == idCadete);
        if (cadete != null)
        {
            //cambie solo esta parte p asignarle el cadete a pedido
            pedido.CadetePed = cadete;
            pedido.Estado = pedido.getarreglosEstados(1);
            // Console.WriteLine($"Pedido nro {pedido.NroPedido} asignado al cadete id" +
            //     $"{cadete.Id}: {cadete.Nombre}");
        }
    }
    }


    
    public List<Cadete> mostrarCadetes()
    {
        // foreach (Cadete Cadete in this.cadetes)
        // {
        //     Console.WriteLine("********************************************* \n");
        //     Console.WriteLine($"        Cadete nro {Cadete.Id}");
        //     Console.WriteLine($"Nombre: {Cadete.Nombre}. ");
        //     Console.WriteLine($"Direccion: {Cadete.Direccion}. ");
        //     Console.WriteLine($"Telefono: {Cadete.Telefono}. ");
        // }
        return this.cadetes;
        // Console.WriteLine("********************************************* \n");
    } 

    //Mostrar un informe de pedidos al finalizar la jornada que incluya el monto ganado
    //y la cantidad de envíos de cada cadete y el total. Muestre también la cantidad de
    //envíos promedio por cadete.

    // public double montoGanado(List<Cadete> cadetes){
    //     double total = 0; 
    //     foreach (Cadete cadete in cadetes)
    //     {
    //         foreach (Pedidos pedido in cadete.ListaPedidos)
    //         {
    //             if(pedido.Estado == pedido.getarreglosEstados(2)){
    //                 total +=500;
    //             }
    //         }
            
            
    //     }

    //     return total;
    // }
    //la cantidad de envíos de cada cadete y el total.
    // public string[] cantEnviosXCadete(Cadete cadete){
    //     int cantxCadete = 0; 
    //     //nqv falta ver bien
    //     string [] informeIndividual = {"nombre", "catidad"};
      
        
       
    //         foreach (Pedidos pedido in cadete.ListaPedidos)
    //         {
    //             if(pedido.Estado == pedido.getarreglosEstados(2)){
                   
    //             }
    //         }
            
            
       

    //     return informeIndividual;
    // }

     public void mostrarPedidosCadeteria()
    {
        foreach (Pedidos pedido in this.lisPedCadeteria)
         {  
            //pedido.ToString();
            Console.WriteLine(" \n *************************** \n");
             Console.WriteLine($"       pedido nro {pedido.NroPedido}");
            Console.WriteLine($"Estado: {pedido.Estado}. ");
             if(pedido.CadetePed != null){
              
             Console.WriteLine($"Pedido enviado con {pedido.CadetePed.Nombre}. ");
                   
              

            }
             pedido.VerDireccionCliente();
             Console.WriteLine("Nombre Cliente: " + pedido.NombreClien());
            Console.WriteLine($"Observacion: {pedido.Observacion}. ");
            // Console.Write($"Telefono: {pedido.VerDatosCliente}. ");
            pedido.VerDatosCliente();
        }
        Console.WriteLine("*************************** \n");


    }

//hacerlo q busqe x id tmb.. hya una pequeña incongruencia cuando el usuario
//no ingresa el nombre o no coincide.. igual se le remueve de la lista del otro
//usuario.. estaria bueno una tipo promesa...
    public void reasignarPedidos(int idPedido, int idCadete)
    {
        asignarPedidos(idPedido, idCadete);
    }

 
    public  void eliminarPedido( int idPedRemovido){
        var pedido = lisPedCadeteria.FirstOrDefault
        (p => p.NroPedido == idPedRemovido); 
        if (pedido != null)
        {
            lisPedCadeteria.Remove(pedido);
            
        }

        
    } 

    /*● Agregar el método JornalACobrar en la clase Cadeteria que recibe como
parámetro el id del cadete y devuelve el monto a cobrar para dicho cadete
*/

/*
****************************************** ARREGLAR ************ 
        NO ANDA PORQUE YA NO EXISTE LA LISTA PEDIDOS DE CADETES

*/
//se lo esta llamando en el caso 8 sel switch
    public double JornalACobrar(int idCadete ){
        // hacer doble condicion que el id de cadete coincida en 
        //los pedidos.cadetes.id y que el estado de ese pedido sea entregado
        // o armo una lista de los pedidos del cadete y de ahi me fijo 
        // oevaluo esa doble condicion de una con un where.. 
        double montoACobrar = 0; 
        var cadete = this.cadetes.FirstOrDefault(c => c.Id == idCadete); 
        if (cadete != null ){
            var cantPedidosRealizados = this.lisPedCadeteria
            .Where(
                pedido => String.Equals(pedido.Estado, pedido.getarreglosEstados(2), StringComparison.OrdinalIgnoreCase) 
                && pedido.CadetePed != null && pedido.CadetePed.Id == cadete.Id
                ).ToList().Count;
                montoACobrar = 500* cantPedidosRealizados;
        }


        return montoACobrar;

    }

}