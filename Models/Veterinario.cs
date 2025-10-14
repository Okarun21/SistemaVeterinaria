public class Veterinario : Persona
{
    public string Matricula { get; set; }
    public List<Especialidad> Especialidades { get; set; }
    public ServicioMedico ServicioMedico { get; set; }

    public Veterinario(int id_persona, string nombres, string apellidos, int telefono, string direccion,
                       string matricula, List<Especialidad> especialidades, ServicioMedico servicioMedico)
       : base(id_persona, nombres, apellidos, telefono, direccion)
    {
        Matricula = matricula;
        Especialidades = especialidades ?? new List<Especialidad>();
        ServicioMedico = servicioMedico;
    }
}
