namespace SRCadeteria;

public enum Estado
{
    Pendiente,
    Entregado
}

public class Pedido
{
    private int? nro;
    private string? obsercaciones;
    private Estado? estado;
    private Cliente? cliente;


    public int? Nro { get => nro; set => nro = value; }
    public string? Obsercaciones { get => obsercaciones; set => obsercaciones = value; }
    public Estado? Estado { get => estado; set => estado = value; }
    public Cliente? Cliente { get => cliente; set => cliente = value; }
   
    public Pedido(int? nro, string? obsercaciones, Estado? estado, string nombreCliente, string direccionCliente, string telefonoCliente, string datosReferenciaDireccionCliente)
    {
        this.nro = nro;
        this.obsercaciones = obsercaciones;
        this.estado = SRCadeteria.Estado.Pendiente;
        this.cliente = new Cliente(nombreCliente,direccionCliente, telefonoCliente, datosReferenciaDireccionCliente);
    }

    public void verDireccionCliente()
    {
        Console.WriteLine(": : : Direccion del cliente : : :");
        Console.WriteLine("Direccion: " + cliente?.Direccion);
    }

    public void verDatosCliente()
    {
        Console.WriteLine(": : : Datos del cliente : : :");
        Console.WriteLine("Nombre: " + cliente?.Nombre);
        Console.WriteLine("Direccion: " + cliente?.Direccion);
        Console.WriteLine("Telefon: " + cliente?.Telefono);
        Console.WriteLine("Datos de referencia: " + cliente?.DatosReferenciaDireccion);
    }
}