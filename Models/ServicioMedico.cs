namespace Modelo_Veterinaria.Models
{
    public class ServicioMedico
    {
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public String Detalles { get; set; }

        public ServicioMedico(DateTime fecha, String descripcion, String detalles)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Detalles = detalles;
        }

    }
}