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
    // bool entregado = false; 
    string [] arregloEstados = {"Sin Asignar", "En Proceso", "Realizado"};
    string estado= "";
    int idCadete;

       public Pedidos (){ 
        nroPedido = id ++;  
        this.idCadete = 0;   
         this.estado = arregloEstados[0];
        clienteNuevo=new Cliente();
    } 
    public Pedidos ( string observacion,  string nomcli, string clidire, string cliTelefono, string cliDatRef){
       this.nroPedido = id ++;
       this.observacion = observacion;
       this.estado = arregloEstados[0];
       clienteNuevo=new Cliente(nomcli, clidire, cliTelefono, cliDatRef);
       this.idCadete = 0;
    }
    public string getarreglosEstados (int index){
        return arregloEstados[index];
    }
    public int getIdCadetePedidos(){
        return this.idCadete;
    }
    public void setIdCadetePedidos (int CadeteId){
        this.idCadete= CadeteId;
    }


     public int NroPedido { get => nroPedido;  }
    public string Observacion { get => observacion; set => observacion = value; }
    public string Estado { get => estado; set => estado = value; }
    public string NombreClien(){
        string nombre =this.clienteNuevo.getNombre();
       return nombre;
    }

    public  void VerDireccionCliente (){ 
        Console.WriteLine(" la direccion del cliente es  " + clienteNuevo.Direccion());

    }
    public void VerDatosCliente ()
    { 
        Console.WriteLine(" los datos ref del cliente son:  " + clienteNuevo.DatosRefCliente1); 
        Console.WriteLine(" el telefono del cliente es:  " + clienteNuevo.Telefono); 

    }
    public override string ToString()

{
    string infoCliente = clienteNuevo.ToString();
    return $"Pedido: {nroPedido}\n" +
           $"Observación: {observacion}\n" +
           $"Estado: {estado}\n" +
           $"Cliente: {infoCliente}\n" +
          
           $"Id Cadete al que pertenece: {idCadete}"; 
          
}
}