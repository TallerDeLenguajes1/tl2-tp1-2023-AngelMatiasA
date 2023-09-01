using System; 
using EspacioPedidos; 
namespace EspacioCadete;  




public class Cadete
{
    static int cant = 0; 
    int id; 
    string direccion; 
    private string nombre;
    string telefono;  
    List<Pedidos> listaPedidos;

    Pedidos nuevoPedido;

    public List<Pedidos> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    public Cadete (){
        this.id = cant ++; 
        listaPedidos = new List<Pedidos>();
    }
     public Cadete (string nombre, string direccion, string telefono){
        this.id = cant ++;
        this.nombre = nombre; 
        this.direccion = direccion ; 
        this.telefono = telefono;
        listaPedidos = new List<Pedidos>();
    }
    public double jornalACobrar(){
        double sueldo = 0; 
        foreach (Pedidos pedido in listaPedidos)
        { 
            sueldo +=500;
            
        }

        return sueldo;
    }

    public Pedidos altaPedido ( string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){ 
        nuevoPedido = new Pedidos(observacion, nomcli, clidire, cliTelefono, cliDatRef );
        return nuevoPedido;

    }
    public void agregarPedido ( string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){ 
        nuevoPedido = new Pedidos(observacion, nomcli, clidire, cliTelefono, cliDatRef );
        this.listaPedidos.Add(nuevoPedido);

    }
     public void asignarPedido ( Pedidos pedidoAsignar){ 
        this.listaPedidos.Add(nuevoPedido);

    }
    public Pedidos RemoverPedido(int idPedido){ 
        foreach (Pedidos item in listaPedidos)
        {
            if (item.NroPedido == idPedido)
            { 
                nuevoPedido = item;
                listaPedidos.Remove(item);
                 return nuevoPedido;
            }
        }
        return null;
    }
    public Pedidos RemoverPedido(string nomcli){ 
        foreach (Pedidos item in listaPedidos)
        {
            if (item.NombreClien() == nomcli)
            { 
                nuevoPedido = item;
                listaPedidos.Remove(item);
                  break;
            }
        }
        return nuevoPedido;
    }

     public void reasignarPedido ( Pedidos cambioPedido){ 
        
        this.listaPedidos.Add(cambioPedido);

    }

   
}