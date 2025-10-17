namespace Modelo_Veterinaria.Models
{
    public class HistorialClinico
    {
        public List<RegistroClinico> Registros { get; set; }

        public HistorialClinico(List<RegistroClinico> registros)
        {
            Registros = registros;
        }
    }
}