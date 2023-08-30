using System; 
namespace EspacioCadete;  
using EspacioPedidos; 
using EspacioPedidos;

public class Cadete
{
    static int cant = 0; 
    int id; 
    string direccion; 
    string telefono;  
    List<Pedidos> listaPedidos;

    public List<Pedidos> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Id { get => id; set => id = value; }
    public Cadete (){
        this.id = cant ++; 
        listaPedidos = new List<Pedidos>();
    }
     public Cadete (string direccion, string telefono){
        this.id = cant ++;
        listaPedidos = new List<Pedidos>();
    }
    public void agregarPedido (Pedidos pedido){ 
        this.listaPedidos.Add(pedido);

    }
}