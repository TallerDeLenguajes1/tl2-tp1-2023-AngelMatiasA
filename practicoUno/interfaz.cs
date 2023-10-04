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
    AccesoCSV datosCsv;
    AccesoADatos datosJson;





    public void inicializar()
    {
        bool correcto = false;
        int op = 0;
        do
        {

            Console.WriteLine("ingrese: \n  1) para cargar datos desde csv \n " +
            " 2) cargar desde Json ");
            correcto = int.TryParse(Console.ReadLine(), out op);
            if (correcto && op != 1 && op != 2)
            {
                correcto = false;
                Console.WriteLine("el numero debe ser 1 o 2, intente de nuevo");

            }

        } while (!correcto);
        if (op == 1)
        {
            cargarDatosCsv();

        }
        else
        {
            cargarDatosJson();

        }
        do
        {
            Console.WriteLine("ingrese: \n  1) dar de alta pedidos \n " +
            " 2) asignarlos a cadetes \n 3) cambiarlos de estado \n 4)reasignar el pedido a otro cadete  " +
            " \n 5) mostrar Cadetes \n 6) Mostrar Pedidos Por estado \n 7) mostrar todos los pedidos \n"+
            " 8) ver el jornal a cobrar \n 0)Salir");
            opcion1 = Convert.ToInt32(Console.ReadLine());
            manejoDeOpciones(opcion1);


        } while (!finalizar);



    }
    private void manejoDeOpciones(int opcion)
    {
        int opcionAux;
        switch (opcion)
        {
            case 0:
                finalizar = true;
                informeNuev = new Informe();
                informeNuev.CargarInforme(cadeteria);
                informeNuev.mostrarInforme();
                AccesoJSON datosJson = new AccesoJSON();
                datosJson.GuardarInforme("Informe.json", informeNuev);
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
                int nroPedido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el id del cadete para asignarle el pedido ");

                int idCadete = Convert.ToInt32(Console.ReadLine());
                cadeteria.asignarPedidos(nroPedido, idCadete);

                // AsignarPedidosACadetes();
                break;
            case 3:
                // Llamada al método para cambiar el estado de los pedidos
                Console.WriteLine("ingrese el nro  de pedido ");
                int idpedido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese 1 para \"sin asignar\",  " +
                "2 para \"en proceso\" o 3 para \"Realizado\"");

                int estado = Convert.ToInt32(Console.ReadLine());
                cadeteria.cambiarEStadoPedido(idpedido, estado);
                // CambiarEstadoPedidos();
                break;
            case 4:
                // Llamada al método para reasignar el pedido a otro cadete
                // ReasignarPedidoAOtroCadete();
                Console.WriteLine("ingrese el nro  de pedido ");
                int idPedido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el id del cadete para reasignarle el pedido ");

                int idCadReasig;
                int.TryParse(Console.ReadLine(), out idCadReasig);
                cadeteria.reasignarPedidos(idPedido, idCadReasig);
                break;
            case 5:
                cadeteria.mostrarCadetes();
                break;

            case 6:
                Console.WriteLine("ingrese \n 1) para ver Pedidos Sin asignar \n " +
                " 2) para ver Pedidos En Proceso \n 3) para ver Pedidos Realizados \n ");
                opcionAux = Convert.ToInt32(Console.ReadLine());
                cadeteria.mostrarPedidosPorEStado(opcionAux);
                break;
            case 7:
                cadeteria.mostrarPedidosCadeteria();
                break;
            case 8:
                // Llamada al método para reasignar el pedido a otro cadete
                Console.WriteLine("ingrese el nro  del cadete para ver el jornal a cobrar ");
                int idcadJornal = Convert.ToInt32(Console.ReadLine());
                var cadeNombre = cadeteria.getListaCadetes().FirstOrDefault(c => c.Id == idcadJornal);

                Console.WriteLine($"el monto a cobrar del cadete {cadeNombre.Nombre} es de: " + cadeteria.JornalACobrar(idcadJornal));


                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }


    public void cargarDatosJson()
    {
        datosJson = new AccesoJSON();
        datosCsv = new AccesoCSV();
        cadeteria = datosJson.cargarCadeteria("Cadeteria.json");
        cadeteria.Cadetes = datosJson.cargarCadetes("Cadete.json");
        // si declaro al obj del tipo padre, no puede usar metodos propios de la clase hija?
        cadeteria.asignarPedidosTesting(datosCsv.CargarPedidos("Pedidos.csv"));
        Console.WriteLine("el nombre de la cadeteria es " + cadeteria.NombreCadeteria);

        Console.WriteLine("el telefono de la cadeteria es " + cadeteria.TelefonoCadeteria);

    }

    public void cargarDatosCsv()
    {
        datosCsv = new AccesoCSV();
        cadeteria = datosCsv.cargarCadeteria("Cadeteria.csv");
        cadeteria.Cadetes = datosCsv.cargarCadetes("Cadete.csv");
        cadeteria.asignarPedidosTesting(datosCsv.CargarPedidos("Pedidos.csv"));
        Console.WriteLine("el nombre de la cadeteria es " + cadeteria.NombreCadeteria);

        Console.WriteLine("el telefono de la cadeteria es " + cadeteria.TelefonoCadeteria);
    }

}