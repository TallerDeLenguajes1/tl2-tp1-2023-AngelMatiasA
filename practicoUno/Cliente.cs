using System; 
namespace EspacioCliente; 

public class Cliente
{ 
    private string nombre; 
    private string direccion; 
    private string telefono;
    private string DatosRefCliente;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string DatosRefCliente1 { get => DatosRefCliente; set => DatosRefCliente = value; }
}