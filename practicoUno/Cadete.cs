using System; 
using EspacioPedidos; 
namespace EspacioCadete;  




public class Cadete
{
    static int cant = 0; 
    int id; 
    string direccion; 
    string nombre;
    string telefono;  
    List<Pedidos> listaPedidos;

    Pedidos nuevoPedido;

    public List<Pedidos> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Id { get => id; set => id = value; } 
   
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
    public void agregarPedido ( string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){ 
        nuevoPedido = new(observacion, nomcli, clidire, cliTelefono, cliDatRef );
        this.listaPedidos.Add(nuevoPedido);

    }
}