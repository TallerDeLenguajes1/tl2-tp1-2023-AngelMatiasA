using System; 
namespace EspacioCliente; 

public class Cliente
{ 
    private string nombre; 
    private string direccion; 
    private string ? telefono;
    private string DatosRefCliente;

    public Cliente(string nom,string dire,string telefono,string datref)

    {
        this.nombre=nom;
        this.direccion=dire;
        this.telefono = telefono; 
        this.DatosRefCliente = datref;
    }

    public string Nombre { get => nombre;  }
    public string Telefono { get => telefono;  }
    // public string Direccion { get => direccion;  }
    public string Direccion (){
        return this.direccion;
    }
    
    public string DatosRefCliente1 { get => DatosRefCliente; set => DatosRefCliente = value; }

    // internal string Direccion()
    // {
    //     throw new NotImplementedException();
    // }
}