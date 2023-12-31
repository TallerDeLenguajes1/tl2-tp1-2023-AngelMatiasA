using EspacioCadeteria; 
using EspacioCadete;
using EspacioDatos;
using EspacioInforme;
namespace EspacioInterfaz; 



public class interfaz
{
    bool finalizar = false;
    int opcion1 = 0;
    Cadeteria cadeteria;
    Informe informeNuev;
    AccesoADatos datos = new AccesoADatos();





    public void inicializar(){
        cargarDatos();  
        do
        {
            Console.WriteLine("ingrese: \n  1) dar de alta pedidos \n " +
            " 2) asignarlos a cadetes \n 3) cambiarlos de estado \n 4)reasignar el pedido a otro cadete  "+
            " \n 5) mostrar Cadetes \n 6) Mostrar Pedidos Por estado \n 7) mostrar todos los pedidos \n 0)Salir");
            opcion1 =  Convert.ToInt32(Console.ReadLine());
            manejoDeOpciones(opcion1);
            
           
        } while (!finalizar);



    }
    private  void manejoDeOpciones(int opcion)
{
    int opcionAux;
    switch (opcion)
    {
        case 0: 
            finalizar = true; 
             informeNuev = new Informe(cadeteria);
             informeNuev.mostrarInforme();
            break;

        case 1:
            // Llamada al método para dar de alta pedidos
            Console.WriteLine("ingrese el nombre del cliente ");
            string nombre = Console.ReadLine(); 
              Console.WriteLine("ingrese la direccion del cliente ");
            string direcc = Console.ReadLine(); 
              Console.WriteLine("ingrese la observacion del pedido ");
            string observac = Console.ReadLine(); 
              Console.WriteLine("ingrese el telefono del cliente ");
            string telCli = Console.ReadLine(); 
              Console.WriteLine("ingrese datos de refe del cliente ");
            string datRefCli = Console.ReadLine(); 
            cadeteria.altaPedidoCadeteria(observac, nombre, direcc, telCli, datRefCli);
           
            break;
        case 2:
            // Llamada al método para asignar pedidos a cadetes
             Console.WriteLine("ingrese el nro  de pedido ");
               int nroPedido =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el id del cadete para asignarle el pedido ");

               int idCadete = Convert.ToInt32(Console.ReadLine());
                cadeteria.asignarPedidos(nroPedido, idCadete);

            // AsignarPedidosACadetes();
            break;
        case 3:
            // Llamada al método para cambiar el estado de los pedidos
             Console.WriteLine("ingrese el nro  de pedido ");
               int idpedido =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese 1 para \"sin asignar\",  "+
            "2 para \"en proceso\" o 3 para \"Realizado\"");

               int estado = Convert.ToInt32(Console.ReadLine());
             cadeteria.cambiarEStadoPedido(idpedido, estado);
            // CambiarEstadoPedidos();
            break;
        case 4:
            // Llamada al método para reasignar el pedido a otro cadete
            // ReasignarPedidoAOtroCadete();
            Console.WriteLine("ingrese el nro  de pedido ");
               int idPedido =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el nombre del cadete para reasignarle el pedido ");

               string nombreCadete = Console.ReadLine();
            cadeteria.reasignarPedidos(idPedido, nombreCadete);
            break;
        case 5: 
            cadeteria.mostrarCadetes();
            break;

            case 6: 
            Console.WriteLine("ingrese \n 1) para ver Pedidos Sin asignar \n " +
            " 2) para ver Pedidos En Proceso \n 3) para ver Pedidos Realizados \n ");
            opcionAux =  Convert.ToInt32(Console.ReadLine()) ;
            cadeteria.mostrarPedidosPorEStado(opcionAux);
            break;
        case 7: 
            cadeteria.mostrarPedidosCadeteria();
            break;
        
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
}


    public void cargarDatos(){
        datos = new AccesoADatos();
        cadeteria = new Cadeteria(datos.leerCadetes("Cadete.csv"));
        cadeteria.asignarPedidosTesting(datos.CargarPedidos("Pedidos.csv"));
       



    }
    
}