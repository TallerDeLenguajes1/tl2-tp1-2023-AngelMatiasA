using EspacioCadeteria; 
using EspacioCadete;
using EspacioDatos;
namespace EspacioInterfaz; 


public class interfaz
{
    bool finalizar = false;
    int opcion1 = 0;
    Cadeteria cadeteria;
    AccesoADatos datos = new AccesoADatos();




    public void inicializar(){
        cargarDatos();  
        do
        {
            Console.WriteLine("ingrese  1) dar de alta pedidos \n " +
            " 2) asignarlos a cadetes \n 3) cambiarlos de estado \n 4)reasignar el pedido a otro cadete  "+
            "5) mostrar Cadetes 0)Salir");
            opcion1 =  Convert.ToInt32(Console.ReadLine());
            manejoDeOpciones(opcion1);
            
           
        } while (!finalizar);



    }
    private  void manejoDeOpciones(int opcion)
{
    switch (opcion)
    {
        case 0: 
            finalizar = true; 
            break;

        case 1:
            // Llamada al método para dar de alta pedidos
            // cadeteria.altaPediCadeteria();
           
            break;
        case 2:
            // Llamada al método para asignar pedidos a cadetes
            // cadeteria.asignarPedidos();
            // AsignarPedidosACadetes();
            break;
        case 3:
            // Llamada al método para cambiar el estado de los pedidos
            // cadeteria.cambiarEstadoPedidos();
            // CambiarEstadoPedidos();
            break;
        case 4:
            // Llamada al método para reasignar el pedido a otro cadete
            // ReasignarPedidoAOtroCadete();
            break;
        case 5: 
            cadeteria.mostrarCadetes();
            break;
        
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
}


    public void cargarDatos(){
        datos = new AccesoADatos();
        cadeteria = new Cadeteria(datos.leerCadetes("Cadete.csv"));



    }
    
}