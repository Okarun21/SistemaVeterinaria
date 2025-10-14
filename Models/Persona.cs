public class Persona
{
    public int Id_Persona { get; set; }
    public String Nombres { get; set; }
    public String Apellidos { get; set; }
    public int Telefono { get; set; }
    public String Direccion { get; set; }
    
    public Persona(int id_persona, String nombres, String apellidos, int telefono, String direccion)
    {
        Id_Persona = id_persona;
        Nombres = nombres;
        Apellidos = apellidos;
        Telefono = telefono;
        Direccion = direccion;
    }
}