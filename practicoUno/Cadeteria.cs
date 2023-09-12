using System;
using EspacioCadete;
using EspacioPedidos;
namespace EspacioCadeteria;

public class Cadeteria
{
    private List<Cadete>? cadetes;
    private List<Pedidos>? lisPedCadeteria;
    private Cadete? nuevoCadete;
    private Cadete? objCadete = new Cadete();

    private string nombreCadeteria = "";
    private string telefonoCadeteria = "";


    public Cadeteria(List<Cadete> LisCadetes)
    {
        this.cadetes = LisCadetes;
        //lo comento xq uso el asginar pedidos testing para arrancar la lista
        lisPedCadeteria = new List<Pedidos>();


    }
    public void asignarPedidosTesting (List<Pedidos> pedidos){
        this.lisPedCadeteria = pedidos;

    }
    public Cadeteria(List<Cadete> LisCadetes, string nombre, string telefono)
    {
        this.cadetes = LisCadetes;
        this.nombreCadeteria = nombre;
        this.telefonoCadeteria = telefono;
        lisPedCadeteria = new List<Pedidos>();

    }
    // alta pedido llamando a la funcion del objeto cadete q a su vez llama a la funcion del obj pedido
    public void altaPedidoCadeteria( string observacion, string nomcli, string clidire, string cliTelefono, string cliDatRef)
    {


        lisPedCadeteria.Add(objCadete.altaPedido(observacion, nomcli, clidire, cliTelefono, cliDatRef));

    } 

//la persona tendra que ingresar en interfaz los tipos d estado 0 1 2
    public void cambiarEStadoPedido( int idPedido, int estado){
        string estadoAnterior ="";
        estado--;
        foreach (Pedidos pedido in this.lisPedCadeteria)
        {   
            if (idPedido == pedido.NroPedido)
            {
                estadoAnterior = pedido.Estado;
                pedido.Estado = pedido.getarreglosEstados(estado);
                //Console.WriteLine($"pedido nro {idPedido} para el cliente: "+ pedido.NombreClien()+
                //"\n Destino: " + pedido.VerDireccionCliente + $" \n Estado anterior {estadoAnterior}");
                  Console.WriteLine($" \n Estado anterior {estadoAnterior}");
                Console.WriteLine(pedido.ToString());
            }
        }
    }

    public void mostrarPedidosPorEStado( int estado){
        estado--;//para que la opcion ingresada disminuya al valor de arrayEstados
        bool hayPedidos = false;
        foreach (Pedidos pedido in this.lisPedCadeteria)
        {
            if (String.Equals(pedido.Estado, pedido.getarreglosEstados(estado), StringComparison.OrdinalIgnoreCase))
            {//string nombre = pedido.NombreClien();
                // Console.WriteLine($" Pedido nro {pedido.NroPedido},  \n Cliente {nombre }");
                string infoPedido =  pedido.ToString();
                Console.WriteLine("********************************************* \n");

                Console.WriteLine($"{infoPedido}");
                hayPedidos = true;

               
            }
        }
        Console.WriteLine("********************************************* \n");

        if(!hayPedidos){
            Console.WriteLine($"La lista de pedidos Esta vacia");


        }
    }

    public void agregarCadete(string nombre, string direccion, string telefono)
    {

        nuevoCadete = new Cadete(nombre, direccion, telefono);

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
    public List<Pedidos> getListaPedidos()
    {
        return this.lisPedCadeteria;
    }
    public List<Cadete> getListaCadetes()
    {
        return this.cadetes;
    }
    public void asignarPedidos(int idPedido, int idCadete)
    {
        Pedidos pedidoAux;
        foreach (Pedidos Pedido in getListaPedidos())
        {
            if (idPedido == Pedido.NroPedido)
            {
                foreach (Cadete cadeteAsignar in this.cadetes)
                {
                    if (idCadete == cadeteAsignar.Id)
                    {
                        cadeteAsignar.asignarPedido(Pedido);
                        Console.WriteLine($"Pedido nro {Pedido.NroPedido} asignado al cadete id" +
                        $"{cadeteAsignar.Id}: {cadeteAsignar.Nombre}");
                    }
                }
            }
        }

    }
    // le tendria que pasar el parametro List<Cadete> cadetesAMostrar


    public void asignarPedidos(int idPedido, string nombreCadete)
    {
        // Pedidos pedidoAux;
        foreach (Pedidos Pedido in getListaPedidos())
        {
            if (idPedido == Pedido.NroPedido)
            {
                foreach (Cadete cadeteAsignar in this.cadetes)
                {
                    if (String.Equals(nombreCadete, cadeteAsignar.Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        cadeteAsignar.asignarPedido(Pedido);
                        Console.WriteLine($"Pedido nro {Pedido.NroPedido} asignado al cadete de id: " +
                        $"{cadeteAsignar.Id}, {cadeteAsignar.Nombre}");
                    }
                }
            }
        }

    }
    public void mostrarCadetes()
    {
        foreach (Cadete Cadete in this.cadetes)
        {
            Console.WriteLine("********************************************* \n");
            Console.WriteLine($"        Cadete nro {Cadete.Id}");
            Console.WriteLine($"Nombre: {Cadete.Nombre}. ");
            Console.WriteLine($"Direccion: {Cadete.Direccion}. ");
            Console.WriteLine($"Telefono: {Cadete.Telefono}. ");

        }
        Console.WriteLine("********************************************* \n");


    } 
     public void mostrarPedidosCadeteria()
    {
        foreach (Pedidos pedido in this.lisPedCadeteria)
         {  
            //pedido.ToString();
            Console.WriteLine(" \n *************************** \n");

             Console.WriteLine($"       pedido nro {pedido.NroPedido}");
            //Console.Write($"Nombre del cliente: {pedido.NombreClien}. ");
            Console.WriteLine($"Estado: {pedido.Estado}. ");
             if(pedido.getIdCadetePedidos() != 0){
                foreach (Cadete portadorPedido in this.cadetes)
                {
                    if (portadorPedido.Id == pedido.getIdCadetePedidos())
                    {
                        Console.WriteLine($"Pedido enviado con {portadorPedido.Nombre}. ");
                    }
                    
                }

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
    public void reasignarPedidos(int idPedido, string NombreCadeteAsignar)
    {
        Pedidos? pedidos;
        int idCadeteRemover = 0;
        foreach (Pedidos pedido in this.lisPedCadeteria)
        {
            if (idPedido == pedido.NroPedido)
            {
                idCadeteRemover = pedido.getIdCadetePedidos();
                foreach (Cadete cadeteRequerido in this.cadetes)
                {
                    if (String.Equals(NombreCadeteAsignar, cadeteRequerido.Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        cadeteRequerido.asignarPedido(pedido);


                    }
                }

            }

        }
        removerPedido(idCadeteRemover, idPedido);
    }

    //nose si es que puede o no ser estatico (no puede si uso this.cadetes)
    public  void removerPedido( int idKdTCancelado, int idPedRemovido){
        foreach (Cadete cadete in this.cadetes)
        {
            if (idKdTCancelado == cadete.Id)
            {
                Console.WriteLine("se remueve el pedido "); 
                cadete.RemoverPedido(idPedRemovido);
                
            }
            
        }


    }

}