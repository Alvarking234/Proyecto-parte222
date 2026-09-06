public class Cliente
{

    private int codigo;
    private string nombre;
    private string telefono;
    private string correo;
    private string direccion;
    private int solicitudes;

    public int Codigo

    public PaqueteFragil(int codigo, string descripcion, double peso,
                         double valorDeclarado, string direccionOrigen,
                         string direccionDestino)

        : base(codigo, descripcion, peso, valorDeclarado,
               direccionOrigen, direccionDestino, "Paquete frágil")

    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nombre
    {

        get { return nombre; }
        set { nombre = value; }

        return 35 + (distancia * 5) + (peso * 3);


    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public string Correo
    {
        get { return correo; }
        set { correo = value; }
    }

    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    public int Solicitudes
    {
        get { return solicitudes; }
        set { solicitudes = value; }
    }

    public Cliente()
    {
        solicitudes = 0;
    }

    public Cliente(int codigo, string nombre, string telefono,
                   string correo, string direccion)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.telefono = telefono;
        this.correo = correo;
        this.direccion = direccion;
        this.solicitudes = 0;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Teléfono: " + Telefono);
        Console.WriteLine("Correo: " + Correo);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Solicitudes: " + Solicitudes);
    }
}
