public class RegistroClinico
{
    public int IdRegistroClinico { get; set; }
    public DateTime Fecha { get; set; }
    public String Diagnostico { get; set; }
    public String Tratamiento { get; set; }
    public ServicioMedico servicioMedico { get; set; }

    public RegistroClinico(int idregistroclinico, DateTime fecha, String diagnostico, String tratamiento, ServicioMedico serviciomedico)
    {
        IdRegistroClinico = idregistroclinico;
        Fecha = fecha;
        Diagnostico = diagnostico;
        Tratamiento = tratamiento;
        servicioMedico = serviciomedico;
    }


}