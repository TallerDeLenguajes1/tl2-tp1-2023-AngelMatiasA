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
    public Pedidos ( string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){
       this.nroPedido = id ++;
       clienteNuevo=new Cliente(nomcli, clidire, cliTelefono, cliDatRef);



    }
     public int NroPedido { get => nroPedido;  }
    public string Observacion { get => observacion; set => observacion = value; }
    public bool Entregado { get => entregado; set => entregado = value; }

    public  void VerDireccionCliente (){ 
        Console.WriteLine(" la direccion del cliente es  " + clienteNuevo.Direccion());

    }
    public void VerDatosCliente (){ 
        Console.WriteLine(" la direccion del cliente es  " + clienteNuevo.Direccion());

    }
}