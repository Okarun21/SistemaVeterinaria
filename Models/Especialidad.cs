public class Especialidad
{
    public String Nombre { get; set; }
    public String Descripcion { get; set; }

    public Especialidad(String nombre, String descripcion)
    {
        Nombre = nombre;
        Descripcion = descripcion;
    }

}