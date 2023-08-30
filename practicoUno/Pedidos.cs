using System;
using System.Net.WebSockets;
using EspacioCliente;
namespace EspacioPedidos; 

public class Pedidos
{ 
    static int id = 0;
    private int nroPedido; 
    string observacion; 
    Cliente clienteNuevo; 
    bool entregado = false;

       public Pedidos (){ 
        nroPedido = id ++; 
        
        

    } 
    public Pedidos ( string observacion,  string nomcli, string clidire){
       this.nroPedido = id ++;
       cliente=new Clientes(nomcli,clidre);



    }
     public int NroPedido { get => nroPedido;  }
    public string Observacion { get => observacion; set => observacion = value; }
    public bool Entregado { get => entregado; set => entregado = value; }

    public void VerDireccionCliente (){ 
        Console.WriteLine(" la direccion del cliente es  " + clienteNuevo.GetDireccion());

    }
    public void VerDatosCliente (){ 
        Console.WriteLine(" la direccion del cliente es  " + clienteNuevo.GetDireccion());

    }
}